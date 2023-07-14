using System.Diagnostics;
using static SSR_Music_Packer_GUI.MainForm;

namespace SSR_Music_Packer_GUI;
public partial class PreferencesDialog : Form {

    bool bUpdatingWindow = false;

    public PreferencesDialog(MainForm _parent) {
        InitializeComponent();
        UpdateWindow();
    }

    private void checkBox_ShowFullPaths_CheckedChanged(object sender, EventArgs e) {
        if (bUpdatingWindow) return;
        Preferences.showFullMusicFilePaths = ((CheckBox)sender).Checked;
        UpdateWindow();
    }

    private void UpdateWindow() {
        Enabled = false;
        bUpdatingWindow = true;
        checkBox_ShowFullPaths.Checked = Preferences.showFullMusicFilePaths;
        checkBox_ExportSeparately.Checked = Preferences.exportSeparately;
        checkBox_ExportAsFolder.Checked = Preferences.exportAsFolders;
        checkBox_DisableMFDDucking.Checked = Preferences.useMFDPatch;
        checkBox_HidePakWarnings.Checked = Preferences.hideSkippedWarnings;
        label_RepakPath.Text = Preferences.repakPath == "" ? "<no file selected>" : Preferences.repakPath;
        bUpdatingWindow = false;
        Enabled = true;
    }

    private void PreferencesDialog_FormClosed(object sender, FormClosedEventArgs e) {
        Utils.SavePreferencesToFile();
    }

    private void button2_Click(object sender, EventArgs e) {
        Preferences.repakPath = "";
        UpdateWindow();
    }

    private void button1_Click(object sender, EventArgs e) {
        if (openFileDialog1.ShowDialog() == DialogResult.OK) {
            Preferences.repakPath = openFileDialog1.FileName;
            UpdateWindow();
        }
    }

    private void button3_Click(object sender, EventArgs e) {
        Close();
    }

    private void checkBox_ExportSeparately_CheckedChanged(object sender, EventArgs e) {
        if (bUpdatingWindow) return;
        Preferences.exportSeparately = ((CheckBox)sender).Checked;
    }

    private void checkBox_ExportAsFolder_CheckedChanged(object sender, EventArgs e) {
        if (bUpdatingWindow) return;
        Preferences.exportAsFolders = ((CheckBox)sender).Checked;
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e) {
        if (bUpdatingWindow) return;
        Preferences.useMFDPatch = ((CheckBox)sender).Checked;
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
        if (MessageBox.Show("This link will bring you to: https://github.com/trumank/repak/releases/\nDownload repak.exe, place it anywhere, and set its path in the Preferences window.", "Download Repak", MessageBoxButtons.OKCancel) == DialogResult.OK) {
            ((LinkLabel)sender).LinkVisited = true;
            Process.Start("explorer", "https://github.com/trumank/repak/releases/");
        }
    }

    private void checkBox_HidePakWarnings_CheckedChanged(object sender, EventArgs e) {
        if (bUpdatingWindow) return;
        Preferences.hideSkippedWarnings = ((CheckBox)sender).Checked;
    }
}
