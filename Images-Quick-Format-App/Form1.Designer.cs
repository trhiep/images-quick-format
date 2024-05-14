using System.Windows.Forms;

namespace Images_Quick_Format_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mnsMainApp = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvImgList = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.grbOutput = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.cbxExportFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prbSuccessBar = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.mnsMainApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImgList)).BeginInit();
            this.grbInput.SuspendLayout();
            this.grbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMainApp
            // 
            this.mnsMainApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnsMainApp.Location = new System.Drawing.Point(0, 0);
            this.mnsMainApp.Name = "mnsMainApp";
            this.mnsMainApp.Size = new System.Drawing.Size(832, 24);
            this.mnsMainApp.TabIndex = 0;
            this.mnsMainApp.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTaskToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newTaskToolStripMenuItem
            // 
            this.newTaskToolStripMenuItem.Name = "newTaskToolStripMenuItem";
            this.newTaskToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newTaskToolStripMenuItem.Text = "New Task";
            this.newTaskToolStripMenuItem.Click += new System.EventHandler(this.newTaskToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // dgvImgList
            // 
            this.dgvImgList.AllowUserToOrderColumns = true;
            this.dgvImgList.AllowUserToResizeColumns = false;
            this.dgvImgList.AllowUserToResizeRows = false;
            this.dgvImgList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvImgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colFileName,
            this.colFilePath,
            this.colFileType,
            this.colFileSize});
            this.dgvImgList.Location = new System.Drawing.Point(12, 156);
            this.dgvImgList.Name = "dgvImgList";
            this.dgvImgList.RowHeadersVisible = false;
            this.dgvImgList.Size = new System.Drawing.Size(808, 297);
            this.dgvImgList.TabIndex = 1;
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "_no";
            this.colNo.HeaderText = "No.";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNo.Width = 50;
            // 
            // colFileName
            // 
            this.colFileName.DataPropertyName = "_imageName";
            this.colFileName.HeaderText = "Name";
            this.colFileName.Name = "colFileName";
            this.colFileName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFileName.Width = 250;
            // 
            // colFilePath
            // 
            this.colFilePath.DataPropertyName = "_imagePath";
            this.colFilePath.HeaderText = "Path";
            this.colFilePath.Name = "colFilePath";
            this.colFilePath.ReadOnly = true;
            this.colFilePath.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFilePath.Width = 355;
            // 
            // colFileType
            // 
            this.colFileType.DataPropertyName = "_imageType";
            this.colFileType.HeaderText = "Type";
            this.colFileType.Name = "colFileType";
            this.colFileType.ReadOnly = true;
            this.colFileType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFileType.Width = 75;
            // 
            // colFileSize
            // 
            this.colFileSize.DataPropertyName = "_imageSize";
            this.colFileSize.HeaderText = "Size";
            this.colFileSize.Name = "colFileSize";
            this.colFileSize.ReadOnly = true;
            this.colFileSize.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFileSize.Width = 75;
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.btnImport);
            this.grbInput.Location = new System.Drawing.Point(12, 32);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(200, 118);
            this.grbInput.TabIndex = 2;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Import Images";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(6, 16);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(188, 96);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.btnExport);
            this.grbOutput.Controls.Add(this.cbxExportFormat);
            this.grbOutput.Controls.Add(this.label1);
            this.grbOutput.Location = new System.Drawing.Point(218, 32);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Size = new System.Drawing.Size(602, 118);
            this.grbOutput.TabIndex = 3;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Export Settings";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(408, 13);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(188, 96);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cbxExportFormat
            // 
            this.cbxExportFormat.FormattingEnabled = true;
            this.cbxExportFormat.Items.AddRange(new object[] {
            "PNG",
            "JPG"});
            this.cbxExportFormat.Location = new System.Drawing.Point(126, 16);
            this.cbxExportFormat.Name = "cbxExportFormat";
            this.cbxExportFormat.Size = new System.Drawing.Size(141, 21);
            this.cbxExportFormat.TabIndex = 1;
            this.cbxExportFormat.SelectedIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Export Format";
            // 
            // prbSuccessBar
            // 
            this.prbSuccessBar.Location = new System.Drawing.Point(12, 466);
            this.prbSuccessBar.Name = "prbSuccessBar";
            this.prbSuccessBar.Size = new System.Drawing.Size(731, 23);
            this.prbSuccessBar.TabIndex = 5;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(749, 471);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(71, 13);
            this.lblProgress.TabIndex = 6;
            this.lblProgress.Text = "0 / 0 Done";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 501);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.prbSuccessBar);
            this.Controls.Add(this.grbOutput);
            this.Controls.Add(this.grbInput);
            this.Controls.Add(this.dgvImgList);
            this.Controls.Add(this.mnsMainApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsMainApp;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Quick Format";
            this.mnsMainApp.ResumeLayout(false);
            this.mnsMainApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImgList)).EndInit();
            this.grbInput.ResumeLayout(false);
            this.grbOutput.ResumeLayout(false);
            this.grbOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMainApp;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvImgList;
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox grbOutput;
        private System.Windows.Forms.ComboBox cbxExportFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ProgressBar prbSuccessBar;
        private System.Windows.Forms.Label lblProgress;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colFileName;
        private DataGridViewTextBoxColumn colFilePath;
        private DataGridViewTextBoxColumn colFileType;
        private DataGridViewTextBoxColumn colFileSize;
    }
}

