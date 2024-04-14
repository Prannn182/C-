﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }
        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

            if (pictureBox5.Top >= 500)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }
        }
        int collectedcoin=0;
           void coins(int speed)
        {

            if (coin1.Top >= 500)
            {
                x=r.Next(0, 200);
               
               coin1.Location = new Point(x, 0);
               }
            else
            {
                coin1.Top += speed;
            }

            if (coin2.Top >= 500)
            {
                x = r.Next(0, 200);

                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }

            if (coin3.Top >= 500)
            {
                x = r.Next(50, 300);

                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }

            if (coin4.Top >= 500)
            {
                x = r.Next(0,400);

                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }
        
        }
           void coinsCollection()
           {
               if (car.Bounds.IntersectsWith(coin1.Bounds))
               {
                   collectedcoin++;
                   label1.Text = "Coins:" + collectedcoin.ToString();
                   x = r.Next(0, 400);

                   coin1.Location = new Point(x, 0);
               }

               if (car.Bounds.IntersectsWith(coin2.Bounds))
               {
                   collectedcoin++;
                   label1.Text = "Coins:" + collectedcoin.ToString();
                   x = r.Next(0, 400);

                   coin2.Location = new Point(x, 0);
               }

               if (car.Bounds.IntersectsWith(coin3.Bounds))
               {
                   collectedcoin++;
                   label1.Text = "Coins:" + collectedcoin.ToString();
                   x = r.Next(0, 400);

                   coin3.Location = new Point(x, 0);
               }

               if (car.Bounds.IntersectsWith(coin4.Bounds))
               {
                   collectedcoin++;
                   label1.Text = "Coins:" + collectedcoin.ToString();
                   x = r.Next(0, 400);

                   coin4.Location = new Point(x, 0);
               }
        
           
           }
        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {

            if (enemy1.Top >= 500)
            {
                x=r.Next(0, 200);
               
                enemy1.Location = new Point(x, 0);
               }
            else
            {
                enemy1.Top += speed;
            }
            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 400);

                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }
            if (enemy3.Top >= 500)
            {
                x = r.Next(200, 350);

                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }
        
        }
        void gameover()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            coinsCollection();
        }
        int gamespeed = 0;
        private void Form1_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if(car.Left>0)
                car.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if(car.Right<380)
                car.Left += 8;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                { 
                    gamespeed++;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0) 
                { 
                    gamespeed--;
                }
            }
        }
    }
}
