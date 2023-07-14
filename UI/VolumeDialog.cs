using SSR_Music_Packer;
using static SSR_Music_Packer.AssetEditor;
using static SSR_Music_Packer_GUI.Areas;

namespace SSR_Music_Packer_GUI;
public partial class VolumeDialog : Form {

    private float NewVolume {
        get
        {
            return (float)(numericUpDown_Volume.Value / (decimal)100.0);
        }
    }

    private MainForm main;

    enum ApplyTo {
        All,
        Only_Default,
        Only_NonDefault
    }

    ApplyTo areasToApplyTo = ApplyTo.All;

    public VolumeDialog(MainForm _main) {
        InitializeComponent();
        main = _main;
    }

    private void button2_Click(object sender, EventArgs e) {
        numericUpDown_Volume.Value = (decimal)(AssetEditor.DEFAULT_VOLUME * 100);
    }

    private void radioButton_All_CheckedChanged(object sender, EventArgs e) {
        onRadioCheck((RadioButton)sender, e, ApplyTo.All);
    }

    private void radioButton_OnlyDefault_CheckedChanged(object sender, EventArgs e) {
        onRadioCheck((RadioButton)sender, e, ApplyTo.Only_Default);
    }

    private void radioButton_OnlyNonDefault_CheckedChanged(object sender, EventArgs e) {
        onRadioCheck((RadioButton)sender, e, ApplyTo.Only_NonDefault);
    }

    private void onRadioCheck(RadioButton sender, EventArgs e, ApplyTo a) {
        if (sender.Checked) {
            areasToApplyTo = a;
        }
    }

    private void button_Apply_Click(object sender, EventArgs e) {
        Enabled = false;
        int count = 0;
        AreaMusicData path;
        foreach (Area area in paths.Keys) {
            if (IsSpecialScene(area)) continue;
            path = paths[area];
            if (areasToApplyTo == ApplyTo.All || (path.Volume == DEFAULT_VOLUME && areasToApplyTo == ApplyTo.Only_Default) || (path.Volume != DEFAULT_VOLUME && areasToApplyTo == ApplyTo.Only_NonDefault)) {
                path.Volume = NewVolume;
                count++;
            }
        }

        main.UpdateWindow();
        MessageBox.Show("Applied the new volume to " + count + " levels.", "Volume Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
        Enabled = true;
    }
}
