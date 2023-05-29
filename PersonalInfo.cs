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
using System.Configuration;
using System.Data.SqlClient;
namespace test2
{ 
    public partial class PersonalInfo : Form
       
    {
        //SqlConnection connection;
        //string connectionString;


        //private void personconnecting()
        //{
        //    string query = "INSERT INTO person VALUES(@Name, @Age, @Job, @ExpiryLicense, @RacesEntered, @RacesWon, @Ranking, @Budget, @Skills)"; 
        //    using (connection = new SqlConnection(connectionString))
        //   // using (SqlDataAdapter adapter = new SqlDataAdapter("select * from person", connection))
        //    using (SqlCommand personcommand = new SqlCommand(query, connection))
        //    {

        //        connection.Open();
        //     //   DataTable persontable = new DataTable();
        //        personcommand.CommandType = CommandType.StoredProcedure;
        //        personcommand.Parameters.AddWithValue("@Name", textBox1.Text);
        //        personcommand.Parameters.AddWithValue("@Age", Convert.ToInt32(textBox8.Text) );
        //        personcommand.Parameters.AddWithValue("@Job", textBox3.Text);
        //        personcommand.Parameters.AddWithValue("@ExpiryLicense", dateTimePicker1.Value);
        //        personcommand.Parameters.AddWithValue("@RacesEntered",Convert.ToInt32(textBox5.Text));
        //        personcommand.Parameters.AddWithValue("@RacesWon", Convert.ToInt32(textBox6.Text));
        //        personcommand.Parameters.AddWithValue("@Ranking", Convert.ToInt32(textBox2.Text));
        //        personcommand.Parameters.AddWithValue("@Budget", 300);
        //        personcommand.Parameters.AddWithValue("@Skills",textBox2.Text);
                
        //        personcommand.ExecuteNonQuery();
        //        personcommand.ExecuteScalar();
        //        connection.Close();

        //    }
        //}
        public PersonalInfo()
        {
            InitializeComponent();
            //connectionString = ConfigurationManager.ConnectionStrings["test2.Properties.Settings.historyofraceConnectionString"].ConnectionString;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p1 = new Person(textBox1.Text, Convert.ToInt32(textBox8.Text), textBox3.Text, dateTimePicker1.Value, 30, Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox2.Text), textBox7.Text);
            Race r1 = new Race(textBox1.Text, Convert.ToInt32(textBox8.Text), textBox3.Text, dateTimePicker1.Value, 30, Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox2.Text), textBox7.Text, DateTime.Now);
            if (r1.expirylicense() == false || p1.age_validation() == false || p1.racesenterd_validation() == false || p1.raceswon_validation() == false || p1.ranking_validation() == false) label9.Visible = true;

            else
            {
                RaceInfo Form_1 = new RaceInfo();
                Form_1.Location = this.Location;
                Form_1.StartPosition = FormStartPosition.Manual;
                Form_1.FormClosing += delegate { this.Show(); };
                Form_1.Show();
                this.Hide();
            }
           // personconnecting();
        }

        private void PersonalInfo_Load(object sender, EventArgs e)
        {

        }

        private void FormIsClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
