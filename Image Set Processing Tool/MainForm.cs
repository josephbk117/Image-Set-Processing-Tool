﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Set_Processing_Tool
{
    public partial class MainForm : Form
    {
        FolderBrowserDialog fbd;
        Process process;
        List<string> filesInFolder;

        private string outputFolderPath = "";
        private string pythonLocation = "";
        public MainForm()
        {
            InitializeComponent();
            if (File.Exists("storedvalues.xaz"))
            {
                FileStream fs = new FileStream("storedvalues.xaz", FileMode.Open);
                BinaryReader rd = new BinaryReader(fs);

                pythonLocation = rd.ReadString();
                pythonLocationTextBox.Text = pythonLocation;

                rd.Close();
                fs.Close();
            }
            fbd = new FolderBrowserDialog();
            process = new Process();
        }

        private void OpenFolderBtn_Click(object sender, EventArgs e)
        {
            //TODO : Only use image files into the list.
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                filesInFolder = Directory.GetFiles(fbd.SelectedPath).ToList<string>();
                InputFolderPathText.Text = fbd.SelectedPath;
                numberOfFilesLabel.Text = "Number Of Files " + filesInFolder.Count;                
            }
        }

        private void PerformActionBtn_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                if (filesInFolder == null)
                {
                    MessageBox.Show("Error : No Files To Process");
                    return;
                }
            }

            backgroundWorker.RunWorkerAsync(richTextBox.Text);
        }

        private void CloseFolderBtn_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                outputFolderPath = " \"" + fbd.SelectedPath.Trim();
                OutputFolderPathText.Text = fbd.SelectedPath;
            }
        }

        private void PythonLocationBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!ofd.SafeFileName.EndsWith("python.exe"))
                {
                    MessageBox.Show("Make sure it's the python.exe file");
                    return;
                }
                pythonLocation = ofd.FileName;
                pythonLocationTextBox.Text = pythonLocation;
                FileStream fs = new FileStream("storedvalues.xaz", FileMode.Create);
                BinaryWriter wr = new BinaryWriter(fs);

                wr.Write(pythonLocation);

                wr.Close();
                fs.Close();
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string actions = (string)e.Argument;
            List<string> cmds = actions.Split(' ').ToList<string>();
            actions = "";
            for (int i = 0; i < cmds.Count; i++)
            {
                cmds[i] = " \"" + cmds[i] + "\" ";
                Console.WriteLine("Vals : " + cmds[i]);
                actions += cmds[i];
            }

            string prefixText;
            if (prefixTextBox.Text != string.Empty)
                prefixText = "\\" + prefixTextBox.Text + "_";
            else
                prefixText = "\\Output_";
            if (pythonLocation == string.Empty)
                process.StartInfo.FileName = "C:\\Users\\josep_000\\AppData\\Local\\Programs\\Python\\Python35\\python.exe";
            else
                process.StartInfo.FileName = pythonLocation;

            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;

            unsafe
            {
                Parallel.For(0, filesInFolder.Count, i =>
                {
                    string input = "\"" + filesInFolder[i] + "\"";
                    process.StartInfo.Arguments = "ProcessImage.py " + input + outputFolderPath + prefixText + i + ".png\"" + actions;
                    process.Start();
                    process.WaitForExit();
                    backgroundWorker.ReportProgress((int)(((float)i / (float)filesInFolder.Count) * 100.0f));
                });
            }
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int progressAmount = e.ProgressPercentage;
            if (progressAmount >= 100) progressAmount = 100;
            progressBar.Value = progressAmount;
            progressBar.Update();
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Value = 0;
            progressBar.Update();
        }
    }
}
