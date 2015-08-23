namespace zynchronyze.ServerInterface
{
    partial class frmPublish
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lvPublishedFolders = new System.Windows.Forms.ListView();
            this.btnSearchFolder = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnPublishFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // lvPublishedFolders
            // 
            this.lvPublishedFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvPublishedFolders.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvPublishedFolders.Location = new System.Drawing.Point(0, 0);
            this.lvPublishedFolders.Name = "lvPublishedFolders";
            this.lvPublishedFolders.Size = new System.Drawing.Size(652, 311);
            this.lvPublishedFolders.TabIndex = 0;
            this.lvPublishedFolders.UseCompatibleStateImageBehavior = false;
            this.lvPublishedFolders.View = System.Windows.Forms.View.Details;
            // 
            // btnSearchFolder
            // 
            this.btnSearchFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFolder.Location = new System.Drawing.Point(624, 317);
            this.btnSearchFolder.Name = "btnSearchFolder";
            this.btnSearchFolder.Size = new System.Drawing.Size(28, 23);
            this.btnSearchFolder.TabIndex = 1;
            this.btnSearchFolder.Text = "...";
            this.btnSearchFolder.UseVisualStyleBackColor = true;
            this.btnSearchFolder.Click += new System.EventHandler(this.btnSearchFolder_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFolderPath.Location = new System.Drawing.Point(0, 319);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(618, 20);
            this.txtFolderPath.TabIndex = 2;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Path";
            // 
            // btnPublishFolder
            // 
            this.btnPublishFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublishFolder.Location = new System.Drawing.Point(577, 345);
            this.btnPublishFolder.Name = "btnPublishFolder";
            this.btnPublishFolder.Size = new System.Drawing.Size(75, 23);
            this.btnPublishFolder.TabIndex = 3;
            this.btnPublishFolder.Text = "Publish";
            this.btnPublishFolder.UseVisualStyleBackColor = true;
            this.btnPublishFolder.Click += new System.EventHandler(this.btnPublishFolder_Click);
            // 
            // frmPublish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 368);
            this.Controls.Add(this.btnPublishFolder);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.btnSearchFolder);
            this.Controls.Add(this.lvPublishedFolders);
            this.Name = "frmPublish";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPublish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ListView lvPublishedFolders;
        private System.Windows.Forms.Button btnSearchFolder;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnPublishFolder;
    }
}

