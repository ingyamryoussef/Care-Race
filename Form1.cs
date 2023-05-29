using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace test2
{
    public partial class Form1 : Form
    {
        bool goleft;
        bool goright; 
        bool isstop=false;
        public double playerspeed=20;
        public bool boost;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pictureBox1.Left <= pictureBox3.Left + 150) pictureBox1.Left = pictureBox3.Left + 150;
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (pictureBox1.Left >= pictureBox3.Left + 305) pictureBox1.Left = pictureBox3.Left + 305;
                goright = true;                

            }
            if (e.KeyCode == Keys.Escape && isstop==false) { timer1.Stop(); isstop = true; button1.Visible = true; }
            else if(e.KeyCode == Keys.Escape && isstop == true) { timer1.Start(); isstop = false; button1.Visible = false; }
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
                
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;                

            }
        }
        
        private void MainGameTimer(object sender, EventArgs e)
        {
            
            pictureBox3.Top += Convert.ToInt32(Math.Floor(playerspeed));
            pictureBox4.Top += Convert.ToInt32(Math.Floor(playerspeed));
            pictureBox5.Top += Convert.ToInt32(Math.Floor(playerspeed));
            pictureBox6.Top += Convert.ToInt32(Math.Floor(playerspeed));
            pictureBox45.Top += Convert.ToInt32(Math.Floor(playerspeed));
            pictureBox46.Top += Convert.ToInt32(Math.Floor(playerspeed));
            pictureBox47.Top += Convert.ToInt32(Math.Floor(playerspeed));
            pictureBox48.Top += Convert.ToInt32(Math.Floor(playerspeed));
            pictureBox49.Top += Convert.ToInt32(Math.Floor(playerspeed));

            if (goleft)
            {
                pictureBox1.Left -= 5;            //location (x,y)   ---> (Left,Top)
            }

            if (goright)
            {
                pictureBox1.Left += 5;
            }



            if (pictureBox5.Top + 122 >= pictureBox1.Top) 
            {
                timer1.Stop();
                isstop = true;
                button1.Visible = true;
                if (pictureBox1.Top < pictureBox2.Top) label1.Visible = true;
                else if (pictureBox1.Top > pictureBox2.Top) label2.Visible = true;
                else if (pictureBox1.Top == pictureBox2.Top) label3.Visible = true;
            }

            if (pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds) || pictureBox1.Bounds.IntersectsWith(pictureBox45.Bounds) || pictureBox1.Bounds.IntersectsWith(pictureBox46.Bounds) || pictureBox1.Bounds.IntersectsWith(pictureBox47.Bounds) || pictureBox1.Bounds.IntersectsWith(pictureBox48.Bounds) || pictureBox1.Bounds.IntersectsWith(pictureBox49.Bounds))
            {
                playerspeed = playerspeed - 1;
                pictureBox2.Top -= 2;
                Thread.Sleep(100);
                playerspeed = playerspeed + 1;
                pictureBox2.Top -= 0;
            }
            if ((pictureBox4.Top >= -3000) && boost == true)
            {
                playerspeed = playerspeed + 1;
                pictureBox2.Top += 5;
            }

            // top increases when we go up

            // pb5 is the endline, pb1 is my car , 122 is the hight of the end line

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            RaceInfo Form_1 = new RaceInfo();
            Form_1.Location = this.Location;
            Form_1.StartPosition = FormStartPosition.Manual;
            Form_1.FormClosing += delegate { this.Show(); };
            Form_1.Show();
            this.Hide();
        }

        private void FormIsClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void KeyisPressed(object sender, KeyPressEventArgs e)
        {
        }
    }
}
