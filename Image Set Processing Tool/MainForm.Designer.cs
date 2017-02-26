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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // InputFolderPathText
            // 
            this.InputFolderPathText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InputFolderPathText.Location = new System.Drawing.Point(109, 13);
            this.InputFolderPathText.Name = "InputFolderPathText";
            this.InputFolderPathText.Size = new System.Drawing.Size(222, 20);
            this.InputFolderPathText.TabIndex = 0;
            // 
            // OutputFolderPathText
            // 
            this.OutputFolderPathText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OutputFolderPathText.Location = new System.Drawing.Point(109, 39);
            this.OutputFolderPathText.Name = "OutputFolderPathText";
            this.OutputFolderPathText.Size = new System.Drawing.Size(222, 20);
            this.OutputFolderPathText.TabIndex = 1;
            // 
            // performActionBtn
            // 
            this.performActionBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.performActionBtn.Location = new System.Drawing.Point(176, 251);
            this.performActionBtn.Name = "performActionBtn";
            this.performActionBtn.Size = new System.Drawing.Size(112, 23);
            this.performActionBtn.TabIndex = 2;
            this.performActionBtn.Text = "Perform Action";
            this.performActionBtn.UseVisualStyleBackColor = true;
            this.performActionBtn.Click += new System.EventHandler(this.performActionBtn_Click);
            // 
            // openFolderBtn
            // 
            this.openFolderBtn.Location = new System.Drawing.Point(7, 12);
            this.openFolderBtn.Name = "openFolderBtn";
            this.openFolderBtn.Size = new System.Drawing.Size(96, 21);
            this.openFolderBtn.TabIndex = 3;
            this.openFolderBtn.Text = "Open Folder";
            this.openFolderBtn.UseVisualStyleBackColor = true;
            this.openFolderBtn.Click += new System.EventHandler(this.openFolderBtn_Click);
            // 
            // numberOfFilesLabel
            // 
            this.numberOfFilesLabel.AutoSize = true;
            this.numberOfFilesLabel.Location = new System.Drawing.Point(338, 19);
            this.numberOfFilesLabel.Name = "numberOfFilesLabel";
            this.numberOfFilesLabel.Size = new System.Drawing.Size(97, 13);
            this.numberOfFilesLabel.TabIndex = 4;
            this.numberOfFilesLabel.Text = "Number Of Files : 0";
            // 
            // closeFolderBtn
            // 
            this.closeFolderBtn.Location = new System.Drawing.Point(7, 38);
            this.closeFolderBtn.Name = "closeFolderBtn";
            this.closeFolderBtn.Size = new System.Drawing.Size(96, 21);
            this.closeFolderBtn.TabIndex = 5;
            this.closeFolderBtn.Text = "Output Folder";
            this.closeFolderBtn.UseVisualStyleBackColor = true;
            this.closeFolderBtn.Click += new System.EventHandler(this.closeFolderBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Output File Prefix : ";
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.prefixTextBox.Location = new System.Drawing.Point(109, 68);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(222, 20);
            this.prefixTextBox.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "brightness",
            "contrast ",
            "grey scale",
            "laplace"});
            this.listBox1.Location = new System.Drawing.Point(109, 107);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(222, 54);
            this.listBox1.TabIndex = 8;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 170);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(439, 75);
            this.richTextBox.TabIndex = 9;
            this.richTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 286);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.prefixTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeFolderBtn);
            this.Controls.Add(this.numberOfFilesLabel);
            this.Controls.Add(this.openFolderBtn);
            this.Controls.Add(this.performActionBtn);
            this.Controls.Add(this.OutputFolderPathText);
            this.Controls.Add(this.InputFolderPathText);
            this.Name = "MainForm";
            this.Text = "Main Form";
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}

