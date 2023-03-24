namespace GREditorialSupport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            switch (editingMethodomboBox.Text)
            {
                case "GitHubDevウェブエディター":
                    if (mainEditCheckBox.Checked)
                    {
                        var startInfo = new System.Diagnostics.ProcessStartInfo("https://github.dev/Game-Resources/Game-Resources.github.io");
                        startInfo.UseShellExecute = true;
                        System.Diagnostics.Process.Start(startInfo);
                    }
                    if (contentEditCheckBox.Checked)
                    {
                        var startInfo = new System.Diagnostics.ProcessStartInfo("https://github.dev/Game-Resources/Content");
                        startInfo.UseShellExecute = true;
                        System.Diagnostics.Process.Start(startInfo);
                    }
                    if (postEditCheckBox.Checked)
                    {
                        var startInfo = new System.Diagnostics.ProcessStartInfo("https://github.dev/Game-Resources/Post");
                        startInfo.UseShellExecute = true;
                        System.Diagnostics.Process.Start(startInfo);
                    }

                    break;
                case "VisualStudioCode":
                    if (mainEditCheckBox.Checked)
                    {
                        System.Diagnostics.Process.Start("cmd.exe", "/k github \"C:\\GitHub\\Game-Resources.github.io\"");
                        System.Diagnostics.Process.Start("cmd.exe", "/k code \"C:\\GitHub\\Game-Resources.github.io\"");
                    }
                    if (contentEditCheckBox.Checked)
                    {
                        System.Diagnostics.Process.Start("cmd.exe", "/k github \"C:\\GitHub\\Content\"");
                        System.Diagnostics.Process.Start("cmd.exe", "/k code \"C:\\GitHub\\Content\"");
                    }
                    if (postEditCheckBox.Checked)
                    {
                        System.Diagnostics.Process.Start("cmd.exe", "/k github \"C:\\GitHub\\Post\"");
                        System.Diagnostics.Process.Start("cmd.exe", "/k code \"C:\\GitHub\\Post\"");
                    }

                    break;
                case "VisualStudioCodeInsiders":
                    if (mainEditCheckBox.Checked)
                    {
                        System.Diagnostics.Process.Start("cmd.exe", "/k github \"C:\\GitHub\\Game-Resources.github.io\"");
                        System.Diagnostics.Process.Start("cmd.exe", "/k code-insiders \"C:\\GitHub\\Game-Resources.github.io\"");
                    }
                    if (contentEditCheckBox.Checked)
                    {
                        System.Diagnostics.Process.Start("cmd.exe", "/k github \"C:\\GitHub\\Content\"");
                        System.Diagnostics.Process.Start("cmd.exe", "/k code-insiders \"C:\\GitHub\\Content\"");
                    }
                    if (postEditCheckBox.Checked)
                    {
                        System.Diagnostics.Process.Start("cmd.exe", "/k github \"C:\\GitHub\\Post\"");
                        System.Diagnostics.Process.Start("cmd.exe", "/k code-insiders \"C:\\GitHub\\Post\"");
                    }

                    break;
            }
        }
    }
}