using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace Soulsborne_Save_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public delegate void Callback();
        public string path = Directory.GetCurrentDirectory();
        private static System.Timers.Timer aTimer;


        private void loadDirs()
        {
            List<string> dirsList = new List<string>();

            if (File.Exists($"{path}/dirs/dirs.txt"))
            {
                foreach (string dir in File.ReadAllLines($"{path}/dirs/dirs.txt"))
                {
                    dirsList.Add(dir);
                }
                srcTextbox.Text = dirsList[0];
                bakTextbox.Text = dirsList[1];
                autosaveTextbox.Text = dirsList[2];
                saveTextbox.Text = dirsList[3];
                autosaveLimitTextbox.Text = dirsList[4];
                intervalCombobox.Text = dirsList[5];
            }
        }

        private void saveDirs()
        {
            //Obsolete
            //List<string> dirsList = new List<string> {
            //    srcTextbox.Text,
            //    bakTextbox.Text,
            //    autosaveTextbox.Text,
            //    saveTextbox.Text
            //};
            List<string> dirsList = new List<string>();

            if (srcTextbox.Text == "" || bakTextbox.Text == "" || autosaveTextbox.Text == "" || saveTextbox.Text == "")
            {
                MessageBox.Show("Give proper directories");
            }
            else
            {
                if (autosaveToggle.Checked == true)
                {
                    if (autosaveLimitTextbox.Value == 0)
                    {
                        MessageBox.Show("Enter proper limit for autosave or turn off. Default value is set to 5 (min).");
                        autosaveLimitTextbox.Value = 5;
                    }
                }
                dirsList.Add(srcTextbox.Text);
                dirsList.Add(bakTextbox.Text);
                dirsList.Add(autosaveTextbox.Text);
                dirsList.Add(saveTextbox.Text);
                dirsList.Add(autosaveLimitTextbox.Text);
                dirsList.Add(intervalCombobox.Text);

                if (!Directory.Exists($"{path}/dir"))
                {
                    Directory.CreateDirectory("dirs");
                }
                File.WriteAllText($"{path}/dirs/dirs.txt", String.Join("\n", dirsList));
            }
        }

        private void limitSave()
        {
            String autosaveFolder = $"{autosaveTextbox.Text}";
            //String autosaveExtension = saveTextbox.Text.Split('.')[1];
            int autosaveLimit = (int)autosaveLimitTextbox.Value;
            if (Directory.Exists(autosaveFolder))
            {
                int autosaveCount = Directory.GetFiles(autosaveFolder, "*.sl2", SearchOption.TopDirectoryOnly).Length;
                if (autosaveCount > autosaveLimit)
                {
                    //Delete oldest, skip newer inside the autosavelimit value
                    foreach (var file in new DirectoryInfo(autosaveFolder).GetFiles("*.sl2").OrderByDescending(x => x.LastWriteTime).Skip(autosaveLimit))
                    {
                        file.Delete();
                    }

                }
            }
        }

        private void autoSaveCopy() {
            File.Copy($"{srcTextbox.Text}/{saveTextbox.Text}", $"{autosaveTextbox.Text}/qck-{DateTime.Now.ToString("yyyyMMddHHmmss")}-{saveTextbox.Text}");
        }

        private void autoSaveTimer(Boolean status) {
            float setTime = Int64.Parse(intervalCombobox.Text) * 60000;
            //Console.WriteLine(setTime);

            if (!File.Exists($"{srcTextbox.Text}/{saveTextbox.Text}"))
            {
                MessageBox.Show("Source file/folder does not exist!");
                autosaveToggle.Checked = false;
            }
            else {
                if (status == true)
                {
                    aTimer = new System.Timers.Timer(setTime);
                    aTimer.Elapsed += OnTimedEvent;
                    aTimer.AutoReset = true;
                    aTimer.Enabled = true;
                }
                else {
                    aTimer.Stop();
                    aTimer.Dispose();
                }
            }
        }
        //Part of autosave function, this is called
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            //Console line is for testing, comment it out.
            //Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
            autoSaveCopy();
            limitSave();            
        }

        private void backupSave() {
            if (!File.Exists($"{srcTextbox.Text}/{saveTextbox.Text}"))
            {
                MessageBox.Show("Source file/folder does not exist!");
            }
            else {
                File.Copy($"{srcTextbox.Text}/{saveTextbox.Text}", $"{bakTextbox.Text}/bck-{DateTime.Now.ToString("yyyyMMddHHmmss")}-{saveTextbox.Text}");
            }
        }

        private void loadBackup() {
            String loadBackupDir = "";
            if (backupRadio.Checked == true) 
            {
                loadBackupDir = bakTextbox.Text;
            }
            else if (autosaveRadio.Checked == true)
            {
                loadBackupDir = autosaveTextbox.Text;                
            }

            if (loadBackupDir == "")
            {
                MessageBox.Show("Give proper backup/autosave directories");
            }
            else {
                List<string> files = new List<string>();
                foreach (var file in new DirectoryInfo(loadBackupDir).GetFiles().OrderByDescending(x => x.LastWriteTime))
                {
                    files.Add(file.ToString());
                }
                File.Copy($"{loadBackupDir}/{files[0]}", $"{srcTextbox.Text}/{saveTextbox.Text}", true);
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveDirs();
        }

        private void autosaveButton_Click(object sender, EventArgs e)
        {
            if (File.Exists($"{srcTextbox.Text}/{saveTextbox.Text}"))
            {
                autoSaveCopy();
                limitSave();
            }
            else {
                MessageBox.Show("File does not exist!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDirs();
        }

        private void srcFolderDialogBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            srcTextbox.Text = folderBrowserDialog1.SelectedPath;
        }

        private void bakFolderDialogBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            bakTextbox.Text = folderBrowserDialog1.SelectedPath;
        }

        private void autosaveFolderDialogBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            autosaveTextbox.Text = folderBrowserDialog1.SelectedPath;
        }

        //Help and about messageboxes
        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "SOURCE - Savefile location, usually in AppData/Roaming/GameName \n" +
                "BACKUP - Where you want to store the backup\n" +
                "AUTOSAVE - Where autosave will be stashed\n" +
                "FILENAME - Name of savefile, for Elden Ring its ER0000.sl2. You get it.\n\n" +
                "This application is basically a file copier.",
                "Help");
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Soulsborne Save Manager by iaiaian1\n" +
                "Source: https://github.com/iaiaian1/Soulsborne-Save-Manager\n\n",
                "About\n");
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            backupSave();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            loadBackup();
        }

        private void autosaveToggle_Click(object sender, EventArgs e)
        {
            autoSaveTimer(autosaveToggle.Checked);
        }
    }
}
