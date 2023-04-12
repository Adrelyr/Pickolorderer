namespace Pickolorderer
{
    partial class Pickolorderer
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
            this.fileChooserBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileList = new System.Windows.Forms.ListBox();
            this.sortColorsBtn = new System.Windows.Forms.Button();
            this.orderedFileList = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileChooserBtn
            // 
            this.fileChooserBtn.Location = new System.Drawing.Point(12, 12);
            this.fileChooserBtn.Name = "fileChooserBtn";
            this.fileChooserBtn.Size = new System.Drawing.Size(128, 44);
            this.fileChooserBtn.TabIndex = 0;
            this.fileChooserBtn.Text = "Choose files";
            this.fileChooserBtn.UseVisualStyleBackColor = true;
            this.fileChooserBtn.Click += new System.EventHandler(this.fileChooserBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.resultPanel);
            this.panel1.Controls.Add(this.orderedFileList);
            this.panel1.Location = new System.Drawing.Point(146, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 426);
            this.panel1.TabIndex = 1;
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.HorizontalScrollbar = true;
            this.fileList.Location = new System.Drawing.Point(12, 62);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(128, 290);
            this.fileList.TabIndex = 2;
            // 
            // sortColorsBtn
            // 
            this.sortColorsBtn.Location = new System.Drawing.Point(12, 394);
            this.sortColorsBtn.Name = "sortColorsBtn";
            this.sortColorsBtn.Size = new System.Drawing.Size(128, 23);
            this.sortColorsBtn.TabIndex = 3;
            this.sortColorsBtn.Text = "Sort";
            this.sortColorsBtn.UseVisualStyleBackColor = true;
            this.sortColorsBtn.Click += new System.EventHandler(this.sortColorsBtn_Click);
            // 
            // orderedFileList
            // 
            this.orderedFileList.FormattingEnabled = true;
            this.orderedFileList.HorizontalScrollbar = true;
            this.orderedFileList.Location = new System.Drawing.Point(16, 15);
            this.orderedFileList.Name = "orderedFileList";
            this.orderedFileList.Size = new System.Drawing.Size(146, 394);
            this.orderedFileList.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // resultPanel
            // 
            this.resultPanel.AutoScroll = true;
            this.resultPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultPanel.Location = new System.Drawing.Point(177, 15);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(449, 393);
            this.resultPanel.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 423);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(128, 15);
            this.progressBar1.TabIndex = 4;
            // 
            // Pickolorderer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.sortColorsBtn);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fileChooserBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Pickolorderer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fileChooserBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Panel resultPanel;
        public System.Windows.Forms.ListBox orderedFileList;
        public System.Windows.Forms.Button sortColorsBtn;
        public System.Windows.Forms.ProgressBar progressBar1;
    }
}

