using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_3._12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime orario = DateTime.Now;
            int hour = (int)orario.Hour;
            int minutes = (int)orario.Minute;
            int seconds = (int)orario.Second;
            if (hour == 0)
            {
                pictureBox1.Image = Image.FromFile("0.png");
                pictureBox2.Image = Image.FromFile("0.png");
            }
            else if (hour == 1)
            {
                pictureBox1.Image = Image.FromFile("0.png");
                pictureBox2.Image = Image.FromFile("1.png");
            }
            else if (hour == 2)
            {
                pictureBox1.Image = Image.FromFile("0.png");
                pictureBox2.Image = Image.FromFile("2.png");
            }
            else if (hour == 3)
            {
                pictureBox1.Image = Image.FromFile("0.png");
                pictureBox2.Image = Image.FromFile("3.png");
            }
            else if (hour == 4)
            {
                pictureBox1.Image = Image.FromFile("0.png");
                pictureBox2.Image = Image.FromFile("4.png");
            }
            else if (hour == 5)
            {
                pictureBox1.Image = Image.FromFile("0.png");
                pictureBox2.Image = Image.FromFile("5.png");
            }
            else if (hour == 6)
            {
                pictureBox1.Image = Image.FromFile("0.png");
                pictureBox2.Image = Image.FromFile("6.png");
            }
            else if (hour == 7)
            {
                pictureBox1.Image = Image.FromFile("0.png");
                pictureBox2.Image = Image.FromFile("7.png");
            }
            else if (hour == 8)
            {
                pictureBox1.Image = Image.FromFile("0.png");
                pictureBox2.Image = Image.FromFile("8.png");
            }
            else if (hour == 9)
            {
                pictureBox1.Image = Image.FromFile("0.png");
                pictureBox2.Image = Image.FromFile("9.png");
            }
            else if (hour == 10)
            {
                pictureBox1.Image = Image.FromFile("1.png");
                pictureBox2.Image = Image.FromFile("0.png");
            }
            else if (hour == 11)
            {
                pictureBox1.Image = Image.FromFile("1.png");
                pictureBox2.Image = Image.FromFile("1.png");
            }
            else if (hour == 12)
            {
                pictureBox1.Image = Image.FromFile("1.png");
                pictureBox2.Image = Image.FromFile("2.png");
            }
            else if (hour == 13)
            {
                pictureBox1.Image = Image.FromFile("1.png");
                pictureBox2.Image = Image.FromFile("3.png");
            }
            else if (hour == 14)
            {
                pictureBox1.Image = Image.FromFile("1.png");
                pictureBox2.Image = Image.FromFile("4.png");
            }
            else if (hour == 15)
            {
                pictureBox1.Image = Image.FromFile("1.png");
                pictureBox2.Image = Image.FromFile("5.png");
            }
            else if (hour == 16)
            {
                pictureBox1.Image = Image.FromFile("1.png");
                pictureBox2.Image = Image.FromFile("6.png");
            }
            else if (hour == 17)
            {
                pictureBox1.Image = Image.FromFile("1.png");
                pictureBox2.Image = Image.FromFile("7.png");
            }
            else if (hour == 18)
            {
                pictureBox1.Image = Image.FromFile("1.png");
                pictureBox2.Image = Image.FromFile("8.png");
            }
            else if (hour == 19)
            {
                pictureBox1.Image = Image.FromFile("1.png");
                pictureBox2.Image = Image.FromFile("9.png");
            }
            else if (hour == 20)
            {
                pictureBox1.Image = Image.FromFile("2.png");
                pictureBox2.Image = Image.FromFile("0.png");
            }
            else if (hour == 21)
            {
                pictureBox1.Image = Image.FromFile("2.png");
                pictureBox2.Image = Image.FromFile("1.png");
            }
            else if (hour == 22)
            {
                pictureBox1.Image = Image.FromFile("2.png");
                pictureBox2.Image = Image.FromFile("2.png");
            }
            else if (hour == 23)
            {
                pictureBox1.Image = Image.FromFile("2.png");
                pictureBox2.Image = Image.FromFile("3.png");
            }

            if (minutes < 10)
            {
                pictureBox3.Image = Image.FromFile("0.png"); 
            }
            else if (minutes < 20)
            {
                pictureBox3.Image = Image.FromFile("1.png");
                minutes -= 10;
            }
            else if (minutes < 30)
            {
                pictureBox3.Image = Image.FromFile("2.png");
                minutes -= 20;
            }
            else if (minutes < 40)
            {
                pictureBox3.Image = Image.FromFile("3.png");
                minutes -= 30;
            }
            else if (minutes < 50)
            {
                pictureBox3.Image = Image.FromFile("4.png");
                minutes -= 40;
            }
            else
            {
                pictureBox3.Image = Image.FromFile("5.png");
                minutes -= 50;
            }

            if (minutes == 0)
            {
                pictureBox4.Image = Image.FromFile("0.png");
            }
            else if (minutes == 1)
            {
                pictureBox4.Image = Image.FromFile("1.png");
            }
            else if (minutes == 2)
            {
                pictureBox4.Image = Image.FromFile("2.png");
            }
            else if (minutes == 3)
            {
                pictureBox4.Image = Image.FromFile("3.png");
            }
            else if (minutes == 4)
            {
                pictureBox4.Image = Image.FromFile("4.png");
            }
            else if (minutes == 5)
            {
                pictureBox4.Image = Image.FromFile("5.png");
            }
            else if (minutes == 6)
            {
                pictureBox4.Image = Image.FromFile("6.png");
            }
            else if (minutes == 7)
            {
                pictureBox4.Image = Image.FromFile("7.png");
            }
            else if (minutes == 8)
            {
                pictureBox4.Image = Image.FromFile("8.png");
            }
            else if (minutes == 9)
            {
                pictureBox4.Image = Image.FromFile("9.png");
            }

            if (seconds < 10)
            {
                pictureBox5.Image = Image.FromFile("0.png");
            }
            else if (seconds < 20)
            {
                pictureBox5.Image = Image.FromFile("1.png");
                seconds -= 10;
            }
            else if (seconds < 30)
            {
                pictureBox5.Image = Image.FromFile("2.png");
                seconds -= 20;
            }
            else if (seconds < 40)
            {
                pictureBox5.Image = Image.FromFile("3.png");
                seconds -= 30;
            }
            else if (seconds < 50)
            {
                pictureBox5.Image = Image.FromFile("4.png");
                seconds -= 40;
            }
            else
            {
                pictureBox5.Image = Image.FromFile("5.png");
                seconds -= 50;
            }

            if (seconds == 0)
            {
                pictureBox6.Image = Image.FromFile("0.png");
            }
            else if (seconds == 1)
            {
                pictureBox6.Image = Image.FromFile("1.png");
            }
            else if (seconds == 2)
            {
                pictureBox6.Image = Image.FromFile("2.png");
            }
            else if (seconds == 3)
            {
                pictureBox6.Image = Image.FromFile("3.png");
            }
            else if (seconds == 4)
            {
                pictureBox6.Image = Image.FromFile("4.png");
            }
            else if (seconds == 5)
            {
                pictureBox6.Image = Image.FromFile("5.png");
            }
            else if (seconds == 6)
            {
                pictureBox6.Image = Image.FromFile("6.png");
            }
            else if (seconds == 7)
            {
                pictureBox6.Image = Image.FromFile("7.png");
            }
            else if (seconds == 8)
            {
                pictureBox6.Image = Image.FromFile("8.png");
            }
            else if (seconds == 9)
            {
                pictureBox6.Image = Image.FromFile("9.png");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
