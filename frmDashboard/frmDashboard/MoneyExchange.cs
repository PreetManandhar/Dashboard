using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
/*name= Preet Manandhar
 this form is for money exchange . it has radio buttons for choices and is used to convert currency from one to another.
textbox on left is to enter the currency and text box on right is readonly to get desired currency
this form also has read file .i used switch cases for radio button options
regular expression is used for currency 
while closing form it displays time of duration that this form was loaded for.*/
namespace frmDashboard
{
    public partial class MoneyExchange : Form
    {
        private string from;
        private string to;
        private double money;
        public string From
        {
            get { return from; }
            set { from = value; }
        }
        public string To
        {
            get { return to; }
            set { to = value; }
        }
        public MoneyExchange()
        {
            InitializeComponent();
        }
        public MoneyExchange(double money)
        {
            this.money = money;
        }

        public double MoneyGetSet
        {
            get { return money; }
            set { money = value; }
        }


        public double CADToCAD(double money)
        {
            return money;
        }

        public double CADToUSD(double money)
        {
            return money * 0.74;
        }

        public double CADToEUR(double money)
        {
            return money * 0.68;
        }

        public double CADToGBP(double money)
        {
            return money * 0.60;
        }

        public double CADToNPR(double money)
        {
            return money * 98.96;
        }

        public double USDToCAD(double money)
        {
            return money * 1.35;
        }

        public double USDToUSD(double money)
        {
            return money;
        }

        public double USDToEUR(double money)
        {
            return money * 0.92;
        }

        public double USDToGBP(double money)
        {
            return money * 0.80;
        }

        public double USDToNPR(double money)
        {
            return money * 100;
        }

        public double EURToCAD(double money)
        {
            return money * 1.47;
        }

        public double EURToUSD(double money)
        {
            return money * 1.09;
        }

        public double EURToEUR(double money)
        {
            return money;
        }

        public double EURToGBP(double money)
        {
            return money * 0.88;
        }

        public double EURToNPR(double money)
        {
            return money * 144.10;
        }

        public double GBPToCAD(double money)
        {
            return money * 1.68;
        }

        public double GBPToUSD(double money)
        {
            return money * 1.24;
        }

        public double GBPToEUR(double money)
        {
            return money * 1.14;
        }

        public double GBPToGBP(double money)
        {
            return money;
        }

        public double GBPToNPR(double money)
        {
            return money * 163.17;
        }

        public double NPRToCAD(double money)
        {
            return money * 0.010;
        }

        public double NPRToUSD(double money)
        {
            return money * 0.0076;
        }

        public double NPRToEUR(double money)
        {
            return money * 0.0069;
        }

        public double NPRToGBP(double money)
        {
            return money * 0.0061;
        }

        public double NPRToNPR(double money)
        {
            return money;
        }

