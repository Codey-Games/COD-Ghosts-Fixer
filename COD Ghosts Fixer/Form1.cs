using System;
using System.IO;
using IWshRuntimeLibrary;

namespace COD_Ghosts_Fixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findGame_Click(object sender, EventArgs e)
        {
            OpenFileDialog findGame = new OpenFileDialog();
            findGame.Filter = "Executable Files (iw6sp64_ship.exe)|iw6sp64_ship.exe|All Files (*.*)|*.*";
            findGame.Title = "Select an Executable File";

            if (findGame.ShowDialog() == DialogResult.OK)
            {
                path.Text = findGame.FileName;
            }
        }

        private void path_TextChanged(object sender, EventArgs e)
        {
            if (path.Text.EndsWith("iw6sp64_ship.exe") && path.Text[1] == ':' && path.Text[2] == '\\' && System.IO.File.Exists(path.Text))
            {
                addShortcuts.Enabled = true;
                removeShortcuts.Enabled = true;
                launchGame.Enabled = true;
                openFolder.Enabled = true;
            }
            else
            {
                addShortcuts.Enabled = false;
                removeShortcuts.Enabled = false;
                launchGame.Enabled = false;
                openFolder.Enabled = false;
            }
        }

        private void openFolder_Click(object sender, EventArgs e)
        {
            string directoryPath = Path.GetDirectoryName(path.Text) ?? ""; // fix "can be null" warning
            if (!string.IsNullOrEmpty(directoryPath)) // fix "can be null" warning
            {
                System.Diagnostics.Process.Start("explorer.exe", directoryPath);
            }
        }

        private void launchGame_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = path.Text,
                Verb = "runas", // This indicates that the process should be started with elevated privileges
                WorkingDirectory = Path.GetDirectoryName(path.Text)
            };

            System.Diagnostics.Process.Start(startInfo);
        }

        private void addShortcuts_Click(object sender, EventArgs e)
        {
            string folderPath = Path.GetDirectoryName(path.Text) ?? "";
            string filePath = path.Text;

            // get start menu path
            string startMenuProgramsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu), "Programs");
            string startMenuProgramsTargetPath = System.IO.Path.Combine(startMenuProgramsPath, "Call of Duty Ghosts - Fixed.lnk");

            // get desktop path
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string desktopTargetPath = System.IO.Path.Combine(desktopPath, "Call of Duty Ghosts - Fixed.lnk");

            // make desktop shortcut
            WshShell shellDesktop = new WshShell();
            IWshShortcut shortcutDesktop = (IWshShortcut)shellDesktop.CreateShortcut(desktopTargetPath);
            shortcutDesktop.TargetPath = filePath;
            shortcutDesktop.WorkingDirectory = folderPath;
            shortcutDesktop.Arguments = "-runAsAdministrator"; // idk if this actually does anything, someone said it did
            shortcutDesktop.Save();

            // make start menu shortcut
            WshShell shellStartMenu = new WshShell();
            IWshShortcut shortcutStartMenu = (IWshShortcut)shellStartMenu.CreateShortcut(startMenuProgramsTargetPath);
            shortcutStartMenu.TargetPath = filePath;
            shortcutStartMenu.WorkingDirectory = folderPath;
            shortcutStartMenu.Arguments = "-runAsAdministrator"; // idk if this actually does anything, someone said it did
            shortcutStartMenu.Save();
        }

        private void removeShortcuts_Click(object sender, EventArgs e)
        {
            string folderPath = Path.GetDirectoryName(path.Text) ?? "";
            string filePath = path.Text;

            // get start menu path
            string startMenuProgramsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu), "Programs");
            string startMenuProgramsTargetPath = System.IO.Path.Combine(startMenuProgramsPath, "Call of Duty Ghosts - Fixed.lnk");
            if (System.IO.File.Exists(startMenuProgramsTargetPath))
            {
                System.IO.File.Delete(startMenuProgramsTargetPath);
            }

            // get desktop path
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string desktopTargetPath = System.IO.Path.Combine(desktopPath, "Call of Duty Ghosts - Fixed.lnk");
            if (System.IO.File.Exists(desktopTargetPath))
            {
                System.IO.File.Delete(desktopTargetPath);
            }
        }
    }
}
