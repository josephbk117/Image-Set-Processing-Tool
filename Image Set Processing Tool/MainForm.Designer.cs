namespace Image_Set_Processing_Tool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputFolderPathText = new System.Windows.Forms.TextBox();
            this.OutputFolderPathText = new System.Windows.Forms.TextBox();
            this.performActionBtn = new System.Windows.Forms.Button();
            this.openFolderBtn = new System.Windows.Forms.Button();
            this.numberOfFilesLabel = new System.Windows.Forms.Label();
            this.closeFolderBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prefixTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.pythonLocationBtn = new System.Windows.Forms.Button();
            this.pythonLocationTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // InputFolderPathText
            // 
            this.InputFolderPathText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputFolderPathText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.InputFolderPathText.Location = new System.Drawing.Point(159, 56);
            this.InputFolderPathText.Name = "InputFolderPathText";
            this.InputFolderPathText.Size = new System.Drawing.Size(600, 23);
            this.InputFolderPathText.TabIndex = 0;
            // 
            // OutputFolderPathText
            // 
            this.OutputFolderPathText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputFolderPathText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.OutputFolderPathText.Location = new System.Drawing.Point(159, 90);
            this.OutputFolderPathText.Name = "OutputFolderPathText";
            this.OutputFolderPathText.Size = new System.Drawing.Size(600, 23);
            this.OutputFolderPathText.TabIndex = 1;
            // 
            // performActionBtn
            // 
            this.performActionBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.performActionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.performActionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.performActionBtn.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performActionBtn.ForeColor = System.Drawing.Color.White;
            this.performActionBtn.Location = new System.Drawing.Point(308, 302);
            this.performActionBtn.Name = "performActionBtn";
            this.performActionBtn.Size = new System.Drawing.Size(146, 32);
            this.performActionBtn.TabIndex = 2;
            this.performActionBtn.Text = "Perform Action";
            this.performActionBtn.UseVisualStyleBackColor = false;
            this.performActionBtn.Click += new System.EventHandler(this.performActionBtn_Click);
            // 
            // openFolderBtn
            // 
            this.openFolderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.openFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openFolderBtn.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFolderBtn.ForeColor = System.Drawing.Color.White;
            this.openFolderBtn.Location = new System.Drawing.Point(7, 55);
            this.openFolderBtn.Name = "openFolderBtn";
            this.openFolderBtn.Size = new System.Drawing.Size(146, 24);
            this.openFolderBtn.TabIndex = 3;
            this.openFolderBtn.Text = "Open Folder";
            this.openFolderBtn.UseVisualStyleBackColor = false;
            this.openFolderBtn.Click += new System.EventHandler(this.openFolderBtn_Click);
            // 
            // numberOfFilesLabel
            // 
            this.numberOfFilesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numberOfFilesLabel.AutoSize = true;
            this.numberOfFilesLabel.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfFilesLabel.ForeColor = System.Drawing.Color.White;
            this.numberOfFilesLabel.Location = new System.Drawing.Point(617, 14);
            this.numberOfFilesLabel.Name = "numberOfFilesLabel";
            this.numberOfFilesLabel.Size = new System.Drawing.Size(142, 15);
            this.numberOfFilesLabel.TabIndex = 4;
            this.numberOfFilesLabel.Text = "Number Of Files : 0";
            // 
            // closeFolderBtn
            // 
            this.closeFolderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.closeFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeFolderBtn.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeFolderBtn.ForeColor = System.Drawing.Color.White;
            this.closeFolderBtn.Location = new System.Drawing.Point(7, 89);
            this.closeFolderBtn.Name = "closeFolderBtn";
            this.closeFolderBtn.Size = new System.Drawing.Size(146, 24);
            this.closeFolderBtn.TabIndex = 5;
            this.closeFolderBtn.Text = "Output Folder";
            this.closeFolderBtn.UseVisualStyleBackColor = false;
            this.closeFolderBtn.Click += new System.EventHandler(this.closeFolderBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Output File Prefix : ";
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prefixTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.prefixTextBox.Location = new System.Drawing.Point(159, 143);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(600, 23);
            this.prefixTextBox.TabIndex = 7;
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox.Font = new System.Drawing.Font("Orbitron", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(12, 172);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(747, 124);
            this.richTextBox.TabIndex = 9;
            this.richTextBox.Text = "";
            // 
            // pythonLocationBtn
            // 
            this.pythonLocationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pythonLocationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pythonLocationBtn.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pythonLocationBtn.ForeColor = System.Drawing.Color.White;
            this.pythonLocationBtn.Location = new System.Drawing.Point(7, 12);
            this.pythonLocationBtn.Name = "pythonLocationBtn";
            this.pythonLocationBtn.Size = new System.Drawing.Size(146, 24);
            this.pythonLocationBtn.TabIndex = 10;
            this.pythonLocationBtn.Text = "Python Location";
            this.pythonLocationBtn.UseVisualStyleBackColor = false;
            this.pythonLocationBtn.Click += new System.EventHandler(this.pythonLocationBtn_Click);
            // 
            // pythonLocationTextBox
            // 
            this.pythonLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pythonLocationTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pythonLocationTextBox.Location = new System.Drawing.Point(159, 12);
            this.pythonLocationTextBox.Name = "pythonLocationTextBox";
            this.pythonLocationTextBox.Size = new System.Drawing.Size(444, 23);
            this.pythonLocationTextBox.TabIndex = 11;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(15, 340);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(744, 14);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(771, 357);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pythonLocationTextBox);
            this.Controls.Add(this.pythonLocationBtn);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.prefixTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeFolderBtn);
            this.Controls.Add(this.numberOfFilesLabel);
            this.Controls.Add(this.openFolderBtn);
            this.Controls.Add(this.performActionBtn);
            this.Controls.Add(this.OutputFolderPathText);
            this.Controls.Add(this.InputFolderPathText);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "MainForm";
            this.Text = "Image Set Maniplator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputFolderPathText;
        private System.Windows.Forms.TextBox OutputFolderPathText;
        private System.Windows.Forms.Button performActionBtn;
        private System.Windows.Forms.Button openFolderBtn;
        private System.Windows.Forms.Label numberOfFilesLabel;
        private System.Windows.Forms.Button closeFolderBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prefixTextBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button pythonLocationBtn;
        private System.Windows.Forms.TextBox pythonLocationTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

