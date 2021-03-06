﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewMovingPicture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 4, pictureBox1.Location.Y);
                await Task.Delay(50);
            }
            for (int i = 0; i < 20; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 4);
                await Task.Delay(50);
            }
            for (int i = 0; i < 20; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 4, pictureBox1.Location.Y);
                await Task.Delay(50);
            }
            for (int i = 0; i < 20; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 4);
                await Task.Delay(50);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 80; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y - 1);
                await Task.Delay(12);
            }
            for (int i = 0; i < 80; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y + 1);
                await Task.Delay(12);
            }
            for (int i = 0; i < 150; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);
                await Task.Delay(12);
            }
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            while (pictureBox1.Location.X + 5 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
                await Task.Delay(100);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            int d;
            try
            {
                d = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Don't be a fool please insert a number. For example 100.");
                d = 10;
            }
            for (int i = 0; i < 5; i++)
            {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y - 10);
                    await Task.Delay(d);
            }
        
        }
           
    }
}
