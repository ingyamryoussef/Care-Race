using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace test2
{
    
    public partial class RaceInfo : Form
    {

        public  double connecting_speed;
       // public bool ex_fe = false;  // connecting extra feature (Speed Boost)
        public bool check;

        public RaceInfo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
         
         
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Classic Grass Street")
            {
                Form1 Form_1 = new Form1();
                Form_1.Location = this.Location;
                Form_1.StartPosition = FormStartPosition.Manual;
                Form_1.FormClosing += delegate { this.Show(); };
                Form_1.Show();
                this.Hide();
                Form_1.pictureBox1.Image = pictureBox9.Image;
                Form_1.boost=check;
                
                Form_1.playerspeed = connecting_speed;
               
            }
            else if (comboBox2.Text=="Ice Street")
            {
               
                IceStreet Form_i = new IceStreet();
                Form_i.Location = this.Location;
                Form_i.StartPosition = FormStartPosition.Manual;
                Form_i.FormClosing += delegate { this.Show(); };
                Form_i.Show();
                this.Hide();
                Form_i.pictureBox2.Image = pictureBox9.Image;
                Form_i.boost=check;
                Form_i.playerspeed = connecting_speed;
                
            }
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            

            PersonalInfo Form_2 = new PersonalInfo();
            Form_2.Location = this.Location;
            Form_2.StartPosition = FormStartPosition.Manual;
            Form_2.FormClosing += delegate { this.Show(); };
            Form_2.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void RaceInfo_Load(object sender, EventArgs e)
        {
         
        }


        private void FormIsClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == "Van")
            {
                //Car c1 = new Van(Form_1.comboBox1.Text, Form_1.comboBox4.Text, 6, Form_1.comboBox6.Text, 2000, Car.constantSpeed);
                if (comboBox4.SelectedItem == "Red")
                {
                    pictureBox6.Visible = true;
                    pictureBox6.BringToFront();
                    pictureBox9.Image = pictureBox6.Image;
                }
                else if (comboBox4.SelectedItem == "Blue")
                {
                    pictureBox5.Visible = true;
                    pictureBox5.BringToFront();
                    pictureBox9.Image = pictureBox5.Image;
                }


            }
            else if (comboBox3.Text == "Sports Car")
            {
                // Car c2 = new SportsCar(Form_1.comboBox1.Text, Form_1.comboBox4.Text, 2, Form_1.comboBox6.Text, "Speed boost", 3000, Car.constantSpeed);
                if (comboBox4.Text == "Red")
                {
                    pictureBox1.Visible = true;
                    pictureBox1.BringToFront();
                    pictureBox9.Image = pictureBox1.Image;
                }
                else if (comboBox4.Text == "Blue")
                {
                    pictureBox2.Visible = true;
                    pictureBox2.BringToFront();
                    pictureBox9.Image = pictureBox2.Image;
                }
            }
            else if (comboBox3.Text == "Street Car")
            {
                // Car c2 = new StreetCar(Form_1.comboBox1.Text, Form_1.comboBox4.Text, 4, Form_1.comboBox6.Text, 1000, Car.constantSpeed);
                if (comboBox4.Text == "Red")
                {
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    pictureBox9.Image = pictureBox4.Image;
                }
                else if (comboBox4.Text == "Blue")
                {
                    pictureBox3.Visible = true;
                    pictureBox3.BringToFront();
                    pictureBox9.Image = pictureBox3.Image;
                }
            }
            else if (comboBox3.Text == "Indy Car")
            {
                //Car c2 = new IndyCar(Form_1.comboBox1.Text, Form_1.comboBox4.Text, 2, Form_1.comboBox6.Text, "Speed boost", 3000, Car.constantSpeed);
                if (comboBox4.Text == "Red")
                {
                    pictureBox8.Visible = true;
                    pictureBox8.BringToFront();
                    pictureBox9.Image = pictureBox8.Image;
                }
                else if (comboBox4.Text == "Blue")
                {
                    pictureBox7.Visible = true;
                    pictureBox7.BringToFront();
                    pictureBox9.Image = pictureBox7.Image;
                }
            }
            else;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == "Van")
            {
                
                label8.Visible = false;
                Car c1 = new Van(comboBox1.Text, comboBox4.Text, 6, comboBox6.Text, 2000, Car.constantSpeed);
                check = c1.Check();
               
                if (comboBox4.SelectedItem == "Red")
                {
                    pictureBox6.Visible = true;
                    pictureBox6.BringToFront();
                    pictureBox9.Image = pictureBox6.Image;
                }
                else if (comboBox4.SelectedItem == "Blue")
                {
                    pictureBox5.Visible = true;
                    pictureBox5.BringToFront();
                    pictureBox9.Image = pictureBox5.Image;
                }

                connecting_speed = c1.calculate_speed();

            }
            else if (comboBox3.Text == "Sports Car")
            {
                label8.Visible = true;
                Car c2 = new SportsCar(comboBox1.Text, comboBox4.Text, 2, comboBox6.Text, true , 3000, Car.constantSpeed);
                check = c2.Check();
                if (comboBox4.Text == "Red")
                {
                    pictureBox1.Visible = true;
                    pictureBox1.BringToFront();
                    pictureBox9.Image = pictureBox1.Image;
                }
                else if (comboBox4.Text == "Blue")
                {
                    pictureBox2.Visible = true;
                    pictureBox2.BringToFront();
                    pictureBox9.Image = pictureBox2.Image;
                }
                connecting_speed = c2.calculate_speed();
            }
            else if (comboBox3.Text == "Street Car")
            {
                
                label8.Visible = false;
                Car c3 = new StreetCar(comboBox1.Text,comboBox4.Text, 4,comboBox6.Text, 1000, Car.constantSpeed);
                check = c3.Check();
                if (comboBox4.Text == "Red")
                {
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    pictureBox9.Image = pictureBox4.Image;
                }
                else if (comboBox4.Text == "Blue")
                {
                    pictureBox3.Visible = true;
                    pictureBox3.BringToFront();
                    pictureBox9.Image = pictureBox3.Image;
                }
                connecting_speed = c3.calculate_speed();
            }
            else if (comboBox3.Text == "Indy Car")
            {
                label8.Visible = true;
                Car c4 = new IndyCar(comboBox1.Text, comboBox4.Text, 2,comboBox6.Text, true , 3000, Car.constantSpeed);
                check = c4.Check();
                if (comboBox4.Text == "Red")
                {
                    pictureBox8.Visible = true;
                    pictureBox8.BringToFront();
                    pictureBox9.Image = pictureBox8.Image;
                }
                else if (comboBox4.Text == "Blue")
                {
                    pictureBox7.Visible = true;
                    pictureBox7.BringToFront();
                    pictureBox9.Image = pictureBox7.Image;
                }
                connecting_speed = c4.calculate_speed();
                
            }
            else;
        }
        
        
    }
}
