using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*name=Preet Manandhar
 This from is for calculations 
i have used class and methods for calculations with private fields, constructor, properties and methods 

i tried my best to display result but i couldnot get the result as expected.
*/
namespace frmDashboard
{
    public partial class Calculator : Form

    {
        Class calc = new Class();
        public Calculator()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }
           private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = ".";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            // Set the start time to the current time
            startTime = DateTime.Now;
        }
        

        
        
        private void button14_Click(object sender, EventArgs e)
        {
            calc.Subtract(textBox1.Text);
            textBox1.Text = "";
        }

        private void MultiBtn_Click(object sender, EventArgs e)
        {
            calc.Multiply(textBox1.Text);
            textBox1.Text = "";
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            calc.Divide(textBox1.Text);
            textBox1.Text = "";
        }
        
        string path= @".\Calculator.txt";
        private void button17_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = calc.Equals(textBox1.Text);


            FileStream fs1 = null;
            try
            {
                string textin = textBox1.Text.Trim();
               fs1 = new FileStream(path, FileMode.Append, FileAccess.Write);
              StreamWriter textOut = new StreamWriter(fs1);
                textOut.WriteLine( calc.CurrentValue  +" " + calc.Op + " " + calc.Operand2 + " = "+ calc.Operand1 );
               
                textOut.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "IO Exception"); }
            finally { if (fs1 != null) fs1.Close(); }
        }
        private DateTime startTime;
        private DateTime endTime;
        private void button18_Click(object sender, EventArgs e)
            {
            if (MessageBox.Show("Do you want to quit this calculator?", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
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



        //clear botton
        private void button12_Click(object sender, EventArgs e)
        {
            calc.Clear();
            textBox1.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            calc.Add(textBox1.Text);

            textBox1.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


