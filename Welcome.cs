using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
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

        private void FormIsClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
