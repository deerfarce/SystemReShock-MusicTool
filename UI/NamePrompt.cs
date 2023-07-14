using SSR_Music_Packer;

namespace SSR_Music_Packer_GUI;
public partial class NamePrompt : Form {

    public enum PromptType {
        Pak,
        Folder
    }

    private PromptType pt;
    public string name = "";
    public NamePrompt(PromptType promptType) {
        pt = promptType;
        InitializeComponent();
        UpdatePreviewLabel("");
        SetTitle();
        FormatTopCaption();
    }

    private void SetTitle() {
        if (pt == PromptType.Pak) {
            Text = "Mod Name - Exporting as .pak file(s)";
        } else {
            Text = "Mod Name - Exporting as assets into folder";
        }
    }

    private void FormatTopCaption() {
        if (pt == PromptType.Pak) {
            label_TopCaption.Text = string.Format(label_TopCaption.Text, "Each file", "file names");
        } else {
            label_TopCaption.Text = string.Format(label_TopCaption.Text, "The main folder", "folder name");
        }
    }

    private void UpdatePreviewLabel(string str) {
        if (pt == PromptType.Pak) {
            if (str != "") str += "_";
            label_PreviewName.Text = "MusicMod_" + str + "Executive_P.pak";
        } else {
            if (str != "") str = "_" + str;
            label_PreviewName.Text = "MusicMod" + str;
        }
    }

    private void textBox1_TextChanged(object sender, EventArgs e) {
        name = textBox1.Text.TweakFileNameInput();
        UpdatePreviewLabel(name);
    }

    private void button_Export_Click(object sender, EventArgs e) {
        DialogResult = DialogResult.OK;
    }

    private void button_Cancel_Click(object sender, EventArgs e) {
        DialogResult = DialogResult.Cancel;
    }
}
