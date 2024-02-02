using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
/*NAME = Preet Manandhar
 This form is about validtation of ip addresss that should be between 0 to 255
i have used regex for ip address
the button reset resets the io address and close form with display of load of time this form took*/
namespace frmDashboard
{
    public partial class Ip4Validator : Form
    {
        public Ip4Validator()
        {
            InitializeComponent();
        }
        string pathBinary = @".\Ip4Binary.txt";
        private DateTime startTime;
        private DateTime endTime;
        private void validate_botton_Click(object sender, EventArgs e)
        {
           
            string ip = textbox.Text.Trim();

           
           Regex address = new Regex(@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");  //regex for integer between 0 to 255 
           if(address.IsMatch(ip)== true)
            {
                try
                {
                    FileStream fs = new FileStream(pathBinary, FileMode.Append, FileAccess.Write);
                    // create the output stream for a binary file that exists
                    BinaryWriter binaryOut = new BinaryWriter(fs);

                    // write the fields into text file
                    binaryOut.Write(ip);
                    binaryOut.Write(DateTime.Now.ToLongDateString());

                    // close the output stream for the text file
                    binaryOut.Close();

                    MessageBox.Show(textbox.Text + "\nThe IP address is correct", "Valid IP");
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
               
            }
            else
            {
                MessageBox.Show(textbox.Text + "\nThe IP must have 4 bytes \n Integer number between 0 to 255 \n Separated by a dot (255.255.255.255)","Error" );
            }

        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            //this resets the entered data in textbox with empty string
            textbox.Text = "";
        }

        private void exit_botton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application IP Validator?", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                // Set the end time to the current time
                endTime = DateTime.Now;

                // Calculate the time difference in seconds and minutes
                TimeSpan timeDiff = endTime - startTime;
                int seconds = (int)timeDiff.TotalSeconds;
                int minutes = (int)timeDiff.TotalMinutes;

                // Display the time on the form using a MessageBox
                
                MessageBox.Show($"Time spent on form: {minutes} minutes ({seconds} seconds )");

                this.Close();
            }
        }

        private void Ip4Validator_Load(object sender, EventArgs e)
        {
            // Set the start time to the current time
            startTime = DateTime.Now;

            label2.Text = " " + DateTime.Now.ToString("dd,-MM-yy");
        }
    }
}
