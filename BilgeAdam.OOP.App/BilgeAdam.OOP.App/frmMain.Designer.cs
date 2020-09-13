namespace BilgeAdam.OOP.App
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvModels = new System.Windows.Forms.DataGridView();
            this.mts = new System.Windows.Forms.MenuStrip();
            this.uygulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dgcFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModels)).BeginInit();
            this.mts.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvModels
            // 
            this.dgvModels.AllowUserToAddRows = false;
            this.dgvModels.AllowUserToDeleteRows = false;
            this.dgvModels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvModels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcFullName,
            this.dgcBirthDate});
            this.dgvModels.Location = new System.Drawing.Point(16, 42);
            this.dgvModels.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvModels.MultiSelect = false;
            this.dgvModels.Name = "dgvModels";
            this.dgvModels.ReadOnly = true;
            this.dgvModels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModels.Size = new System.Drawing.Size(852, 501);
            this.dgvModels.TabIndex = 0;
            // 
            // mts
            // 
            this.mts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uygulamaToolStripMenuItem});
            this.mts.Location = new System.Drawing.Point(0, 0);
            this.mts.Name = "mts";
            this.mts.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.mts.Size = new System.Drawing.Size(884, 25);
            this.mts.TabIndex = 1;
            this.mts.Text = "menuStrip1";
            // 
            // uygulamaToolStripMenuItem
            // 
            this.uygulamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsNew,
            this.mtsExit});
            this.uygulamaToolStripMenuItem.Name = "uygulamaToolStripMenuItem";
            this.uygulamaToolStripMenuItem.Size = new System.Drawing.Size(73, 19);
            this.uygulamaToolStripMenuItem.Text = "Uygulama";
            // 
            // mtsNew
            // 
            this.mtsNew.Name = "mtsNew";
            this.mtsNew.Size = new System.Drawing.Size(99, 22);
            this.mtsNew.Text = "Yeni";
            this.mtsNew.Click += new System.EventHandler(this.mtsNew_Click);
            // 
            // mtsExit
            // 
            this.mtsExit.Name = "mtsExit";
            this.mtsExit.Size = new System.Drawing.Size(99, 22);
            this.mtsExit.Text = "Çıkış";
            this.mtsExit.Click += new System.EventHandler(this.mtsExit_Click);
            // 
            // dgcFullName
            // 
            this.dgcFullName.DataPropertyName = "FullName";
            this.dgcFullName.HeaderText = "Adı Soyadı";
            this.dgcFullName.Name = "dgcFullName";
            this.dgcFullName.ReadOnly = true;
            // 
            // dgcBirthDate
            // 
            this.dgcBirthDate.DataPropertyName = "BirthDate";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.dgcBirthDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgcBirthDate.HeaderText = "Doğum Tarihi";
            this.dgcBirthDate.Name = "dgcBirthDate";
            this.dgcBirthDate.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.dgvModels);
            this.Controls.Add(this.mts);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.mts;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "frmMain";
            this.Text = "Can Manken Ajansı";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModels)).EndInit();
            this.mts.ResumeLayout(false);
            this.mts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModels;
        private System.Windows.Forms.MenuStrip mts;
        private System.Windows.Forms.ToolStripMenuItem uygulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mtsNew;
        private System.Windows.Forms.ToolStripMenuItem mtsExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBirthDate;
    }
}

