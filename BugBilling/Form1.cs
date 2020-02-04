using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;

namespace BugBilling {
    public partial class MainUI : Form {

        private string WorkDirectory = string.Empty; //for export logs
        private string GameDir = string.Empty; //Get current game path via regedit and save here :3
        private string GameLogPath = string.Empty; //GameLog last file path
        private string launcher_logPath = string.Empty; //launcherlog
        private string Screenpath = string.Empty; //

        public MainUI() {
            InitializeComponent();
            GetGF();
        }

        /// <summary>
        /// Get latest logs from folders
        /// </summary>
        private void GetLogs() {
            try {
                //.clog
                FileInfo gLogFile = Directory.EnumerateFiles(Path.Combine(GameDir, ".game_logs"), "*.clog")
                .Select(file_path => new FileInfo(file_path))
                .OrderByDescending(file_info => file_info.LastWriteTime)
                .FirstOrDefault();

                //launcher log (.txt)
                FileInfo launcherLogFile = Directory.EnumerateFiles(Path.Combine(GameDir, ".launcher_log"), "*.txt")
               .Select(file_path => new FileInfo(file_path))
               .OrderByDescending(file_info => file_info.LastWriteTime)
               .FirstOrDefault();

                if (gLogFile == null) {
                    // No logs
                    MessageBox.Show("No logs in .game_logs directory", "Warning");
                }
                if (launcherLogFile == null) {
                    MessageBox.Show("No logs in .launcher_log directory", "Warning");

                } else {
                    // Find last file
                    GameLogPath = gLogFile.FullName.ToString();
                    launcher_logPath = launcherLogFile.FullName.ToString();
                    gLogFile.CopyTo(Path.Combine(WorkDirectory, gLogFile.Name), true);
                    GameLogCheckbox.CheckState = CheckState.Checked;
                    launcherLogFile.CopyTo(Path.Combine(WorkDirectory, launcherLogFile.Name), true);
                    LauncherLogsCheckbox.CheckState = CheckState.Checked;

                }
            } catch (Exception ex) {
                MessageBox.Show($"Can't find logs.\n{ex.Message}");
            }
        }

        /// <summary>
        /// Packing archive 
        /// </summary>
        private void Archiving() {
            using (ZipFile zip = new ZipFile()) {
                zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestSpeed;
                ZipEntry ze = zip.AddDirectory(WorkDirectory);
                FolderBrowserDialog fdb = new FolderBrowserDialog();
                zip.Save($"{WorkDirectory}.zip");
                zipBox.CheckState = CheckState.Checked;
            }
            if (dxdiagchkbox.Checked && GameLogCheckbox.Checked && LauncherLogsCheckbox.Checked && zipBox.Checked) {
                donebox.CheckState = CheckState.Checked;
                FileInfo outputFile = new FileInfo(Path.Combine(WorkDirectory, WorkDirectory + ".zip"));
                MessageBox.Show($@"Done, archive saved as {WorkDirectory}.zip", "Done");
                ExploreFile($"{WorkDirectory}.zip");
            }
            
        }
        /// <summary>
        /// No comment xD
        /// </summary>
        private void GetGF() {
            GameDir = GetGamePath();
            try {
                versionLabel.Text = Application.ProductVersion.ToString();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// clear checkboxes
        /// </summary>
        private void ClearBoxes() {
            dxdiagchkbox.CheckState = CheckState.Unchecked;
            GameLogCheckbox.CheckState = CheckState.Unchecked;
            LauncherLogsCheckbox.CheckState = CheckState.Unchecked;
            zipBox.CheckState = CheckState.Unchecked;
            donebox.CheckState = CheckState.Unchecked;
            ScreenBox.CheckState = CheckState.Unchecked;
            ScreenBox.Visible = false;
        }

        //Start here

        private void button1_Click(object sender, EventArgs e) {
            button1.Enabled = false;
            ClearBoxes();
            WorkDirectory = Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), $@"WTRT {Guid.NewGuid()}")).ToString();
            DialogResult result = MessageBox.Show("Do you want add screens?", "WT screens", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                ScreenBox.Visible = true;
                using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                    openFileDialog.InitialDirectory = Path.Combine(GameDir, "Screenshots");
                    openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|jpeg files (*.jpeg)|*.jpeg|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 3;
                    openFileDialog.Multiselect = true;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK) {
                        foreach (String screens in openFileDialog.FileNames) {
                            try {
                                Screenpath = screens;
                                FileInfo file = new FileInfo(Screenpath);
                                file.CopyTo($@"{WorkDirectory}\\{file.Name}", true);
                                ScreenBox.CheckState = CheckState.Checked;
                            } catch (Exception ex) {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
            try {
                RunDxDiag();
                GetLogs();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
           


        /// <summary>
        /// Setup Game folder
        /// </summary>
        /// <returns></returns>
        private string GetGamePath() {
            try {
                RegistryKey currentKey = Registry.CurrentUser;
                RegistryKey warhunderRegeditPath = currentKey.OpenSubKey(@"Software\\Gaijin\\WarThunder");
                string GamePath = warhunderRegeditPath.GetValue("Path").ToString().Replace("launcher.exe", null);
                currentKey.Close();
                tstGamepathlabel.Text = GamePath;
                gamePathCheckBox.CheckState = CheckState.Checked;
                return GamePath;
            } catch (Exception ex) {
                MessageBox.Show("Can't find WarThunder folder" + ex.Message);
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.ShowNewFolderButton = false;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                    GameDir = folderBrowserDialog.SelectedPath;
                    tstGamepathlabel.Text = GameDir;
                    gamePathCheckBox.CheckState = CheckState.Checked;
                    GameLogCheckbox.CheckState = CheckState.Checked;
                    LauncherLogsCheckbox.CheckState = CheckState.Checked;
                }
                throw;
            }
        }

        /// <summary>
        /// Get dxdiag for any platform. Saving in Current running directory
        /// </summary>
        private async void RunDxDiag() {
            var psi = new ProcessStartInfo();
            if (IntPtr.Size == 4 && Environment.Is64BitOperatingSystem) {
                // 64-bit
                psi.FileName = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Windows),
                    "sysnative\\dxdiag.exe");
            } else {
                psi.FileName = Path.Combine(
                    Environment.SystemDirectory,
                    "dxdiag.exe");
            }
            string path = Path.GetTempFileName();
            try {
                psi.Arguments = "/t " + path;
                using (var prc = Process.Start(psi)) {
                    await Task.Run(() => prc.WaitForExit());
                    if (prc.ExitCode != 0) {
                        throw new Exception("DXDIAG failed with exit code " + prc.ExitCode.ToString());
                    }
                }
                //ToDo push data to msgbox
                string res = File.ReadAllText(path);
            } finally {
                try {
                    File.Copy(path, WorkDirectory + @"\dxdiag.log", true);
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                dxdiagchkbox.CheckState = CheckState.Checked;
                Archiving();
            }
        }
        public bool ExploreFile(string filePath) {
            if (!File.Exists(filePath)) {
                return false;
            }
            //Clean up file path so it can be navigated OK
            filePath = Path.GetFullPath(filePath);
            Process.Start("explorer.exe", string.Format("/select,\"{0}\"", filePath));
            button1.Enabled = true;
            return true;
            
        }

        /// <summary>
        /// telegram group link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e) {
            Process.Start("https://t.me/WarThunderBlog");
        }
    }


}

