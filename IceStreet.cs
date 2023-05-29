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
    public partial class IceStreet : Form
    {
        bool goleft;
        bool goright;
        bool isstop = false;
        public double playerspeed=20;
        public bool boost;
        public IceStreet()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        
        
        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pictureBox2.Left <= pictureBox1.Left + 150) pictureBox2.Left = pictureBox1.Left + 150;
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (pictureBox2.Left >= pictureBox1.Left + 305) pictureBox2.Left = pictureBox1.Left + 305;
                goright = true;

            }
            
            if (e.KeyCode == Keys.Escape && isstop == false) { timer1.Stop(); isstop = true; button1.Visible = true; }
            else if (e.KeyCode == Keys.Escape && isstop == true) { timer1.Start(); isstop = false; button1.Visible = false; }
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
            if (goleft)
            {
                pictureBox2.Left -= 5;
            }

            if (goright)
            {
                pictureBox2.Left += 5;
            }
            pictureBox1.Top += Convert.ToInt32(Math.Floor(playerspeed));
            pictureBox4.Top += Convert.ToInt32(Math.Floor(playerspeed));
            pictureBox5.Top += Convert.ToInt32(Math.Floor(playerspeed));
            pictureBox6.Top += Convert.ToInt32(Math.Floor(playerspeed));
            pictureBox7.Top += Convert.ToInt32(Math.Floor(playerspeed));
            pictureBox8.Top += Convert.ToInt32(Math.Floor(playerspeed));
            pictureBox9.Top += Convert.ToInt32(Math.Floor(playerspeed));
            pictureBox10.Top += Convert.ToInt32(Math.Floor(playerspeed));
            pictureBox11.Top += Convert.ToInt32(Math.Floor(playerspeed));

            if (pictureBox5.Top + 122 >= pictureBox2.Top) { 
                timer1.Stop();
                isstop = true;
                button1.Visible = true;
                if (pictureBox2.Top < pictureBox3.Top) label1.Visible = true;
                else if (pictureBox2.Top > pictureBox3.Top) label2.Visible = true;
                else if (pictureBox2.Top == pictureBox3.Top) label3.Visible = true;
            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox6.Bounds) || pictureBox2.Bounds.IntersectsWith(pictureBox7.Bounds) || pictureBox2.Bounds.IntersectsWith(pictureBox8.Bounds) || pictureBox2.Bounds.IntersectsWith(pictureBox9.Bounds) || pictureBox2.Bounds.IntersectsWith(pictureBox10.Bounds) || pictureBox2.Bounds.IntersectsWith(pictureBox11.Bounds))
            {
                playerspeed = playerspeed-1;
                pictureBox3.Top -= 2;
                Thread.Sleep(100);
                playerspeed = playerspeed+1;
                pictureBox3.Top -= 0;
            }
            if (pictureBox4.Top >= -3000 && boost == true)
            {
                playerspeed = playerspeed + 1;
                pictureBox3.Top += 5;
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void FormIsClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RaceInfo Form_1 = new RaceInfo();
            Form_1.Location = this.Location;
            Form_1.StartPosition = FormStartPosition.Manual;
            Form_1.FormClosing += delegate { this.Show(); };
            Form_1.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void FormIsClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void KeyisPressed(object sender, KeyPressEventArgs e)
        {
            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
    
        }
    }
}
