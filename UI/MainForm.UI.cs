using Newtonsoft.Json;
using NVorbis;
using System.Diagnostics;
using static SSR_Music_Packer.AssetEditor;
using static SSR_Music_Packer_GUI.Areas;

namespace SSR_Music_Packer_GUI;

public partial class MainForm {

    private bool listBox1Initialized = false;
    private bool updatingWindow = false;
    private bool silentUseOtherMusicCheckbox = false;
    private bool silentComboBox = false;
    private string DefaultTitle = "System ReShock Music Tool";
    private string _currentFileName = "";
    private bool _changed = false;

    public string CurrentFileName {
        get => _currentFileName;
        set
        {
            _currentFileName = value;
            RefreshWindowTitle();
        }
    }

    public bool Changed {
        get => _changed;
        set
        {
            _changed = value;
            RefreshWindowTitle();
        }
    }

    public double IntroTrackLoopTime => Utils.GetLoopSeconds(paths[currentArea].BPM, paths[currentArea].IntroMeasures, 4);

    public double MainTrackLoopTime => Utils.GetLoopSeconds(paths[currentArea].BPM, paths[currentArea].MainMeasures, 4);

    private void SetUseOtherLevelState(bool state) {
        silentUseOtherMusicCheckbox = true;
        checkBox_UseOtherLevel.Checked = state;
        silentUseOtherMusicCheckbox = false;
    }

    public void RefreshWindowTitle() {
        Text = "";
        if (Changed)
            Text += "*";
        Text = Text + DefaultTitle + " - ";
        if (CurrentFileName != null && CurrentFileName != "")
            Text += Path.GetFileNameWithoutExtension(CurrentFileName);
        else
            Text += "Unsaved Project";
    }

    public void LoadSettings() {
        try {
            string str = File.ReadAllText(Path.Combine(".", SettingsFileName));
            if (str == null) return;
            ProgramPreferences programPreferences = JsonConvert.DeserializeObject<ProgramPreferences>(str);
            if (programPreferences != null && programPreferences.HasAllProperties())
                Preferences = programPreferences;
        } catch {
        }
    }

    public void InitializeLevelList() {
        if (listBox1Initialized) return;
        listBox1.DataSource = Enum.GetValues(typeof(Area));
        listBox1Initialized = true;
        listBox1.SelectedIndex = 0;
        UpdateWindow();
    }

    public void UpdateRecents() {
        toolStripMenuItem_Recents.DropDownItems.Clear();
        toolStripMenuItem_Recents.DropDownItems.AddRange(Preferences.recents.GetItems());
    }

