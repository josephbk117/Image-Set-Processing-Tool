﻿using System;
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

namespace Image_Set_Processing_Tool
{
    public partial class MainForm : Form
    {
        FolderBrowserDialog fbd;
        Process process;
        List<string> filesInFolder;

        private string outputFolderPath = "";
        public MainForm()
        {
            InitializeComponent();
            fbd = new FolderBrowserDialog();
            process = new Process();
        }

        private void openFolderBtn_Click(object sender, EventArgs e)
        {
            //TODO : Only use image files into the list.
            

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                filesInFolder = Directory.GetFiles(fbd.SelectedPath).ToList<string>();
                InputFolderPathText.Text = fbd.SelectedPath;
                numberOfFilesLabel.Text = "Number Of Files " + filesInFolder.Count;
                for (int i = 0; i < filesInFolder.Count; i++)
                {
                    Console.WriteLine("Dir : " + i + " : " + filesInFolder[i]);
                }
            }
        }

        private void performActionBtn_Click(object sender, EventArgs e)
        {
            string actions = richTextBox.Text;
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
                prefixText = "\\"+prefixTextBox.Text+"_";
            else
                prefixText = "\\Output_";
            process.StartInfo.FileName = "C:\\Users\\josep_000\\AppData\\Local\\Programs\\Python\\Python35\\python.exe";
            
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;

            for (int i = 0; i < filesInFolder.Count; i++)
            {
                string input = "\""+filesInFolder[i]+"\"";
                process.StartInfo.Arguments = "ProcessImage.py " + input + outputFolderPath + prefixText + i + ".png\"" + actions;
                process.Start();
                //process.StandardInput.WriteLine("print(43543543534534534534534534534)");
                //process.StandardInput.Flush();
                //process.StandardInput.Close();
                process.WaitForExit();
                //Console.WriteLine(process.StandardOutput.ReadToEnd());
            }
        }

        private void closeFolderBtn_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                outputFolderPath = " \"" + fbd.SelectedPath.Trim();
                Console.WriteLine("Output path = " + outputFolderPath);
                OutputFolderPathText.Text = fbd.SelectedPath;
            }
        }
    }
}