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
/*name= Preet Manandhar
 this form is about temperature conversion form celsius to farenheit and farenheit to celsius
i have used 3 bottons that are to convert read and right respectively
right side text box is read inly and i have used colors to display message */
namespace frmDashboard
{
    public partial class TemperatureConversion : Form
    {
        public TemperatureConversion()
        {
            InitializeComponent();
        }

        // string path = @"\.TempConversions.txt"; //path of text file





        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader f2 = new StreamReader(@".\TempConversions.txt"))
                {
                    string contents = f2.ReadToEnd();
                    if (contents != null && contents.Trim() != "")
                    {
                        MessageBox.Show(contents, "Temperature Conversion - Preet", MessageBoxButtons.OK);
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
            finally
            {
                // Clear the text boxes inside the finally block to ensure they are cleared regardless of the outcome
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private DateTime startTime;
        private DateTime endTime;
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application Temperature conversion?", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
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
            this.Close();
        }
        string path = @".\TempConversions.txt";


       
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            label2.Text = "°C";
            label4.Text = "°F";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "°F";
            label4.Text = "°C";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TemperatureConversion_Load(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            try
            {
                decimal TempC;
                decimal TempF;
                Regex codeRegex = new Regex(@"^-?\d*\.?\d*$");
                string temp = textBox1.Text.Trim();

                if (!codeRegex.IsMatch(temp))
                {
                    MessageBox.Show("Please enter a decimal number.");
                    textBox1.Clear();
                    textBox2.Clear();
                }

                else if (codeRegex.IsMatch(temp))
                {
                    decimal input = decimal.Parse(textBox1.Text.Trim());


                    if (radioButton1.Checked) // celsius to farenheit
                    {

                        TempC = input;
                        TempF = (TempC * 9 / 5) + 32;
                        TempF = Decimal.Round(TempF, 1);
                        textBox2.Text = TempF.ToString();

                        switch (textBox2.Text)
                        {
                            case "-40":
                                textBox2.ForeColor = Color.Purple;
                                textBox3.ForeColor = Color.Purple;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Extremely Cold Day\r\n (and the same number!)";
                                break;
                            case "0":
                                textBox2.ForeColor = Color.Blue;
                                textBox3.ForeColor = Color.Blue;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Regular);
                                textBox3.Text = "Very Cold Day";
                                break;
                            case "32":
                                textBox2.ForeColor = Color.Blue;
                                textBox3.ForeColor = Color.Blue;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Freezing point of water";
                                break;
                            case "50":
                                textBox2.ForeColor = Color.LightBlue;
                                textBox3.ForeColor = Color.LightBlue;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Cool Day";
                                break;
                            case "69.8":
                                textBox2.ForeColor = Color.Green;
                                textBox3.ForeColor = Color.Green;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Regular);
                                textBox3.Text = "Room temperature";
                                break;
                            case "70":
                                textBox2.ForeColor = Color.Green;
                                textBox3.ForeColor = Color.Green;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Regular);
                                textBox3.Text = "Room temperature";
                                break;
                            case "86":
                                textBox2.ForeColor = Color.Orange;
                                textBox3.ForeColor = Color.Orange;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Beach weather";
                                break;
                            case "98.6":
                                textBox2.ForeColor = Color.Orange;
                                textBox3.ForeColor = Color.Orange;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = " Body temperature";
                                break;
                            case "104":
                                textBox2.ForeColor = Color.Red;
                                textBox3.ForeColor = Color.Red;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Hot Bath";
                                break;
                            case "212":
                                textBox2.ForeColor = Color.DarkRed;
                                textBox3.ForeColor = Color.DarkRed;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Water Boils";
                                break;
                            default:
                                textBox3.Clear();
                                break;

                        }
                        FileStream fs1 = null;
                        try
                        {
                            fs1 = new FileStream(path, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(fs1);
                            textOut.Write(textBox1.Text.Trim() + "°C = ");
                            textOut.Write(textBox2.Text.Trim() + "°F, ");
                            textOut.Write(DateTime.Now.ToString("yyyy/MM/dd h:mm:ss tt "));
                            textOut.WriteLine(textBox3.Text.Trim() + "  ");
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

                    else if (radioButton2.Checked) // farenheit to celcius
                    {
                        TempF = decimal.Parse(textBox1.Text);
                        TempC = (TempF - 32) * 5 / 9;
                        TempC = decimal.Round(TempC);
                        textBox2.Text = TempC.ToString();

                        switch (textBox2.Text)
                        {
                            case "-40":
                                textBox2.ForeColor = Color.Purple;
                                textBox3.ForeColor = Color.Purple;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Extremely Cold Day\r\n (and the same number!)";
                                break;
                            case "-18":
                                textBox2.ForeColor = Color.Blue;
                                textBox3.ForeColor = Color.Blue;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Regular);
                                textBox3.Text = "Very Cold Day";
                                break;

                            case "0":
                                textBox2.ForeColor = Color.Blue;
                                textBox3.ForeColor = Color.Blue;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Freezing point of water";
                                break;
                            case "10":
                                textBox2.ForeColor = Color.LightBlue;
                                textBox3.ForeColor = Color.LightBlue;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Cool Day";
                                break;
                            case "21":
                                textBox2.ForeColor = Color.Green;
                                textBox3.ForeColor = Color.Green;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Regular);
                                textBox3.Text = "Room temperature";
                                break;
                            case "30":
                                textBox2.ForeColor = Color.Orange;
                                textBox3.ForeColor = Color.Orange;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Beach weather";
                                break;
                            case "37":
                                textBox2.ForeColor = Color.Orange;
                                textBox3.ForeColor = Color.Orange;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Body temperature";
                                break;
                            case "40":
                                textBox2.ForeColor = Color.Red;
                                textBox3.ForeColor = Color.Red;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Hot Bath";
                                break;
                            case "100":
                                textBox2.ForeColor = Color.DarkRed;
                                textBox3.ForeColor = Color.DarkRed;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Water Boils";
                                break;
                            default:
                                textBox3.Clear();
                                break;

                        }


                        FileStream fs3 = null;
                        try
                        {
                            fs3 = new FileStream(path, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(fs3);
                            textOut.Write(textBox1.Text.Trim() + "°F = ");
                            textOut.Write(textBox2.Text.Trim() + "°C, ");
                            textOut.Write(DateTime.Now.ToString("yyyy/MM/dd h:mm:ss tt "));
                            textOut.WriteLine(textBox3.Text.Trim() + "  ");
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
                        finally { if (fs3 != null) fs3.Close(); }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid temperature.");
            }
        }
    }
}
