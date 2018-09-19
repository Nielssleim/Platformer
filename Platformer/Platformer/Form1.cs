using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Platformer
{

    public partial class Form1 : Form
    {   int lifes = 5;
        int Zwaartekracht;
        int Kracht = 15;
        int dammageKracht = 7;
        bool rightL;
        bool leftL;
        bool Jump;
        bool jumping;
        bool onBlock = false;
        bool onFan = false;
        bool onLava = false;
        bool onLife = false;
        bool pause = false;
        bool restart = false;
        bool enamyMoveR = true;
        bool enamyMoveL = false;
        bool health = false;



        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (enamyMoveR == true)
            {
                enemy1.Left += 5;
            }

            if (enamyMoveL == true)
            {
                enemy1.Left -= 5;
            } 

            if (lifes == 0)
            {
                gameOver.SetBounds(490, (Screen1.Height / 2), 100, 40); 
                gameOver.Font = new Font("", 30);
                gameOver.Text = "Game Over";
                pause = true;
                this.timer1.Stop();
            }


            // POPPETJE KAN LINKS EN REWCHTS NIET DOOR BLOK LOPEN
            if (Poppetje.Right > Blok.Left && Poppetje.Left < Blok.Right - Poppetje.Width / 2 && Poppetje.Bottom > Blok.Top)
            {
                rightL = false;
            } else if (rightL == true)
            {
                Poppetje.Left = Poppetje.Left + 5;
            }

            if (Poppetje.Left < Blok.Right && Poppetje.Right > Blok.Left + Poppetje.Width / 2 && Poppetje.Bottom > Blok.Top)
            {
                leftL = false;
            } else if (leftL == true)
            {
                Poppetje.Left = Poppetje.Left - 5;
            }


            // enemy1 KAN LINKS EN RECHTS NIET DOOR BLOK LOPEN
            if (enemy1.Right > Blok.Left && enemy1.Left < Blok.Right - enemy1.Width / 2 && enemy1.Bottom > Blok.Top)
            {
                enamyMoveR = false;
            }
            else if (enamyMoveR == true)
            {
                enemy1.Left = enemy1.Left + 5;
            }

            if (enemy1.Left < Blok.Right && enemy1.Right > Blok.Left + enemy1.Width / 2 && enemy1.Bottom > Blok.Top)
            {
                enamyMoveL =  true;
            }
            else if (enamyMoveL == false)
            {
                enemy1.Left = enemy1.Left - 5;
            }

            // enemy1 ouch
            if (enemy1.Left <= Poppetje.Left + (Poppetje.Width / 2) && enemy1.Right >= Poppetje.Right - (Poppetje.Width / 2))
            {            
                if (!jumping && !enemy1.IsDisposed)
                {
                    lifes--;
                    lifesFrame.Text = "Lifes: " + lifes;
                }
                jumpenDammage();
            }

            // enemy1 kill
            if (enemy1.Left <= Poppetje.Left + (Poppetje.Width / 2) && enemy1.Right >= Poppetje.Right - (Poppetje.Width / 2))
            {
                
            }


            // invisable wall  left
            if (enemy1.Left < wall.Right && enemy1.Right > wall.Left + enemy1.Width / 2 && enemy1.Bottom > wall.Top)
            {
                enamyMoveR = true;
            }
            else if (enamyMoveL == true)
            {
                enemy1.Left = enemy1.Left - 5;
            }


            // GROND
            if (Jump == true)
            {
                onBlock = false;
                Poppetje.Top = Poppetje.Top - Zwaartekracht;
                Zwaartekracht--;
                
                if (jumping == false)
                {
                    onBlock = true;
                }
                
            }


            // stopt poppetje van door de bodem vallen
            if (Poppetje.Bottom >= Base.Top)
            {
                Poppetje.Top = Screen1.Height - Poppetje.Height;
            }



            // BLOK 1
            if (Blok.Left <= Poppetje.Left + (Poppetje.Width / 2) && Blok.Right >= Poppetje.Right - (Poppetje.Width / 2))
            {
                if (onBlock == true)
                {
                    Poppetje.Top = Screen1.Height - Blok.Height - Poppetje.Height + 7;
                }
            }


     
            // BLOK 2 (ventilator)
            if (Blok2.Left <= Poppetje.Left + (Poppetje.Width / 2) && Blok2.Right >= Poppetje.Right - (Poppetje.Width / 2))
            {
                onFan = true;
                Poppetje.Top = Screen1.Height - Blok2.Height - Poppetje.Height;
            }
            if (!(Blok2.Left <= Poppetje.Left + (Poppetje.Width / 2) && Blok2.Right >= Poppetje.Right - (Poppetje.Width / 2)))
            {
                onFan = false;
            }



            //Ouch
            if (Ouch.Left <= Poppetje.Left + (Poppetje.Width / 2) && Ouch.Right >= Poppetje.Right - (Poppetje.Width / 2))
            {
                if (!jumping && onLava == true)
                {
                    lifes--;
                    lifesFrame.Text = "Lifes: " + lifes;
                }

                if (onLava == false && !jumping)
                {
                    lifes--;
                    lifesFrame.Text = "Lifes: " + lifes;
                    onLava = true;
                }
                jumpen();
            }

            if (!(Ouch.Left <= Poppetje.Left + (Poppetje.Width / 2) && Ouch.Right >= Poppetje.Right - (Poppetje.Width / 2)))
            {
                onLava = false;
            }


            

            // life + 1
            if (life1.Left <= Poppetje.Left + (Poppetje.Width / 2) && life1.Right >= Poppetje.Right - (Poppetje.Width / 2))
            {
                if (onLife == false && !life1.IsDisposed)
                {
                    lifes++;
                    lifesFrame.Text = "Lifes: " + lifes;
                    life1.Dispose();
                    onLife = true;
                }
            }

            if (!(life1.Left <= Poppetje.Left + (Poppetje.Width / 2) && life1.Right >= Poppetje.Right - (Poppetje.Width / 2)))
            {
                onLife = false;
            }
        }


        //code for jumping 

        private void jumpen()
        {
            if (jumping == false)
            {
                if (onFan == false)
                {
                    Jump = true;
                    Zwaartekracht = Kracht;
                    jumping = true;
                    Thread jumpThread = new Thread(new ThreadStart(WorkThreadFunction));
                    jumpThread.Start();
                }
            }
        }

        //code for jumping Dammage from enemy
        private void jumpenDammage()
        {
            if (jumping == false)
            {
                Jump = true;
                Zwaartekracht = dammageKracht;
                jumping = true;
                Thread jumpThread = new Thread(new ThreadStart(WorkThreadFunction));
                jumpThread.Start();
            }
        }

        //keyboard binding
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                rightL = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                leftL = false;
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Poppetje.Top = Screen1.Height - Poppetje.Height;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //poppetje
        private void Poppetje_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Base_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Poppetje_Click(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                rightL = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                leftL = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                jumpen();
            }
        }

        public void Ouch_Click(object sender, System.EventArgs e)
        {

        }
        // to make the falling correct
        public void WorkThreadFunction()
        {
            System.Threading.Thread.Sleep(500);
            jumping = false;
        }

        // label That shows how many lifes the player has.
        private void label1_Create(object sender, PaintEventArgs e)
        {
            lifesFrame.Height = 40;
            lifesFrame.Width = 100;
            lifesFrame.Font = new Font("", 30);
            lifesFrame.Text = "Lifes: " + lifes;
        }

        private void Ouch_Create(object sender, PaintEventArgs e)
        {

        }

        private void label2_Create(object sender, PaintEventArgs e)
        {
         
        }

        
        private void timer2_Tick(object sender, EventArgs e)
        {
            /*
            if (restart == true)
            {
                this.Close();
            }
            */
        }
        

        private void enemy1_move(object sender, EventArgs e)
        {
        
        }

        private void Blok2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void life1_Click(object sender, EventArgs e)
        {

        }
    }

}
