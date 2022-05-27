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
                quickTextbox.Text = dirsList[2];
                saveTextbox.Text = dirsList[3];
                quickLimitTextbox.Text = dirsList[4];
                intervalCombobox.Text = dirsList[5];
            }
        }

        private void saveDirs()
        {
            //Obsolete
            //List<string> dirsList = new List<string> {
            //    srcTextbox.Text,
            //    bakTextbox.Text,
            //    quickTextbox.Text,
            //    saveTextbox.Text
            //};
            List<string> dirsList = new List<string>();

            if (srcTextbox.Text == "" || bakTextbox.Text == "" || quickTextbox.Text == "" || saveTextbox.Text == "")
            {
                MessageBox.Show("Give proper directories");
            }
            else
            {
                if (quicksaveToggle.Checked == true)
                {
                    if (quickLimitTextbox.Value == 0)
                    {
                        MessageBox.Show("Enter proper limit for quicksave or turn off. Default value is set to 5 (min).");
                        quickLimitTextbox.Value = 5;
                    }
                }
                dirsList.Add(srcTextbox.Text);
                dirsList.Add(bakTextbox.Text);
                dirsList.Add(quickTextbox.Text);
                dirsList.Add(saveTextbox.Text);
                dirsList.Add(quickLimitTextbox.Text);
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
            String quicksaveFolder = $"{quickTextbox.Text}";
            int quicksaveLimit = (int)quickLimitTextbox.Value;
            if (Directory.Exists(quicksaveFolder))
            {
                int quicksaveCount = Directory.GetFiles(quicksaveFolder, "*", SearchOption.TopDirectoryOnly).Length;
                if (quicksaveCount > quicksaveLimit)
                {
                    //Delete oldest, skip newer inside the quicksavelimit value
                    foreach (var file in new DirectoryInfo(quicksaveFolder).GetFiles().OrderByDescending(x => x.LastWriteTime).Skip(4))
                    {
                        file.Delete();
                    }

                }
            }
        }

        private void quickSave(Boolean status) {
            float setTime = Int64.Parse(intervalCombobox.Text) * 60000;
            Console.WriteLine(setTime);

            if (!File.Exists($"{srcTextbox.Text}/{saveTextbox.Text}"))
            {
                MessageBox.Show("Source file/folder does not exist!");
            }
            else {
                if (status == true)
                {
                    aTimer = new System.Timers.Timer(setTime);
                    aTimer.Elapsed += OnTimedEvent;
                    aTimer.AutoReset = true;
                    aTimer.Enabled = true;
                    limitSave();
                }
                else {
                    aTimer.Stop();
                    aTimer.Dispose();
                }
            }
        }
        //Part of quicksave function, this is called
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
            File.Copy($"{srcTextbox.Text}/{saveTextbox.Text}", $"{quickTextbox.Text}/qck-{DateTime.Now.ToString("yyyyMMddHHmmss")}-{saveTextbox.Text}");
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
            if (backupRadio.Checked == true) {
                loadBackupDir = bakTextbox.Text;
            }
            else if (quickRadio.Checked == true)
            {
                loadBackupDir = quickTextbox.Text;
            }
            List<string> files = new List<string>();
            foreach (var file in new DirectoryInfo(loadBackupDir).GetFiles().OrderByDescending(x => x.LastWriteTime)) {
                files.Add(file.ToString());
            }
            File.Copy($"{loadBackupDir}/{files[0]}", $"{srcTextbox.Text}/{files[0]}", true);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveDirs();
        }
        private void quicksaveButton_Click(object sender, EventArgs e)
        {
            if (File.Exists($"{srcTextbox.Text}/{saveTextbox.Text}"))
            {
                File.Copy($"{srcTextbox.Text}/{saveTextbox.Text}", $"{quickTextbox.Text}/qck-{DateTime.Now.ToString("yyyyMMddHHmmss")}-{saveTextbox.Text}");
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

        private void quickFolderDialogBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            quickTextbox.Text = folderBrowserDialog1.SelectedPath;
        }

        //Help and about messageboxes
        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "SOURCE - Savefile location, usually in AppData/Roaming/GameName \n" +
                "BACKUP - Where you want to store the backup\n" +
                "QUICKSAVE - Where quicksave will be stashed\n" +
                "FILENAME - Name of savefile, for Elden Ring its ER0000.sl2. You get it.\n\n" +
                "This application is basically a file copier.",
                "Help");
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Soulsborne Save Manager by iaiaian1\n" +
                "Source: \n\n",
                "About\n");
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            backupSave();
        }

        private void quicksaveToggle_CheckedChanged(object sender, EventArgs e)
        {
            quickSave(quicksaveToggle.Checked);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            loadBackup();
        }
    }
}
