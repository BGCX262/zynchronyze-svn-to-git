namespace zynchronize.ClientInterface
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
            this.dgvAvailableFolders = new System.Windows.Forms.DataGridView();
            this.btnSubscribe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableFolders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvailableFolders
            // 
            this.dgvAvailableFolders.AllowUserToAddRows = false;
            this.dgvAvailableFolders.AllowUserToDeleteRows = false;
            this.dgvAvailableFolders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableFolders.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAvailableFolders.Location = new System.Drawing.Point(0, 0);
            this.dgvAvailableFolders.Name = "dgvAvailableFolders";
            this.dgvAvailableFolders.ReadOnly = true;
            this.dgvAvailableFolders.Size = new System.Drawing.Size(496, 205);
            this.dgvAvailableFolders.TabIndex = 0;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubscribe.Location = new System.Drawing.Point(137, 209);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(222, 23);
            this.btnSubscribe.TabIndex = 1;
            this.btnSubscribe.Text = "Subscribe to selected";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 234);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.dgvAvailableFolders);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableFolders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAvailableFolders;
        private System.Windows.Forms.Button btnSubscribe;
    }
}

