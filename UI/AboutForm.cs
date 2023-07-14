using System.Diagnostics;
using System.Reflection;

namespace SSR_Music_Packer_GUI;
public partial class AboutForm : Form {
    public AboutForm() {
        InitializeComponent();
        Debug.Write(Assembly.GetExecutingAssembly().GetName().Version);
        label2.Text = String.Format("ver {0}", Assembly.GetExecutingAssembly().GetName().Version);
    }

    private void button1_Click(object sender, EventArgs e) {
        Close();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
        Process.Start("explorer", "https://www.nexusmods.com/systemshock2023/mods/78");
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
        Process.Start("explorer", "https://github.com/deerfarce/SystemReShock-MusicTool");
    }
}
