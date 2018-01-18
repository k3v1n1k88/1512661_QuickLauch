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
using System.Diagnostics;
using System.Threading;
using DevExpress.XtraCharts;
//using System.Windows.Forms.DataVisualization.Charting;

namespace QuickLauch
{
    public partial class QuickLaunch : Form
    {
        #region Cac bien dung trong chuong trinh
        Hook myhook = new Hook();
        Dictionary<string, string> dictionaryFileDirectories;
        Dictionary<string, int> dictionaryFileFrequency;
        AutoCompleteStringCollection auto;
        #endregion

        //Khoi tao
        public QuickLaunch()
        {
            InitializeComponent();
            var comparer = StringComparer.OrdinalIgnoreCase;
            dictionaryFileDirectories = new Dictionary<string, string>();
            dictionaryFileFrequency = new Dictionary<string, int>();
            auto = new AutoCompleteStringCollection();

            #region Load database and Using history
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("data.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string key = sr.ReadLine();
                        string value = sr.ReadLine();
                        dictionaryFileDirectories.Add(key.ToLower(), value);
                        auto.Add(key.ToLower());
                    }
                    textBox1.AutoCompleteCustomSource = auto;
                }
            }
            catch (Exception e)
            {
                //Do nothing
            }
            LoadFrequencyFile();
            #endregion

