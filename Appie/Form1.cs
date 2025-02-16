using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Appie
{
    public partial class Form1 : Form
    {
        int PanelWidthFileloc;
        bool Hidden;
        public Form1()
        {
            InitializeComponent();
            PanelWidthFileloc = FileLocationPanel.Width;
            Hidden = true;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                FileLocationPanel.Width = FileLocationPanel.Width + 1100;
                if (FileLocationPanel.Width >= PanelWidthFileloc)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                FileLocationPanel.Width = FileLocationPanel.Width - 1100;
                if (FileLocationPanel.Width == 80)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void FileLocation_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void fltrans_Click(object sender, EventArgs e)
        {
            string sourcePath = flsrc.Text;  // Source path from textbox
            string destinationPath = flnwloc.Text;  // Destination path from textbox

            if (string.IsNullOrWhiteSpace(sourcePath) || string.IsNullOrWhiteSpace(destinationPath))
            {
                MessageBox.Show("Please enter both source and destination paths.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string batchScript =
                "@echo off\n" +
                "setlocal\n" +
                $"set source=\"{sourcePath}\"\n" +
                $"set destination=\"{destinationPath}\"\n" +
                "echo Moving files from \"%source%\" to \"%destination%\"...\n" +
                "robocopy \"%source%\" \"%destination%\" /sec /move /e\n" +
                "echo Creating symbolic link...\n" +
                "mklink /j \"%source%\" \"%destination%\"\n" +
                "echo Files moved and symbolic link created successfully.\n" +
                "pause";

            string batchFilePath = Path.Combine(Path.GetTempPath(), "moveFiles.bat");

            // Save batch script to a file
            File.WriteAllText(batchFilePath, batchScript);

            // Execute the batch file
            Process process = new Process();
            process.StartInfo.FileName = batchFilePath;
            process.StartInfo.Verb = "runas";  // Run as admin
            process.StartInfo.UseShellExecute = true;
            process.Start();

            MessageBox.Show("Process started. Follow the command prompt.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
