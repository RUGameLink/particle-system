﻿namespace K2Coursework
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
            this.button2 = new System.Windows.Forms.Button();
            this.redColorBox = new System.Windows.Forms.PictureBox();
            this.greenColorBox = new System.Windows.Forms.PictureBox();
            this.yellowColorBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowColorBox)).BeginInit();
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
            this.trackBar2.Maximum = 4;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(647, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Пошговое NOT WORK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // redColorBox
            // 
            this.redColorBox.Image = ((System.Drawing.Image)(resources.GetObject("redColorBox.Image")));
            this.redColorBox.Location = new System.Drawing.Point(647, 185);
            this.redColorBox.Name = "redColorBox";
            this.redColorBox.Size = new System.Drawing.Size(75, 28);
            this.redColorBox.TabIndex = 6;
            this.redColorBox.TabStop = false;
            this.redColorBox.Click += new System.EventHandler(this.redColorBox_Click);
            // 
            // greenColorBox
            // 
            this.greenColorBox.Image = ((System.Drawing.Image)(resources.GetObject("greenColorBox.Image")));
            this.greenColorBox.Location = new System.Drawing.Point(647, 219);
            this.greenColorBox.Name = "greenColorBox";
            this.greenColorBox.Size = new System.Drawing.Size(75, 28);
            this.greenColorBox.TabIndex = 7;
            this.greenColorBox.TabStop = false;
            this.greenColorBox.Click += new System.EventHandler(this.greenColorBox_Click);
            // 
            // yellowColorBox
            // 
            this.yellowColorBox.Image = ((System.Drawing.Image)(resources.GetObject("yellowColorBox.Image")));
            this.yellowColorBox.Location = new System.Drawing.Point(647, 253);
            this.yellowColorBox.Name = "yellowColorBox";
            this.yellowColorBox.Size = new System.Drawing.Size(75, 28);
            this.yellowColorBox.TabIndex = 8;
            this.yellowColorBox.TabStop = false;
            this.yellowColorBox.Click += new System.EventHandler(this.yellowColorBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 441);
            this.Controls.Add(this.yellowColorBox);
            this.Controls.Add(this.greenColorBox);
            this.Controls.Add(this.redColorBox);
            this.Controls.Add(this.button2);
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
            ((System.ComponentModel.ISupportInitialize)(this.yellowColorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button starter;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox redColorBox;
        private System.Windows.Forms.PictureBox greenColorBox;
        private System.Windows.Forms.PictureBox yellowColorBox;
    }
}

