using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDashboard
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMax obj = new frmMax();
            //obj.Show();
            obj.ShowDialog();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Lotto649 obj = new Lotto649();
            obj.Show();

        }
        private DateTime startTime;
        private DateTime endTime;
        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application ?", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                // Set the end time to the current time
                endTime = DateTime.Now;

                // Calculate the time difference in seconds and minutes
                TimeSpan timeDiff = endTime - startTime;
                int seconds = (int)timeDiff.TotalSeconds;
                int minutes = (int)timeDiff.TotalMinutes;

                // Display the time on the form using a MessageBox

                MessageBox.Show($"Time spent on form: {minutes} minutes ({seconds} seconds )");

                Application.Exit();
            }
            Application.Exit();
            
        }

       
        //temperature
       

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Ip4Validator obj = new Ip4Validator();
            obj.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Calculator obj = new Calculator();
            obj.Show();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            MoneyExchange obj = new MoneyExchange();
            obj.Show();

        }
        //temperature
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            TemperatureConversion obj = new TemperatureConversion();
            obj.Show();
        }
    }
}