            //Khoi dong hook
            Hook.show = new Hook.Show(ShowProgram);
            progressPanel1.Visible = false;
        }

        //Ham load file tan suat su dung
        private void LoadFrequencyFile()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("frequencydata.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string key = sr.ReadLine();
                        int value = Convert.ToInt32(sr.ReadLine());
                        dictionaryFileFrequency.Add(key, value);
                        auto.Add(key);
                    }
                }
            }
            catch (Exception e)
            {
                //Do nothing
            }
        }
        
        //Ham save file tan suat su dung
        private void SaveFrequencyFile()
        {
            FileStream fs = new FileStream("frequencydata.txt", FileMode.Create);//Tạo file mới tên là data            
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);//fs là 1 FileStream 
            foreach (var value in dictionaryFileFrequency)
            {
                sWriter.WriteLine(value.Key);
                sWriter.WriteLine(value.Value);
            }
            // Ghi và đóng file
            sWriter.Flush();
            fs.Close();
        }

        //Loading cua man hinh chinh
        private void Form1_Load(object sender, EventArgs e)
        {
            Screen scr = Screen.PrimaryScreen; //đi lấy màn hình chính
            this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            this.Top = (scr.WorkingArea.Height - this.Height) / 2;
        }

        
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Hien thi context menu khi click phai vao itemtray
        private void trayQuickLaunch_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuTrayQuickLaunch.Show();
            }
        }

        //Hien thi man hinh chuong trinh chinh khi doble click vao itemtray
        private void trayQuickLaunch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible == false)
            {
                this.Visible = true;
            }
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        //Ham scan database
        private void ScanFile(string sourceFile)
        {
            trayQuickLaunch.ShowBalloonTip(5000, "Scanning", "Please wait for moment...", ToolTipIcon.Warning);
            progressPanel1.Visible = true;
            progressPanel1.Update();
            //foreach (string file in Directory.GetFiles("C:\\", "*.exe",SearchOption.AllDirectories))
            //{
            //    FileInfo info = new FileInfo(file);
            //    if (dictionaryFileDirectories.ContainsKey(info.Name) == false)
            //    {
            //        dictionaryFileDirectories.Add(info.Name, file);
            //        auto1.Add(info.Name);
            //    }

            //}
            Thread.Sleep(1000);
            Queue<string> folders = new Queue<string>();
            List<string> files = new List<string>();
            folders.Enqueue(sourceFile);



            while (folders.Count != 0)
            {
                string currentFolder = folders.Dequeue();
                try
                {
                    foreach (string file in System.IO.Directory.GetFiles(currentFolder, "*.exe", System.IO.SearchOption.TopDirectoryOnly))
                    {
                        FileInfo info = new FileInfo(file);
                        if (dictionaryFileDirectories.ContainsKey(info.Name) == false)
                        {
                            dictionaryFileDirectories.Add(info.Name.ToLower(), file);
                            auto.Add(info.Name.ToLower());

                        }
                    }
                    string[] foldersInCurrent = System.IO.Directory.GetDirectories(currentFolder, "*.*", System.IO.SearchOption.TopDirectoryOnly);
                    foreach (string _current in foldersInCurrent)
                    {
                        folders.Enqueue(_current);
                    }
                }
                catch
                {
                    // Do Nothing
                }
            }

            textBox1.AutoCompleteCustomSource = auto;
            progressPanel1.Visible = false;
            MessageBox.Show("Scan file successfull", "Notice", MessageBoxButtons.OK);
        }

        //Ham hien thi 
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShowProgram();
            //this.TopMost = true;
        }

        // Ham exit tu itemtray
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("data.txt", FileMode.Create);//Tạo file mới tên là data            
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);//fs là 1 FileStream 
            foreach (var value in dictionaryFileDirectories)
            {
                sWriter.WriteLine(value.Key);
                sWriter.WriteLine(value.Value);
            }
            // Ghi và đóng file
            sWriter.Flush();
            fs.Close();
            SaveFrequencyFile();
            Application.Exit();
        }

        //Ham kiem tra enter hay delete tu textbox cua man hinh chinh        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string nameProgram = textBox1.Text;
            if (e.KeyCode == Keys.Enter)
            {
                RunProgram(nameProgram);
            }
            if (e.KeyCode == Keys.Delete)
            {
                if (auto.Contains(nameProgram))
                {
                    if (MessageBox.Show("Do you really want to remove program \"" + nameProgram + "\" from database?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dictionaryFileDirectories.Remove(nameProgram);
                        auto.Remove(nameProgram);
                        MessageBox.Show("Removed program \"" + nameProgram + "\"from database!", "Successfull remove", MessageBoxButtons.OK);
                    }
                }
            }
        }


        
        private void QuickLaunch_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Khi nhan vao X button 
        private void QuickLaunch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                trayQuickLaunch.ShowBalloonTip(1000);
            }
        }

        // Run program
        public void RunProgram(string programName)
        {
            try
            {
                if (dictionaryFileDirectories.Count() == 0)
                {
                    MessageBox.Show("Database is empty! \nMaybe you need to scan database before.", "Error");
                }
                else
                {
                    string directoryProgram = dictionaryFileDirectories[programName];
                    Process.Start(directoryProgram);
                    if (dictionaryFileFrequency.ContainsKey(programName) == false)
                    {
                        dictionaryFileFrequency.Add(programName, 1);
                    }
                    else
                    {
                        dictionaryFileFrequency[programName] += 1;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("We can not start program \"" + programName + "\" because program is not in your database.\nMaybe you need scan again", "Error");
                textBox1.Focus();
                textBox1.SelectAll();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string nameProgram = textBox1.Text;
            RunProgram(nameProgram);
        }

        //View static
        private void viewStaticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dictionaryFileFrequency.Count == 0)
            {
                MessageBox.Show("Nothing to view because you never run anything\nPlease try again.", "History is empty", MessageBoxButtons.OK);
            }
            else
            {
                Statics chartViewStatic = new Statics();
                chartViewStatic.dictFrequency = new Dictionary<string, int>(dictionaryFileFrequency);
                if (chartViewStatic.dictFrequency.Count != 0)
                {
                    chartViewStatic.LoadStatic();
                }
                chartViewStatic.Show();
                chartViewStatic.ShowInTaskbar = false;
            }
        }

        //Ham show chuong trinh
        public void ShowProgram()
        {
            if (this.Visible == false)
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                this.Visible = true;
            }
        }

        //Ham thuc thi khi nhan scan database
        private void scanAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScanFile("C:\\");
        }

        //Ham thuc thi khi browser folder
        private void chooseFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ScanFile(folderBrowserDialog.SelectedPath);
            }
        }

        //Ham reset database
        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete all database?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dictionaryFileDirectories.Clear();
                auto.Clear();
                MessageBox.Show("Delete database successfull!", "Notice", MessageBoxButtons.OK);
            }
        }

        //Ham reset history
        private void resetUsingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to reset your history?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dictionaryFileFrequency.Clear();
                MessageBox.Show("Reset history successfull", "Notice", MessageBoxButtons.OK);
            }

        }

        //About me
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright by k3v1n1k88 \nID: 1512661", "Final Term");
        }
    }
}