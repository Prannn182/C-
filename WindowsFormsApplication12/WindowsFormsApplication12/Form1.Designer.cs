namespace WindowsFormsApplication12
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.over = new System.Windows.Forms.Label();
            this.coin4 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.BackColor = System.Drawing.Color.Khaki;
            this.over.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.ForeColor = System.Drawing.Color.DarkRed;
            this.over.Location = new System.Drawing.Point(106, 192);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(194, 32);
            this.over.TabIndex = 11;
            this.over.Text = "GAME OVER";
            // 
            // coin4
            // 
            this.coin4.BackColor = System.Drawing.Color.Gray;
            this.coin4.Image = global::WindowsFormsApplication12.Properties.Resources.coin;
            this.coin4.Location = new System.Drawing.Point(297, 330);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(25, 25);
            this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin4.TabIndex = 12;
            this.coin4.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = global::WindowsFormsApplication12.Properties.Resources.obstacle;
            this.enemy3.Location = new System.Drawing.Point(219, 98);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(61, 48);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 10;
            this.enemy3.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = global::WindowsFormsApplication12.Properties.Resources.obstacle;
            this.enemy2.Location = new System.Drawing.Point(297, 12);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(63, 52);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 9;
            this.enemy2.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = global::WindowsFormsApplication12.Properties.Resources.obstacle;
            this.enemy1.Location = new System.Drawing.Point(35, 98);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(63, 47);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 7;
            this.enemy1.TabStop = false;
            // 
            // car
            // 
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(73, 353);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(52, 110);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 6;
            this.car.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox7.Location = new System.Drawing.Point(388, -28);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 584);
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox5.Location = new System.Drawing.Point(203, 423);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 152);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox4.Location = new System.Drawing.Point(203, 279);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 123);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox3.Location = new System.Drawing.Point(203, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 147);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(203, -28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 120);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox6.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(11, 562);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // coin3
            // 
            this.coin3.BackColor = System.Drawing.Color.Gray;
            this.coin3.Image = global::WindowsFormsApplication12.Properties.Resources.coin;
            this.coin3.Location = new System.Drawing.Point(139, 254);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(25, 25);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 13;
            this.coin3.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.BackColor = System.Drawing.Color.Gray;
            this.coin2.Image = global::WindowsFormsApplication12.Properties.Resources.coin;
            this.coin2.Location = new System.Drawing.Point(335, 121);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(25, 25);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 14;
            this.coin2.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.Gray;
            this.coin1.Image = global::WindowsFormsApplication12.Properties.Resources.coin;
            this.coin1.Location = new System.Drawing.Point(139, 39);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(25, 25);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 15;
            this.coin1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "coins=0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(398, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.over);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_keydown);
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.PictureBox coin4;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.Label label1;
    }
}