    public void OpenProjectFile(string filename = null, bool newproject = false) {
        Enabled = false;
        if ((!Changed || MessageBox.Show("You will lose any unsaved data if you load a project, continue?", "Load?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)) {
            if (newproject) {
                Changed = false;
                CurrentFileName = "";
                SerializableProject serializableProject = new SerializableProject(SerializableProject.SaveVersion, GetDefaultMusicSharingMap(), GetDefaultPaths());
                serializableProject.Restore(this);
            } else if (filename != null || openFileDialog_JSON.ShowDialog() == DialogResult.OK) {
                string file_to_read = filename ?? openFileDialog_JSON.FileName;
                if (!File.Exists(file_to_read)) {
                    Enabled = true;
                    return;
                }
                string str = File.ReadAllText(file_to_read);
                if (str != null) {
                    try {
                        SerializableProject serializableProject = JsonConvert.DeserializeObject<SerializableProject>(str);
                        if (serializableProject != null && serializableProject.HasAllProperties()) {
                            int? saveVersion1 = serializableProject.save_version;
                            int saveVersion2 = SerializableProject.SaveVersion;
                            if (!(saveVersion1.GetValueOrDefault() == saveVersion2 & saveVersion1.HasValue) && !MsgBox_Question_YesNo("This project seems to have been saved with a different version of this program. Try to load anyway?", "Version Mismatch")) {
                                Enabled = true;
                                return;
                            }
                            serializableProject.Restore(this);
                            CurrentFileName = file_to_read;
                            Preferences.recents.AddItem(CurrentFileName);
                            Utils.SavePreferencesToFile();
                            Changed = false;
                        } else {
                            int num = (int)MessageBox.Show("Error trying to load that file!", "Project Load Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    } catch (Exception ex) {
                        Debug.WriteLine(ex);
                        int num = (int)MessageBox.Show("Error trying to load that file!", "Project Load Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }
        Enabled = true;
    }

    public void UpdateWindow() {
        updatingWindow = true;
        if (listBox1Initialized) {
            currentArea = (Area)listBox1.SelectedItem;
            numericUpDown_Volume.Value = (decimal)paths[currentArea].Volume * 100;
            numericUpDown_BPM.Value = (decimal)paths[currentArea].BPM;
            numericUpDown_IntroMeasures.Value = paths[currentArea].IntroMeasures;
            numericUpDown_MainMeasures.Value = paths[currentArea].MainMeasures;
            groupBox_MusicFiles.Text = GetAreaName(currentArea) + " - Music Files";
            groupBox_MusicSettings.Text = GetAreaName(currentArea) + " - Music Settings";
            numBox_PreDelay.Value = paths[currentArea].PreDelayMeasures;
            numBox_PostDelay.Value = paths[currentArea].PostDelayMeasures;
            UpdateLoopButton();
            UpdateFilenameDisplays();
            UpdateLoopTimes();
            InitializeSharingMapAndUpdateDropdown();
        }

        bool hasRepak = Preferences.repakPath != "";
        if (!hasRepak || Preferences.exportAsFolders || Preferences.exportSeparately) {
            if (hasRepak && Preferences.exportSeparately && !Preferences.exportAsFolders) {
                exportProjectAspakToolStripMenuItem.Text = "Export Project as split .pak files...";
            } else {
                exportProjectAspakToolStripMenuItem.Text = "Export Project as assets to folder...";
            }
        } else {
            exportProjectAspakToolStripMenuItem.Text = "Export Project as .pak...";
        }

        bool isSpecial = IsSpecialScene(currentArea);
        groupBox_MusicSettings.Enabled = !isSpecial;
        button_Select_IntroTrack.Enabled = !isSpecial;
        groupBox_IntroTrack.Enabled = !isSpecial;
        numericUpDown_MainMeasures.Enabled = !isSpecial;
        label_IntroLoopTime.Enabled = !isSpecial;
        label_MainLoopTime.Enabled = !isSpecial;
        updatingWindow = false;
    }

    private void UpdateLoopButton() {
        button_AutoLoop.Enabled = !IsSpecialScene(currentArea) && paths[currentArea].InputMusic_Intro_FileName == "" && paths[currentArea].InputMusic_Main_FileName != "";
    }

    private void UpdateLoopTimes() {
        label_IntroLoopTime.Text = string.Format("{0:0.0000}", IntroTrackLoopTime);
        toolTip1.SetToolTip(label_IntroLoopTime, string.Format("The Main track will play after {0} seconds.\nAdjust BPM and Measures to change ", IntroTrackLoopTime));
        label_MainLoopTime.Text = string.Format("{0:0.0000}", MainTrackLoopTime);
        toolTip1.SetToolTip(label_MainLoopTime, string.Format("The Main track will loop after {0} seconds.\nAdjust BPM and Measures to change ", MainTrackLoopTime));
    }

    private void InitializeSharingMapAndUpdateDropdown() {
        silentComboBox = true;
        bool samefound = false;
        Area area = Area.Reactor;
        List<Area> areaList = new List<Area>();
        foreach (Area a in GetArrayOfAreas()) {
            if (currentArea > a && musicSharingMap[a] == a) {
                areaList.Add(a);
                if (!samefound && GeneralAreaInfo[currentArea].MusicData == GeneralAreaInfo[a].MusicData) {
                    samefound = true;
                    area = a;
                }
            }
        }
        combobox_UseFromOtherLevel.DataSource = areaList;

        if (musicSharingMap.ContainsKey(currentArea) && musicSharingMap[currentArea] != currentArea) {
            SetUseOtherLevelState(true);
            combobox_UseFromOtherLevel.SelectedItem = musicSharingMap[currentArea];
        } else if (musicSharingMap[currentArea] == currentArea)
            SetUseOtherLevelState(false);
        else if (samefound) {
            SetUseOtherLevelState(true);
            combobox_UseFromOtherLevel.SelectedItem = area;
        } else
            SetUseOtherLevelState(false);
        silentComboBox = false;
    }

    private void SaveJSONDialog() {
        if (!Enabled || saveFileDialog_JSON.ShowDialog() != DialogResult.OK) return;
        SaveAsJSONToFile(saveFileDialog_JSON.FileName);
    }

    private void SaveAsJSONToFile(string filename) {
        if (!Enabled) return;
        Enabled = false;
        if (filename != null && filename != "") {
            SerializableProject proj = new SerializableProject(SerializableProject.SaveVersion, musicSharingMap, paths);
            string contents = JsonConvert.SerializeObject(proj, Formatting.Indented);
            File.WriteAllText(filename, contents);
            CurrentFileName = filename;
            Preferences.recents.AddItem(CurrentFileName);
            Changed = false;
        }
        Enabled = true;
    }

    private void QuickSave() {
        if (!Enabled) return;
        if (CurrentFileName == null || CurrentFileName == "")
            SaveJSONDialog();
        else
            SaveAsJSONToFile(CurrentFileName);
    }

    public bool MsgBox_Question_YesNo(string message, string title) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;

    private void UpdateFilenameDisplays() {
        if (Preferences.showFullMusicFilePaths) {
            label_IntroTrack_Filename.Text = paths[currentArea].InputMusic_Intro_FileName == "" ? "<none!>" : paths[currentArea].InputMusic_Intro_FileName;
            label_MainTrack_Filename.Text = paths[currentArea].InputMusic_Main_FileName == "" ? "<none!>" : paths[currentArea].InputMusic_Main_FileName;
        } else {
            label_IntroTrack_Filename.Text = paths[currentArea].InputMusic_Intro_FileName == "" ? "<none!>" : Path.GetFileName(paths[currentArea].InputMusic_Intro_FileName);
            label_MainTrack_Filename.Text = paths[currentArea].InputMusic_Main_FileName == "" ? "<none!>" : Path.GetFileName(paths[currentArea].InputMusic_Main_FileName);
        }
        toolTip1.SetToolTip(label_IntroTrack_Filename, paths[currentArea].InputMusic_Intro_FileName);
        toolTip1.SetToolTip(label_MainTrack_Filename, paths[currentArea].InputMusic_Main_FileName);
        UpdateLoopButton();
    }

    #region Events
    private void On_UseOtherLevel_CheckStateChanged(CheckBox sender, EventArgs e) {
        bool _checked = sender.Checked;
        combobox_UseFromOtherLevel.Enabled = _checked;
        groupBox_MusicFiles.Enabled = !_checked;
        numericUpDown_BPM.Enabled = !_checked;
        label_BPM.Enabled = !_checked;
        checkBox_UseOtherLevel.BackColor = groupBox_MusicFiles.Enabled ? Color.FromKnownColor(KnownColor.Control) : Color.FromArgb(96, 64, 0, 255);
        if (currentArea == Area.Reactor) {
            sender.Checked = false;
        } else {
            if (silentUseOtherMusicCheckbox) return;
            musicSharingMap[currentArea] = _checked ? (Area)combobox_UseFromOtherLevel.SelectedItem : currentArea;
            Changed = true;
        }
    }

    /*private void On_RestoreDefaultFilepaths_Click(Button sender, EventArgs e) {
        paths[currentArea].RestoreDefaultFiles();
        UpdateFilenameDisplays();
        Changed = true;
    }*/

    private void On_AboutMenuItem_Click(ToolStripMenuItem sender, EventArgs e) {
        using (AboutForm aboutForm = new AboutForm()) {
            aboutForm.ShowDialog();
            aboutForm.Dispose();
        }
    }

    private void On_SaveProjectAsJSONMenu_Click(ToolStripMenuItem sender, EventArgs e) {
        if (!Enabled) return;
        SaveJSONDialog();
    }

    private void On_ExitMenuButton_Click(ToolStripMenuItem sender, EventArgs e) => Close();

    private void On_SetVolumeOfAllMenuItem_Click(ToolStripMenuItem sender, EventArgs e) {
        using (VolumeDialog volumeDialog = new VolumeDialog(this))
            volumeDialog.ShowDialog();
    }

    private void On_PreferencesMenuItem_Click(ToolStripMenuItem sender, EventArgs e) {
        using (PreferencesDialog preferencesDialog = new PreferencesDialog(this))
            preferencesDialog.ShowDialog();
        UpdateWindow();
    }

    private void On_SaveMenuItem_Click(ToolStripMenuItem sender, EventArgs e) => QuickSave();

    private void On_OpenProjectMenuItem_Click(ToolStripMenuItem sender, EventArgs e) {
        OpenProjectFile();
    }

    private void On_PakExportMenuItem_Click(ToolStripMenuItem sender, EventArgs e) {
        Enabled = false;
        Utils.ExportProject(this);
        Enabled = true;
    }

    private void On_Volume_ValueChanged(NumericUpDown sender, EventArgs e) {
        if (updatingWindow) return;
        paths[currentArea].Volume = (float)(sender.Value / 100M);
        Changed = true;
    }

    private void On_BPM_ValueChanged(NumericUpDown sender, EventArgs e) {
        if (updatingWindow) return;
        paths[currentArea].BPM = (double)sender.Value;
        UpdateLoopTimes();
        Changed = true;
    }

    /*private void On_ResetAllMenuItem_Click(ToolStripMenuItem sender, EventArgs e) {
        if (!MsgBox_Question_YesNo("Reset all file paths? You will lose unsaved data.", "Reset?")) return;
        Enabled = false;
        foreach (Area key in paths.Keys) paths[key].RestoreDefaultFiles();
        UpdateWindow();
        Changed = true;
        Enabled = true;
    }*/

    private void On_ClearPaths_Click(Button sender, EventArgs e) {
        paths[currentArea].InputMusic_Intro_FileName = "";
        paths[currentArea].InputMusic_Main_FileName = "";
        Changed = true;
        UpdateFilenameDisplays();
    }

    private void On_ClearIntroTrack_Click(Button sender, EventArgs e) {
        paths[currentArea].InputMusic_Intro_FileName = "";
        UpdateFilenameDisplays();
        Changed = true;
    }

    private void On_ClearMainTrack_Click(Button sender, EventArgs e) {
        paths[currentArea].InputMusic_Main_FileName = "";
        UpdateFilenameDisplays();
        Changed = true;
    }

    private void On_TryClosingProgram(FormClosingEventArgs e) => e.Cancel = !MsgBox_Question_YesNo("Are you sure you want to exit?", "Close Program");

    private void On_UseFromOtherLevel_ValueChanged(ComboBox sender, EventArgs e) {
        if (silentComboBox || !sender.Enabled) return;
        musicSharingMap[currentArea] = (Area)sender.SelectedValue;
        Changed = true;
    }

    private void On_Select_IntroTrack_Click(Button sender, EventArgs e) {
        if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
        if (!Utils.FileIsOgg(openFileDialog1.FileName)) {
            MessageBox.Show("The selected file doesn't seem to be an OGG audio file. Only OGG files are supported.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        } else {
            paths[currentArea].InputMusic_Intro_FileName = openFileDialog1.FileName;
            UpdateFilenameDisplays();
            Changed = true;
        }
    }

    private void On_Select_MainTrack_Click(Button sender, EventArgs e) {
        if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
        if (!Utils.FileIsOgg(openFileDialog1.FileName)) {
            MessageBox.Show("The selected file doesn't seem to be an OGG audio file. Only OGG files are supported.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        } else {
            paths[currentArea].InputMusic_Main_FileName = openFileDialog1.FileName;
            UpdateFilenameDisplays();
            Changed = true;
        }
    }

    private void On_PreDelay_ValueChanged(NumericUpDown sender, EventArgs e) {
        if (updatingWindow) return;
        paths[currentArea].PreDelayMeasures = (int)sender.Value;
        Changed = true;
    }

    private void On_PostDelay_ValueChanged(NumericUpDown sender, EventArgs e) {
        if (updatingWindow) return;
        paths[currentArea].PostDelayMeasures = (int)sender.Value;
        Changed = true;
    }

    private void On_IntroMeasures_ValueChanged(NumericUpDown sender, EventArgs e) {
        if (updatingWindow) return;
        paths[currentArea].IntroMeasures = (int)sender.Value;
        UpdateLoopTimes();
        Changed = true;
    }

    private void On_MainMeasures_ValueChanged(NumericUpDown sender, EventArgs e) {
        if (updatingWindow)
            return;
        paths[currentArea].MainMeasures = (int)sender.Value;
        UpdateLoopTimes();
        Changed = true;
    }

    private void On_LevelListBox_KeyDown(ListBox sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up) return;
        e.SuppressKeyPress = true;
    }

    private void On_LevelListBox_KeyPress(ListBox sender, KeyPressEventArgs e) {
        e.Handled = true;
    }

    private void On_MainForm_KeyDown(MainForm sender, KeyEventArgs e) {
        if (!e.Control || e.KeyCode != Keys.S) return;
        QuickSave();
        e.SuppressKeyPress = true;
    }

    private void On_AutoLoop_Click(Button sender, EventArgs e) {
        Enabled = false;
        string main = paths[currentArea].InputMusic_Main_FileName;
        string intro = paths[currentArea].InputMusic_Intro_FileName;
        if (main != "" && File.Exists(main)) {
            using (VorbisReader oggdata = new VorbisReader(main)) {
                double totalTime = oggdata.TotalTime.TotalSeconds;
                double unroundedMeasures = totalTime / 2.0d;
                int measures = Math.Max(1, (int)Math.Floor(unroundedMeasures));
                double BPM = ((4 * 60 * unroundedMeasures) / totalTime) * (measures / unroundedMeasures);
                paths[currentArea].BPM = BPM;
                paths[currentArea].MainMeasures = measures;
                /*if (intro != "" && File.Exists(intro)) {
                    using (VorbisReader introdata = new VorbisReader(intro)) {
                        double timePerMeasure = (60 / BPM) * 4;
                        double introTotalTime = introdata.TotalTime.TotalSeconds;
                        if (introTotalTime % timePerMeasure > 0.0001d) {
                            MessageBox.Show("The length of the Intro track does not quite line up with the timing that was generated for the Main track.\nConsider editing the audio tracks and/or providing the correct timings manually.", "Auto Loop Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        paths[currentArea].IntroMeasures = (int)Math.Round(introTotalTime / timePerMeasure);
                    }
                }*/
                UpdateWindow();
            }
        }
        Enabled = true;
    }

    private void On_Recents_Opening(ToolStripMenuItem sender, EventArgs e) {
        UpdateRecents();
    }

    private void On_Recents_SubItemClick(ToolStripMenuItem sender, ToolStripItemClickedEventArgs e) {
        if (e.ClickedItem.Tag != null) OpenProjectFile((string)e.ClickedItem.Tag);
    }
    private void On_New_MenuItemClick(ToolStripMenuItem sender, EventArgs e) {
        OpenProjectFile(newproject: true);
    }
    #endregion
}
