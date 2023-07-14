using static SSR_Music_Packer_GUI.Areas;

namespace SSR_Music_Packer_GUI;

public partial class MainForm : Form {

    public static ProgramPreferences Preferences = new(true, false, false, "", new RecentList<string>());
    public static string SettingsFileName {
        get { return "settings"; }
    }

    Area currentArea = Area.Reactor;

    public MainForm() {
        InitializeComponent();
        RefreshWindowTitle();
        LoadSettings();
    }

    #region Event Bindings

    private void Form1_Load(object sender, EventArgs e) {
        InitializeLevelList();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
        UpdateWindow();
    }

    private void checkBox_UseOtherLevel_CheckStateChanged(object sender, EventArgs e) {
        On_UseOtherLevel_CheckStateChanged((CheckBox)sender, e);
    }

    /*private void button3_Click(object sender, EventArgs e) {
        On_RestoreDefaultFilepaths_Click((Button)sender, e);
    }*/

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
        On_AboutMenuItem_Click((ToolStripMenuItem)sender, e);
    }

    private void numericUpDown_Volume_ValueChanged(object sender, EventArgs e) {
        On_Volume_ValueChanged((NumericUpDown)sender, e);
    }

    /*private void resetToolStripMenuItem_Click(object sender, EventArgs e) {
        On_ResetAllMenuItem_Click((ToolStripMenuItem)sender, e);
    }*/

    private void button_Clear_IntroTrack_Click(object sender, EventArgs e) {
        On_ClearIntroTrack_Click((Button)sender, e);
    }

    private void button_Clear_MainTrack_Click(object sender, EventArgs e) {
        On_ClearMainTrack_Click((Button)sender, e);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
        On_ExitMenuButton_Click((ToolStripMenuItem)sender, e);
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
        On_TryClosingProgram(e);
    }

    private void combobox_UseFromOtherLevel_SelectedValueChanged(object sender, EventArgs e) {
        On_UseFromOtherLevel_ValueChanged((ComboBox)sender, e);
    }

    private void button_Select_IntroTrack_Click(object sender, EventArgs e) {
        On_Select_IntroTrack_Click((Button)sender, e);
    }

    private void button_Select_MainTrack_Click(object sender, EventArgs e) {
        On_Select_MainTrack_Click((Button)sender, e);
    }

    private void setVolumeOfAllLevelsToolStripMenuItem_Click(object sender, EventArgs e) {
        On_SetVolumeOfAllMenuItem_Click((ToolStripMenuItem)sender, e);
    }

    private void numericUpDown_BPM_ValueChanged(object sender, EventArgs e) {
        On_BPM_ValueChanged((NumericUpDown)sender, e);
    }

    private void button_ClearPaths_Click(object sender, EventArgs e) {
        On_ClearPaths_Click((Button)sender, e);
    }

    private void numericUpDown_IntroMeasures_ValueChanged(object sender, EventArgs e) {
        On_IntroMeasures_ValueChanged((NumericUpDown)sender, e);
    }

    private void numericUpDown_MainMeasures_ValueChanged(object sender, EventArgs e) {
        On_MainMeasures_ValueChanged((NumericUpDown)sender, e);
    }

    private void saveProjectAsJSONToolStripMenuItem_Click(object sender, EventArgs e) {
        On_SaveProjectAsJSONMenu_Click((ToolStripMenuItem)sender, e);
    }

    private void openProjectFromJSONToolStripMenuItem_Click(object sender, EventArgs e) {
        On_OpenProjectMenuItem_Click((ToolStripMenuItem)sender, e);
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e) {
        On_MainForm_KeyDown((MainForm)sender, e);
    }

    private void listBox1_KeyDown(object sender, KeyEventArgs e) {
        On_LevelListBox_KeyDown((ListBox)sender, e);
    }

    private void listBox1_KeyPress(object sender, KeyPressEventArgs e) {
        On_LevelListBox_KeyPress((ListBox)sender, e);
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e) {
        On_SaveMenuItem_Click((ToolStripMenuItem)sender, e);
    }

    private void preferencesToolStripMenuItem_Click(object sender, EventArgs e) {
        On_PreferencesMenuItem_Click((ToolStripMenuItem)sender, e);
    }

    private void numericUpDown_BPM_KeyUp(object sender, KeyEventArgs e) {
        On_BPM_ValueChanged((NumericUpDown)sender, e);
    }

    private void numBox_PreDelay_ValueChanged(object sender, EventArgs e) {
        On_PreDelay_ValueChanged((NumericUpDown)sender, e);
    }

    private void numBox_PostDelay_ValueChanged(object sender, EventArgs e) {
        On_PostDelay_ValueChanged((NumericUpDown)sender, e);
    }
    private void numericUpDown_IntroMeasures_KeyUp(object sender, KeyEventArgs e) {
        On_IntroMeasures_ValueChanged((NumericUpDown)sender, e);
    }

    private void numericUpDown_MainMeasures_KeyUp(object sender, KeyEventArgs e) {
        On_MainMeasures_ValueChanged((NumericUpDown)sender, e);
    }

    private void numericUpDown_Volume_KeyUp(object sender, KeyEventArgs e) {
        On_Volume_ValueChanged((NumericUpDown)sender, e);
    }

    private void numBox_PreDelay_KeyUp(object sender, KeyEventArgs e) {
        On_PreDelay_ValueChanged((NumericUpDown)sender, e);
    }

    private void numBox_PostDelay_KeyUp(object sender, KeyEventArgs e) {
        On_PostDelay_ValueChanged((NumericUpDown)sender, e);
    }

    private void exportProjectAspakToolStripMenuItem_Click(object sender, EventArgs e) {
        On_PakExportMenuItem_Click((ToolStripMenuItem)sender, e);
    }
    private void button_AutoLoop_Click(object sender, EventArgs e) {
        On_AutoLoop_Click((Button)sender, e);
    }
    private void toolStripMenuItem_Recents_DropDownOpening(object sender, EventArgs e) {
        On_Recents_Opening((ToolStripMenuItem)sender, e);
    }
    private void toolStripMenuItem_Recents_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
        On_Recents_SubItemClick((ToolStripMenuItem)sender, e);
    }
    private void toolStripMenuItem_New_Click(object sender, EventArgs e) {
        On_New_MenuItemClick((ToolStripMenuItem)sender, e);
    }

    #endregion

}