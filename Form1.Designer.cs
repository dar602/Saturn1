namespace saturn
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(901, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать на сайт открытого акционерного общества \"Сатурн\"";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Control;
            this.monthCalendar1.Location = new System.Drawing.Point(7, 375);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.OrangeRed;
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.Maroon;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::saturn.Properties.Resources._23_;
            this.pictureBox1.Location = new System.Drawing.Point(563, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 283);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(370, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(664, 146);
            this.label3.TabIndex = 9;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.linkLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.MediumBlue;
            this.linkLabel1.Location = new System.Drawing.Point(1, 168);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel1.Size = new System.Drawing.Size(324, 34);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Информация о предприятии";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel2.LinkColor = System.Drawing.Color.MediumBlue;
            this.linkLabel2.Location = new System.Drawing.Point(12, 215);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(298, 33);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Руководители предприятия";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Меню";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel3.LinkColor = System.Drawing.Color.MediumBlue;
            this.linkLabel3.Location = new System.Drawing.Point(14, 261);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(283, 33);
            this.linkLabel3.TabIndex = 14;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Контактная информация";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel4.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel4.LinkColor = System.Drawing.Color.MediumBlue;
            this.linkLabel4.Location = new System.Drawing.Point(14, 305);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(177, 33);
            this.linkLabel4.TabIndex = 15;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Обратная связь";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel5.LinkColor = System.Drawing.Color.White;
            this.linkLabel5.Location = new System.Drawing.Point(967, 24);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(58, 20);
            this.linkLabel5.TabIndex = 16;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Выйти";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(867, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Всю интересующую вас информацию вы можете получить по номеру телефона 3812311573 " +
    "или задать нам вопрос через раздел \"Обратная связь\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::saturn.Properties.Resources.zwalls_ru_14152;
            this.ClientSize = new System.Drawing.Size(1046, 556);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

