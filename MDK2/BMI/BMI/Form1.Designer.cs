namespace BMI
{
    partial class woman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(woman));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.schet = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pic_wom = new System.Windows.Forms.PictureBox();
            this.pic_man = new System.Windows.Forms.PictureBox();
            this.rost_v = new System.Windows.Forms.TextBox();
            this.ves_v = new System.Windows.Forms.TextBox();
            this.cof = new System.Windows.Forms.Label();
            this.it2 = new System.Windows.Forms.PictureBox();
            this.it1 = new System.Windows.Forms.PictureBox();
            this.it3 = new System.Windows.Forms.PictureBox();
            this.it4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.asf = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_wom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.it2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.it1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.it3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.it4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI  калькулятор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.label2.Location = new System.Drawing.Point(161, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Определяет находится ли вес в норме";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Рост";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вес";
            // 
            // schet
            // 
            this.schet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.schet.Location = new System.Drawing.Point(17, 363);
            this.schet.Name = "schet";
            this.schet.Size = new System.Drawing.Size(108, 41);
            this.schet.TabIndex = 4;
            this.schet.Text = "Расчитать";
            this.schet.UseVisualStyleBackColor = true;
            this.schet.Click += new System.EventHandler(this.SCHET);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(144, 363);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(89, 41);
            this.back.TabIndex = 5;
            this.back.Text = "Отмена";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(160, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "см";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(160, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "кг";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(380, 309);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(392, 45);
            this.trackBar1.TabIndex = 58;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pic_wom
            // 
            this.pic_wom.BackColor = System.Drawing.Color.White;
            this.pic_wom.Image = ((System.Drawing.Image)(resources.GetObject("pic_wom.Image")));
            this.pic_wom.Location = new System.Drawing.Point(21, 97);
            this.pic_wom.Name = "pic_wom";
            this.pic_wom.Size = new System.Drawing.Size(74, 132);
            this.pic_wom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_wom.TabIndex = 53;
            this.pic_wom.TabStop = false;
            this.pic_wom.Click += new System.EventHandler(this.pic_womClick);
            // 
            // pic_man
            // 
            this.pic_man.BackColor = System.Drawing.Color.White;
            this.pic_man.Image = ((System.Drawing.Image)(resources.GetObject("pic_man.Image")));
            this.pic_man.Location = new System.Drawing.Point(101, 97);
            this.pic_man.Name = "pic_man";
            this.pic_man.Size = new System.Drawing.Size(74, 132);
            this.pic_man.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_man.TabIndex = 54;
            this.pic_man.TabStop = false;
            this.pic_man.Click += new System.EventHandler(this.man_Click);
            // 
            // rost_v
            // 
            this.rost_v.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rost_v.Location = new System.Drawing.Point(75, 246);
            this.rost_v.Multiline = true;
            this.rost_v.Name = "rost_v";
            this.rost_v.Size = new System.Drawing.Size(64, 33);
            this.rost_v.TabIndex = 55;
            // 
            // ves_v
            // 
            this.ves_v.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ves_v.Location = new System.Drawing.Point(75, 295);
            this.ves_v.Multiline = true;
            this.ves_v.Name = "ves_v";
            this.ves_v.Size = new System.Drawing.Size(64, 33);
            this.ves_v.TabIndex = 56;
            // 
            // cof
            // 
            this.cof.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cof.Location = new System.Drawing.Point(553, 275);
            this.cof.Name = "cof";
            this.cof.Size = new System.Drawing.Size(52, 32);
            this.cof.TabIndex = 57;
            // 
            // it2
            // 
            this.it2.BackColor = System.Drawing.Color.White;
            this.it2.Image = ((System.Drawing.Image)(resources.GetObject("it2.Image")));
            this.it2.Location = new System.Drawing.Point(516, 97);
            this.it2.Name = "it2";
            this.it2.Size = new System.Drawing.Size(130, 163);
            this.it2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.it2.TabIndex = 58;
            this.it2.TabStop = false;
            // 
            // it1
            // 
            this.it1.BackColor = System.Drawing.Color.White;
            this.it1.Image = ((System.Drawing.Image)(resources.GetObject("it1.Image")));
            this.it1.Location = new System.Drawing.Point(516, 97);
            this.it1.Name = "it1";
            this.it1.Size = new System.Drawing.Size(130, 163);
            this.it1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.it1.TabIndex = 59;
            this.it1.TabStop = false;
            // 
            // it3
            // 
            this.it3.BackColor = System.Drawing.Color.White;
            this.it3.Image = ((System.Drawing.Image)(resources.GetObject("it3.Image")));
            this.it3.Location = new System.Drawing.Point(516, 97);
            this.it3.Name = "it3";
            this.it3.Size = new System.Drawing.Size(130, 163);
            this.it3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.it3.TabIndex = 60;
            this.it3.TabStop = false;
            this.it3.Click += new System.EventHandler(this.it3_Click);
            // 
            // it4
            // 
            this.it4.BackColor = System.Drawing.Color.White;
            this.it4.Image = ((System.Drawing.Image)(resources.GetObject("it4.Image")));
            this.it4.Location = new System.Drawing.Point(516, 97);
            this.it4.Name = "it4";
            this.it4.Size = new System.Drawing.Size(130, 163);
            this.it4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.it4.TabIndex = 61;
            this.it4.TabStop = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Cyan;
            this.label7.Location = new System.Drawing.Point(386, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(528, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(579, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 64;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(612, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 13);
            this.label10.TabIndex = 65;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(389, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 17);
            this.label11.TabIndex = 66;
            this.label11.Text = "Недостаточный";
            // 
            // asf
            // 
            this.asf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.asf.Location = new System.Drawing.Point(520, 363);
            this.asf.Name = "asf";
            this.asf.Size = new System.Drawing.Size(53, 17);
            this.asf.TabIndex = 67;
            this.asf.Text = "норма";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(579, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 17);
            this.label12.TabIndex = 68;
            this.label12.Text = "изб";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(612, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 17);
            this.label13.TabIndex = 69;
            this.label13.Text = "Ожирение";
            // 
            // woman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.asf);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.it4);
            this.Controls.Add(this.it3);
            this.Controls.Add(this.it1);
            this.Controls.Add(this.it2);
            this.Controls.Add(this.cof);
            this.Controls.Add(this.ves_v);
            this.Controls.Add(this.rost_v);
            this.Controls.Add(this.pic_man);
            this.Controls.Add(this.pic_wom);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.back);
            this.Controls.Add(this.schet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "woman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_wom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.it2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.it1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.it3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.it4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button schet;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pic_wom;
        private System.Windows.Forms.PictureBox pic_man;
        private System.Windows.Forms.TextBox rost_v;
        private System.Windows.Forms.TextBox ves_v;
        private System.Windows.Forms.Label cof;
        private System.Windows.Forms.PictureBox it2;
        private System.Windows.Forms.PictureBox it1;
        private System.Windows.Forms.PictureBox it3;
        private System.Windows.Forms.PictureBox it4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label asf;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

