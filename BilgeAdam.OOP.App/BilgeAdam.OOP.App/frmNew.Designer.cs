namespace BilgeAdam.OOP.App
{
    partial class frmNew
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.dtpBirhtDate = new System.Windows.Forms.DateTimePicker();
            this.nudBreast = new System.Windows.Forms.NumericUpDown();
            this.nudWaist = new System.Windows.Forms.NumericUpDown();
            this.nudHips = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWaist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(245, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı Soyadı";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(84, 16);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(236, 20);
            this.txtFullName.TabIndex = 2;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(84, 68);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(236, 21);
            this.cmbLanguage.TabIndex = 3;
            // 
            // dtpBirhtDate
            // 
            this.dtpBirhtDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBirhtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirhtDate.Location = new System.Drawing.Point(84, 42);
            this.dtpBirhtDate.Name = "dtpBirhtDate";
            this.dtpBirhtDate.Size = new System.Drawing.Size(236, 20);
            this.dtpBirhtDate.TabIndex = 4;
            // 
            // nudBreast
            // 
            this.nudBreast.Location = new System.Drawing.Point(6, 35);
            this.nudBreast.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudBreast.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nudBreast.Name = "nudBreast";
            this.nudBreast.Size = new System.Drawing.Size(61, 20);
            this.nudBreast.TabIndex = 5;
            this.nudBreast.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // nudWaist
            // 
            this.nudWaist.Location = new System.Drawing.Point(88, 35);
            this.nudWaist.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudWaist.Minimum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nudWaist.Name = "nudWaist";
            this.nudWaist.Size = new System.Drawing.Size(61, 20);
            this.nudWaist.TabIndex = 5;
            this.nudWaist.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // nudHips
            // 
            this.nudHips.Location = new System.Drawing.Point(166, 35);
            this.nudHips.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudHips.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nudHips.Name = "nudHips";
            this.nudHips.Size = new System.Drawing.Size(61, 20);
            this.nudHips.TabIndex = 5;
            this.nudHips.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(6, 35);
            this.nudHeight.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(80, 20);
            this.nudHeight.TabIndex = 5;
            this.nudHeight.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            // 
            // nudWeight
            // 
            this.nudWeight.Location = new System.Drawing.Point(147, 35);
            this.nudWeight.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(80, 20);
            this.nudWeight.TabIndex = 5;
            this.nudWeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudBreast);
            this.groupBox1.Controls.Add(this.nudWaist);
            this.groupBox1.Controls.Add(this.nudHips);
            this.groupBox1.Location = new System.Drawing.Point(84, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 69);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ölçüler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kalça";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Göğüs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudHeight);
            this.groupBox2.Controls.Add(this.nudWeight);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(84, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 63);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Boy - Kilo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Kilo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Boy";
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(84, 238);
            this.nudPrice.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudPrice.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(236, 20);
            this.nudPrice.TabIndex = 6;
            this.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPrice.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dil";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ücret";
            // 
            // frmNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 300);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpBirhtDate);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Manken Tanımı";
            this.Load += new System.EventHandler(this.frmNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBreast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWaist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.DateTimePicker dtpBirhtDate;
        private System.Windows.Forms.NumericUpDown nudBreast;
        private System.Windows.Forms.NumericUpDown nudWaist;
        private System.Windows.Forms.NumericUpDown nudHips;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}