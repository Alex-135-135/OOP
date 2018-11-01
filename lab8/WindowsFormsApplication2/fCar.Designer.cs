namespace WindowsFormsApplication2
{
    partial class fCar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMagaz = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbYearIncome = new System.Windows.Forms.TextBox();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chbStrahovka = new System.Windows.Forms.CheckBox();
            this.chbCredit = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCreditN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMagaz);
            this.groupBox1.Controls.Add(this.tbAge);
            this.groupBox1.Controls.Add(this.tbYearIncome);
            this.groupBox1.Controls.Add(this.tbMarka);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            // 
            // tbMagaz
            // 
            this.tbMagaz.Location = new System.Drawing.Point(193, 96);
            this.tbMagaz.Name = "tbMagaz";
            this.tbMagaz.Size = new System.Drawing.Size(168, 20);
            this.tbMagaz.TabIndex = 11;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(193, 129);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(168, 20);
            this.tbAge.TabIndex = 10;
            // 
            // tbYearIncome
            // 
            this.tbYearIncome.Location = new System.Drawing.Point(193, 164);
            this.tbYearIncome.Name = "tbYearIncome";
            this.tbYearIncome.Size = new System.Drawing.Size(168, 20);
            this.tbYearIncome.TabIndex = 9;
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(193, 63);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(168, 20);
            this.tbMarka.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(193, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(168, 20);
            this.tbName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ціна автомобіля";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кількість років автомобілю";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Назва магазину";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Марка автомобіля";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва атомобіля";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(389, 43);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(389, 75);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chbStrahovka
            // 
            this.chbStrahovka.AutoSize = true;
            this.chbStrahovka.Location = new System.Drawing.Point(9, 29);
            this.chbStrahovka.Name = "chbStrahovka";
            this.chbStrahovka.Size = new System.Drawing.Size(161, 17);
            this.chbStrahovka.TabIndex = 14;
            this.chbStrahovka.Text = "Автомобіль має страховку";
            this.chbStrahovka.UseVisualStyleBackColor = true;
            this.chbStrahovka.CheckedChanged += new System.EventHandler(this.chbStrahovka_CheckedChanged);
            // 
            // chbCredit
            // 
            this.chbCredit.AutoSize = true;
            this.chbCredit.Location = new System.Drawing.Point(9, 63);
            this.chbCredit.Name = "chbCredit";
            this.chbCredit.Size = new System.Drawing.Size(129, 17);
            this.chbCredit.TabIndex = 15;
            this.chbCredit.Text = "Можливість кредиту";
            this.chbCredit.UseVisualStyleBackColor = true;
            this.chbCredit.CheckedChanged += new System.EventHandler(this.chbCredit_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCreditN);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.chbCredit);
            this.groupBox2.Controls.Add(this.chbStrahovka);
            this.groupBox2.Location = new System.Drawing.Point(12, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додаткова інформація";
            // 
            // tbCreditN
            // 
            this.tbCreditN.Location = new System.Drawing.Point(193, 95);
            this.tbCreditN.Name = "tbCreditN";
            this.tbCreditN.ReadOnly = true;
            this.tbCreditN.Size = new System.Drawing.Size(168, 20);
            this.tbCreditN.TabIndex = 17;
            this.tbCreditN.TextChanged += new System.EventHandler(this.tbCreditN_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Кількість місяців";
            // 
            // fCar
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(471, 370);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "fCar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про новий фільм";
            this.Load += new System.EventHandler(this.fTown_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMagaz;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbYearIncome;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chbCredit;
        private System.Windows.Forms.CheckBox chbStrahovka;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCreditN;
        private System.Windows.Forms.Label label6;
    }
}