        string path = @".\MoneyExchange.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            double input;
            try
            {
                input = Convert.ToDouble(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }
            
            double fromVal, toVal;
            
            if (cadfrom.Checked == true && cadto.Checked == true)
            {
                //fromVal = input;
                toVal = CADToCAD(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "CAD";
                to = "CAD";
                //mx.Write(fromVal, toVal, from, to);
            }
            else if (cadfrom.Checked == true && usdto.Checked == true)
            {
                fromVal = input;
                toVal = CADToUSD(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "CAD";
                to = "USD";
                // mx.Write(fromVal, toVal, from, to);
            }
            else if (cadfrom.Checked == true && eurto.Checked == true)
            {
                fromVal = input;
                toVal = CADToEUR(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "CAD";
                to = "EUR";
                //mx.Write(fromVal, toVal, from, to);
            }
            else if (cadfrom.Checked == true && gbpto.Checked == true)
            {
                fromVal = input;
                toVal = CADToGBP(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "CAD";
                to = "GBP";
                //mx.Write(fromVal, toVal, from, to);
            }
            else if (cadfrom.Checked == true && nprto.Checked == true)
            {
                fromVal = input;
                toVal = CADToNPR(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "CAD";
                to = "NPR";
                //mx.Write(fromVal, toVal, from, to);
            }
            else if (usdfrom.Checked == true && cadto.Checked == true)
            {
                fromVal = input;
                toVal = USDToCAD(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "USD";
                to = "CAD";
                //mx.Write(fromVal, toVal, from, to);
            }
            else if (usdfrom.Checked == true && usdto.Checked == true)
            {
                fromVal = input;
                toVal = USDToUSD(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "USD";
                to = "USD";
                //mx.Write(fromVal, toVal, from, to);
            }
            else if (usdfrom.Checked == true && eurto.Checked == true)
            {
                fromVal = input;
                toVal = USDToEUR(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "USD";
                to = "EUR";
                //mx.Write(fromVal, toVal, from, to);
            }
            else if (usdfrom.Checked == true && gbpto.Checked == true)
            {
                fromVal = input;
                toVal = USDToGBP(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "USD";
                to = "GBP";
                // mx.Write(fromVal, toVal, from, to);
            }
            else if (usdfrom.Checked == true && nprto.Checked == true)
            {
                fromVal = input;
                toVal = USDToNPR(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "USD";
                to = "NPR";
                //mx.Write(fromVal, toVal, from, to);
            }
            else if (eurfrom.Checked == true && cadto.Checked == true)
            {
                fromVal = input;
                toVal = EURToCAD(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "EUR";
                to = "CAD";
                // mx.Write(fromVal, toVal, from, to);
            }
            else if (eurfrom.Checked == true && usdto.Checked == true)
            {
                fromVal = input;
                toVal = EURToUSD(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "EUR";
                to = "USD";
                //mx.Write(fromVal, toVal, from, to);
            }
            else if (eurfrom.Checked == true && eurto.Checked == true)
            {
                fromVal = input;
                toVal = EURToEUR(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "EUR";
                to = "EUR";
                //mx.Write(fromVal, toVal, from, to);
            }
            else if (eurfrom.Checked == true && gbpto.Checked == true)
            {
                fromVal = input;
                toVal = EURToGBP(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "EUR";
                to = "GBP";
                //mx.Write(fromVal, toVal, from, to);
            }
            else if (eurfrom.Checked == true && nprto.Checked == true)
            {
                fromVal = input;
                toVal = EURToNPR(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "EUR";
                to = "IND";
                //mx.Write(fromVal, toVal, from, to);
            }
            else if (gbpfrom.Checked == true && cadto.Checked == true)
            {
                fromVal = input;
                toVal = GBPToCAD(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "GBP";
                to = "CAD";
                // mx.Write(fromVal, toVal, from, to);
            }
            else if (gbpfrom.Checked == true && usdto.Checked == true)
            {
                fromVal = input;
                toVal = GBPToUSD(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "GBP";
                to = "USD";
                // mx.Write(fromVal, toVal, from, to);
            }
            else if (gbpfrom.Checked == true && eurto.Checked == true)
            {
                fromVal = input;
                toVal = GBPToEUR(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "GBP";
                to = "EUR";
                // mx.Write(fromVal, toVal, from, to);
            }
            else if (gbpfrom.Checked == true && gbpto.Checked == true)
            {
                fromVal = input;
                toVal = GBPToGBP(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "GBP";
                to = "GBP";
                // mx.Write(fromVal, toVal, from, to);
            }
            else if (gbpfrom.Checked == true && nprto.Checked == true)
            {
                fromVal = input;
                toVal = GBPToNPR(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "GBP";
                to = "NPR";
                // mx.Write(fromVal, toVal, from, to);
            }
            else if (nprfrom.Checked == true && cadto.Checked == true)
            {
                fromVal = input;
                toVal = NPRToCAD(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "NPR";
                to = "CAD";
                // mx.Write(fromVal, toVal, from, to);
            }
            else if (nprfrom.Checked == true && usdto.Checked == true)
            {
                fromVal = input;
                toVal = NPRToUSD(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "NPR";
                to = "USD";
                //mx.Write(fromVal, toVal, from, to);
            }
            else if (nprfrom.Checked == true && eurto.Checked == true)
            {
                fromVal = input;
                toVal = NPRToCAD(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "NPR";
                to = "EUR";
                // mx.Write(fromVal, toVal, from, to);
            }
            else if (nprfrom.Checked == true && gbpto.Checked == true)
            {
                fromVal = input;
                toVal = NPRToGBP(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "NPR";
                to = "GBP";
                //mx.Write(fromVal, toVal, from, to);
            }
            else if (nprfrom.Checked == true && nprto.Checked == true)
            {
                fromVal = input;
                toVal = NPRToNPR(input);
                textBox2.Text = Convert.ToString(toVal);
                from = "NPR";
                to = "NPR";
            }
               
            FileStream fs1 = null;
            try
            {
                
                fs1 = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs1);
               
                //textOut.Write(textBox1.Text +  " = " + textBox2.Text + ", " + DateTime.Now );
                // textOut.Write($"{textBox1.Text} , {from} ," = " + textBox2.Text + ", " + DateTime.Now);
                //textOut.WriteLine(textBox1.Text + from + " = " + textBox2.Text + to + ", " + DateTime.Now);
                textOut.WriteLine(textBox1.Text + " " + From + " = " + textBox2.Text + " " + To + ", " + DateTime.Now);
                textOut.Close();
                
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(path + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs1 != null) fs1.Close(); }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader f2 = new StreamReader(@".\MoneyExchange.txt"))
                {
                    string contents = f2.ReadToEnd();
                    if (contents != null && contents.Trim() != "")
                    {
                        MessageBox.Show(contents, "Money Exchange - Preet", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("The Textfile is empty.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
            textBox1.Clear();
            textBox2.Clear();
        }
        private DateTime startTime;
        private DateTime endTime;

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application Money Exchange?", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
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

        private void MoneyExchange_Load(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
        }
    }





}

