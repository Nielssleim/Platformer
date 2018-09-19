namespace Platformer
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
            this.Base = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Screen1 = new System.Windows.Forms.Panel();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wall = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.gameOver = new System.Windows.Forms.Label();
            this.lifesFrame = new System.Windows.Forms.Label();
            this.Ouch = new System.Windows.Forms.PictureBox();
            this.Blok2 = new System.Windows.Forms.PictureBox();
            this.Blok = new System.Windows.Forms.PictureBox();
            this.Poppetje = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Screen1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ouch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blok2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poppetje)).BeginInit();
            this.SuspendLayout();
            // 
            // Base
            // 
            this.Base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Base.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Base.Location = new System.Drawing.Point(0, 641);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(1815, 128);
            this.Base.TabIndex = 1;
            this.Base.Paint += new System.Windows.Forms.PaintEventHandler(this.Base_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Screen1
            // 
            this.Screen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Screen1.Controls.Add(this.life1);
            this.Screen1.Controls.Add(this.pictureBox1);
            this.Screen1.Controls.Add(this.wall);
            this.Screen1.Controls.Add(this.enemy1);
            this.Screen1.Controls.Add(this.gameOver);
            this.Screen1.Controls.Add(this.lifesFrame);
            this.Screen1.Controls.Add(this.Ouch);
            this.Screen1.Controls.Add(this.Blok2);
            this.Screen1.Controls.Add(this.Blok);
            this.Screen1.Controls.Add(this.Poppetje);
            this.Screen1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Screen1.Location = new System.Drawing.Point(0, 0);
            this.Screen1.Name = "Screen1";
            this.Screen1.Size = new System.Drawing.Size(1815, 646);
            this.Screen1.TabIndex = 2;
            // 
            // life1
            // 
            this.life1.Image = global::Platformer.Properties.Resources.life;
            this.life1.Location = new System.Drawing.Point(4, 615);
            this.life1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(30, 31);
            this.life1.TabIndex = 3;
            this.life1.TabStop = false;
            this.life1.Click += new System.EventHandler(this.life1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(-44, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 657);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // wall
            // 
            this.wall.BackColor = System.Drawing.Color.Black;
            this.wall.Dock = System.Windows.Forms.DockStyle.Left;
            this.wall.Location = new System.Drawing.Point(0, 0);
            this.wall.Name = "wall";
            this.wall.Size = new System.Drawing.Size(2, 646);
            this.wall.TabIndex = 6;
            this.wall.TabStop = false;
            this.wall.Visible = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Yellow;
            this.enemy1.Location = new System.Drawing.Point(156, 622);
            this.enemy1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(27, 25);
            this.enemy1.TabIndex = 5;
            this.enemy1.TabStop = false;
            this.enemy1.Move += new System.EventHandler(this.enemy1_move);
            // 
            // gameOver
            // 
            this.gameOver.AutoSize = true;
            this.gameOver.Location = new System.Drawing.Point(732, 285);
            this.gameOver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(0, 20);
            this.gameOver.TabIndex = 4;
            this.gameOver.Paint += new System.Windows.Forms.PaintEventHandler(this.label2_Create);
            // 
            // lifesFrame
            // 
            this.lifesFrame.AutoSize = true;
            this.lifesFrame.Location = new System.Drawing.Point(18, 14);
            this.lifesFrame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lifesFrame.Name = "lifesFrame";
            this.lifesFrame.Size = new System.Drawing.Size(51, 20);
            this.lifesFrame.TabIndex = 3;
            this.lifesFrame.Text = "label1";
            this.lifesFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Create);
            // 
            // Ouch
            // 
            this.Ouch.BackColor = System.Drawing.Color.Red;
            this.Ouch.Location = new System.Drawing.Point(1401, 622);
            this.Ouch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ouch.Name = "Ouch";
            this.Ouch.Size = new System.Drawing.Size(250, 60);
            this.Ouch.TabIndex = 3;
            this.Ouch.TabStop = false;
            this.Ouch.Click += new System.EventHandler(this.Ouch_Click);
            this.Ouch.Paint += new System.Windows.Forms.PaintEventHandler(this.Ouch_Create);
            // 
            // Blok2
            // 
            this.Blok2.BackColor = System.Drawing.Color.Transparent;
            this.Blok2.BackgroundImage = global::Platformer.Properties.Resources.fan;
            this.Blok2.Location = new System.Drawing.Point(927, 326);
            this.Blok2.Name = "Blok2";
            this.Blok2.Size = new System.Drawing.Size(210, 320);
            this.Blok2.TabIndex = 2;
            this.Blok2.TabStop = false;
            this.Blok2.Click += new System.EventHandler(this.Blok2_Click);
            // 
            // Blok
            // 
            this.Blok.BackColor = System.Drawing.Color.Black;
            this.Blok.Location = new System.Drawing.Point(632, 485);
            this.Blok.Name = "Blok";
            this.Blok.Size = new System.Drawing.Size(100, 172);
            this.Blok.TabIndex = 1;
            this.Blok.TabStop = false;
            this.Blok.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Poppetje
            // 
            this.Poppetje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Poppetje.Location = new System.Drawing.Point(728, 29);
            this.Poppetje.Name = "Poppetje";
            this.Poppetje.Size = new System.Drawing.Size(30, 25);
            this.Poppetje.TabIndex = 0;
            this.Poppetje.TabStop = false;
            this.Poppetje.Click += new System.EventHandler(this.Poppetje_Click_1);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1815, 769);
            this.Controls.Add(this.Screen1);
            this.Controls.Add(this.Base);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Screen1.ResumeLayout(false);
            this.Screen1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ouch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blok2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poppetje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Base;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Screen1;
        private System.Windows.Forms.PictureBox Poppetje;
        private System.Windows.Forms.PictureBox Blok;
        private System.Windows.Forms.PictureBox Blok2;
        private System.Windows.Forms.PictureBox Ouch;
        private System.Windows.Forms.Label lifesFrame;
        private System.Windows.Forms.Label gameOver;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox wall;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox life1;
    }
}

