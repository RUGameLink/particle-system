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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.canvas = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.starter = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.redColorBox = new System.Windows.Forms.PictureBox();
            this.greenColorBox = new System.Windows.Forms.PictureBox();
            this.minSpeed = new System.Windows.Forms.TrackBar();
            this.maxSpeed = new System.Windows.Forms.TrackBar();
            this.colorValue = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(624, 442);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // starter
            // 
            this.starter.Location = new System.Drawing.Point(647, 13);
            this.starter.Name = "starter";
            this.starter.Size = new System.Drawing.Size(75, 23);
            this.starter.TabIndex = 1;
            this.starter.Text = "Стaрт";
            this.starter.UseVisualStyleBackColor = true;
            this.starter.Click += new System.EventHandler(this.starter_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(630, 123);
            this.trackBar2.Maximum = 6;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 3;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Стоп";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // redColorBox
            // 
            this.redColorBox.Image = ((System.Drawing.Image)(resources.GetObject("redColorBox.Image")));
            this.redColorBox.Location = new System.Drawing.Point(630, 259);
            this.redColorBox.Name = "redColorBox";
            this.redColorBox.Size = new System.Drawing.Size(22, 17);
            this.redColorBox.TabIndex = 6;
            this.redColorBox.TabStop = false;
            // 
            // greenColorBox
            // 
            this.greenColorBox.Image = ((System.Drawing.Image)(resources.GetObject("greenColorBox.Image")));
            this.greenColorBox.Location = new System.Drawing.Point(671, 259);
            this.greenColorBox.Name = "greenColorBox";
            this.greenColorBox.Size = new System.Drawing.Size(22, 17);
            this.greenColorBox.TabIndex = 7;
            this.greenColorBox.TabStop = false;
            // 
            // minSpeed
            // 
            this.minSpeed.Location = new System.Drawing.Point(630, 322);
            this.minSpeed.Maximum = 3;
            this.minSpeed.Minimum = 1;
            this.minSpeed.Name = "minSpeed";
            this.minSpeed.Size = new System.Drawing.Size(104, 45);
            this.minSpeed.TabIndex = 9;
            this.minSpeed.Value = 1;
            this.minSpeed.Scroll += new System.EventHandler(this.minSpeed_Scroll);
            // 
            // maxSpeed
            // 
            this.maxSpeed.Location = new System.Drawing.Point(630, 384);
            this.maxSpeed.Maximum = 8;
            this.maxSpeed.Minimum = 4;
            this.maxSpeed.Name = "maxSpeed";
            this.maxSpeed.Size = new System.Drawing.Size(104, 45);
            this.maxSpeed.TabIndex = 10;
            this.maxSpeed.Value = 6;
            this.maxSpeed.Scroll += new System.EventHandler(this.maxSpeed_Scroll);
            // 
            // colorValue
            // 
            this.colorValue.Location = new System.Drawing.Point(630, 208);
            this.colorValue.Maximum = 3;
            this.colorValue.Minimum = 1;
            this.colorValue.Name = "colorValue";
            this.colorValue.Size = new System.Drawing.Size(104, 45);
            this.colorValue.TabIndex = 11;
            this.colorValue.Value = 1;
            this.colorValue.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(712, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 17);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Грaвитaция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Изменение цвет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Мин скорость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Мaкс скорость";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 441);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.colorValue);
            this.Controls.Add(this.maxSpeed);
            this.Controls.Add(this.minSpeed);
            this.Controls.Add(this.greenColorBox);
            this.Controls.Add(this.redColorBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.starter);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button starter;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox redColorBox;
        private System.Windows.Forms.PictureBox greenColorBox;
        private System.Windows.Forms.TrackBar minSpeed;
        private System.Windows.Forms.TrackBar maxSpeed;
        private System.Windows.Forms.TrackBar colorValue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

