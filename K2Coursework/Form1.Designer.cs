namespace K2Coursework
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.canvas = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.blueColorBox = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pinkColorBox = new System.Windows.Forms.PictureBox();
            this.redColorBox = new System.Windows.Forms.PictureBox();
            this.greenColorBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.minSpeed = new System.Windows.Forms.TrackBar();
            this.maxSpeed = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stopBut = new System.Windows.Forms.Button();
            this.startBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColorBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(-1, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(818, 632);
            this.canvas.TabIndex = 1;
            this.canvas.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.blueColorBox);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.pinkColorBox);
            this.groupBox2.Controls.Add(this.redColorBox);
            this.groupBox2.Controls.Add(this.greenColorBox);
            this.groupBox2.Location = new System.Drawing.Point(825, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 259);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменение цвета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Цвет струи";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Положение закрашивалки";
            // 
            // blueColorBox
            // 
            this.blueColorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.blueColorBox.Location = new System.Drawing.Point(3, 206);
            this.blueColorBox.Name = "blueColorBox";
            this.blueColorBox.Size = new System.Drawing.Size(104, 28);
            this.blueColorBox.TabIndex = 34;
            this.blueColorBox.TabStop = false;
            this.blueColorBox.Click += new System.EventHandler(this.blueColorBox_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(0, 40);
            this.trackBar1.Maximum = 4;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 28;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pinkColorBox
            // 
            this.pinkColorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pinkColorBox.Location = new System.Drawing.Point(3, 172);
            this.pinkColorBox.Name = "pinkColorBox";
            this.pinkColorBox.Size = new System.Drawing.Size(104, 28);
            this.pinkColorBox.TabIndex = 33;
            this.pinkColorBox.TabStop = false;
            this.pinkColorBox.Click += new System.EventHandler(this.pinkColorBox_Click);
            // 
            // redColorBox
            // 
            this.redColorBox.BackColor = System.Drawing.Color.Red;
            this.redColorBox.Location = new System.Drawing.Point(3, 104);
            this.redColorBox.Name = "redColorBox";
            this.redColorBox.Size = new System.Drawing.Size(104, 28);
            this.redColorBox.TabIndex = 31;
            this.redColorBox.TabStop = false;
            this.redColorBox.Click += new System.EventHandler(this.redColorBox_Click);
            // 
            // greenColorBox
            // 
            this.greenColorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenColorBox.Location = new System.Drawing.Point(3, 138);
            this.greenColorBox.Name = "greenColorBox";
            this.greenColorBox.Size = new System.Drawing.Size(104, 28);
            this.greenColorBox.TabIndex = 32;
            this.greenColorBox.TabStop = false;
            this.greenColorBox.Click += new System.EventHandler(this.greenColorBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.minSpeed);
            this.groupBox1.Controls.Add(this.maxSpeed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(825, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 209);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Корректировка потока";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Грaвитaция";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(6, 32);
            this.trackBar2.Maximum = 6;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 17;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // minSpeed
            // 
            this.minSpeed.Location = new System.Drawing.Point(0, 96);
            this.minSpeed.Maximum = 4;
            this.minSpeed.Minimum = 1;
            this.minSpeed.Name = "minSpeed";
            this.minSpeed.Size = new System.Drawing.Size(104, 45);
            this.minSpeed.TabIndex = 20;
            this.minSpeed.Value = 1;
            this.minSpeed.Scroll += new System.EventHandler(this.minSpeed_Scroll);
            // 
            // maxSpeed
            // 
            this.maxSpeed.Location = new System.Drawing.Point(0, 169);
            this.maxSpeed.Maximum = 15;
            this.maxSpeed.Minimum = 8;
            this.maxSpeed.Name = "maxSpeed";
            this.maxSpeed.Size = new System.Drawing.Size(104, 45);
            this.maxSpeed.TabIndex = 21;
            this.maxSpeed.Value = 8;
            this.maxSpeed.Scroll += new System.EventHandler(this.maxSpeed_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Мин скорость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Мaкс скорость";
            // 
            // stopBut
            // 
            this.stopBut.Location = new System.Drawing.Point(843, 51);
            this.stopBut.Name = "stopBut";
            this.stopBut.Size = new System.Drawing.Size(75, 23);
            this.stopBut.TabIndex = 38;
            this.stopBut.Text = "Стоп";
            this.stopBut.UseVisualStyleBackColor = true;
            this.stopBut.Click += new System.EventHandler(this.stopBut_Click);
            // 
            // startBut
            // 
            this.startBut.Location = new System.Drawing.Point(843, 12);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(75, 23);
            this.startBut.TabIndex = 37;
            this.startBut.Text = "Стaрт";
            this.startBut.UseVisualStyleBackColor = true;
            this.startBut.Click += new System.EventHandler(this.startBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 630);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stopBut);
            this.Controls.Add(this.startBut);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColorBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox blueColorBox;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pinkColorBox;
        private System.Windows.Forms.PictureBox redColorBox;
        private System.Windows.Forms.PictureBox greenColorBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar minSpeed;
        private System.Windows.Forms.TrackBar maxSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button stopBut;
        private System.Windows.Forms.Button startBut;
    }
}

