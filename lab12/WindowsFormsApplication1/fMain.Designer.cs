namespace WindowsFormsApplication1
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnTools = new System.Windows.Forms.Panel();
            this.cbFigureType = new System.Windows.Forms.ComboBox();
            this.btnLeftFar = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRightFar = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDownFar = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnUpFar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.cbFigures = new System.Windows.Forms.ComboBox();
            this.pnMain.SuspendLayout();
            this.pnTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Controls.Add(this.panel2);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(720, 520);
            this.pnMain.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(490, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 499);
            this.panel2.TabIndex = 1;
            // 
            // pnTools
            // 
            this.pnTools.Controls.Add(this.cbFigureType);
            this.pnTools.Controls.Add(this.btnLeftFar);
            this.pnTools.Controls.Add(this.btnCreateNew);
            this.pnTools.Controls.Add(this.btnShow);
            this.pnTools.Controls.Add(this.btnLeft);
            this.pnTools.Controls.Add(this.btnRightFar);
            this.pnTools.Controls.Add(this.btnRight);
            this.pnTools.Controls.Add(this.btnDownFar);
            this.pnTools.Controls.Add(this.btnDown);
            this.pnTools.Controls.Add(this.btnCollapse);
            this.pnTools.Controls.Add(this.btnExpand);
            this.pnTools.Controls.Add(this.btnUp);
            this.pnTools.Controls.Add(this.btnUpFar);
            this.pnTools.Controls.Add(this.label1);
            this.pnTools.Controls.Add(this.btnHide);
            this.pnTools.Controls.Add(this.cbFigures);
            this.pnTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTools.Location = new System.Drawing.Point(488, 0);
            this.pnTools.Name = "pnTools";
            this.pnTools.Size = new System.Drawing.Size(232, 520);
            this.pnTools.TabIndex = 1;
            // 
            // cbFigureType
            // 
            this.cbFigureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFigureType.FormattingEnabled = true;
            this.cbFigureType.Items.AddRange(new object[] {
            "Коло",
            "Прямокутник",
            "Трикутник",
            "Емблема"});
            this.cbFigureType.Location = new System.Drawing.Point(116, 85);
            this.cbFigureType.Name = "cbFigureType";
            this.cbFigureType.Size = new System.Drawing.Size(100, 21);
            this.cbFigureType.TabIndex = 17;
            // 
            // btnLeftFar
            // 
            this.btnLeftFar.BackColor = System.Drawing.Color.White;
            this.btnLeftFar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLeftFar.BackgroundImage")));
            this.btnLeftFar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLeftFar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLeftFar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLeftFar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftFar.Location = new System.Drawing.Point(12, 325);
            this.btnLeftFar.Name = "btnLeftFar";
            this.btnLeftFar.Size = new System.Drawing.Size(30, 60);
            this.btnLeftFar.TabIndex = 16;
            this.btnLeftFar.UseVisualStyleBackColor = false;
            this.btnLeftFar.Click += new System.EventHandler(this.btnLeftFar_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(12, 75);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(97, 38);
            this.btnCreateNew.TabIndex = 1;
            this.btnCreateNew.Text = "Створити новий об\'єкт";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 119);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(204, 31);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Показати об\'єкт";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.White;
            this.btnLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLeft.BackgroundImage")));
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Location = new System.Drawing.Point(48, 325);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(30, 60);
            this.btnLeft.TabIndex = 15;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRightFar
            // 
            this.btnRightFar.BackColor = System.Drawing.Color.White;
            this.btnRightFar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRightFar.BackgroundImage")));
            this.btnRightFar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRightFar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRightFar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRightFar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightFar.Location = new System.Drawing.Point(186, 325);
            this.btnRightFar.Name = "btnRightFar";
            this.btnRightFar.Size = new System.Drawing.Size(30, 60);
            this.btnRightFar.TabIndex = 14;
            this.btnRightFar.UseVisualStyleBackColor = false;
            this.btnRightFar.Click += new System.EventHandler(this.btnRightFar_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.White;
            this.btnRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRight.BackgroundImage")));
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Location = new System.Drawing.Point(150, 325);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(30, 60);
            this.btnRight.TabIndex = 13;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDownFar
            // 
            this.btnDownFar.BackColor = System.Drawing.Color.White;
            this.btnDownFar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDownFar.BackgroundImage")));
            this.btnDownFar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDownFar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDownFar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDownFar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownFar.Location = new System.Drawing.Point(84, 434);
            this.btnDownFar.Name = "btnDownFar";
            this.btnDownFar.Size = new System.Drawing.Size(60, 30);
            this.btnDownFar.TabIndex = 12;
            this.btnDownFar.UseVisualStyleBackColor = false;
            this.btnDownFar.Click += new System.EventHandler(this.btnDownFar_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.White;
            this.btnDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDown.BackgroundImage")));
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Location = new System.Drawing.Point(84, 399);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(60, 30);
            this.btnDown.TabIndex = 11;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.Color.White;
            this.btnCollapse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCollapse.BackgroundImage")));
            this.btnCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCollapse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCollapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.Location = new System.Drawing.Point(84, 356);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(60, 37);
            this.btnCollapse.TabIndex = 10;
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.Color.White;
            this.btnExpand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExpand.BackgroundImage")));
            this.btnExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExpand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExpand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpand.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExpand.Location = new System.Drawing.Point(84, 317);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(60, 37);
            this.btnExpand.TabIndex = 9;
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.White;
            this.btnUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUp.BackgroundImage")));
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUp.Location = new System.Drawing.Point(84, 281);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(60, 30);
            this.btnUp.TabIndex = 8;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnUpFar
            // 
            this.btnUpFar.BackColor = System.Drawing.Color.White;
            this.btnUpFar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpFar.BackgroundImage")));
            this.btnUpFar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpFar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUpFar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpFar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpFar.Location = new System.Drawing.Point(84, 246);
            this.btnUpFar.Name = "btnUpFar";
            this.btnUpFar.Size = new System.Drawing.Size(60, 30);
            this.btnUpFar.TabIndex = 7;
            this.btnUpFar.UseVisualStyleBackColor = false;
            this.btnUpFar.Click += new System.EventHandler(this.btnUpFar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Перелік об\'єктів";
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(12, 156);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(204, 31);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "Приховати об\'єкт";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // cbFigures
            // 
            this.cbFigures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFigures.FormattingEnabled = true;
            this.cbFigures.Location = new System.Drawing.Point(12, 27);
            this.cbFigures.Name = "cbFigures";
            this.cbFigures.Size = new System.Drawing.Size(204, 21);
            this.cbFigures.TabIndex = 0;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 520);
            this.Controls.Add(this.pnTools);
            this.Controls.Add(this.pnMain);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №12";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.pnMain.ResumeLayout(false);
            this.pnTools.ResumeLayout(false);
            this.pnTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnTools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.ComboBox cbFigures;
        private System.Windows.Forms.Button btnLeftFar;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRightFar;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDownFar;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnUpFar;
        private System.Windows.Forms.ComboBox cbFigureType;
    }
}

