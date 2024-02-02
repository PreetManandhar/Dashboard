using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*name : preet manandhar
 this form Lotto649 generates 7 random numbers between 1 to 49 and then write and read in text file
botton 1 is for generating and writing text file
botton 2 is for readinf text file 
*/
namespace frmDashboard
{
    public partial class Lotto649 : Form
    {
        public Lotto649()
        {
            InitializeComponent();
        }
       
        string path = @".\LottoNbrs.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            int lastNumber = 0;
            string numbers = "";
            textBox1.Text = "";
            string currentDate = DateTime.Now.ToString();
            Random random = new Random();
            //loop to create random numbers
            for (int i = 0; i < 7; i++)
            {
                int randomNumber = random.Next(1, 49);
                textBox1.Text += randomNumber + "\t";
                if (i < 6) numbers += randomNumber.ToString() + ",";
                else lastNumber = randomNumber;
            }
            //for writing
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);

                // create the output stream for a text file that exists
                StreamWriter textOut = new StreamWriter(fs);

                // write the fields into text file
                textOut.WriteLine($"649, {currentDate},  {numbers} Bonus {lastNumber}");

                // close the output stream for the text file
                textOut.Close();
            }

            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { 
                if (fs != null) fs.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs2 = null;

            fs2 = new FileStream(path, FileMode.OpenOrCreate,
                FileAccess.Read);

            // create the object for the input stream for a text file
            StreamReader textIn = new StreamReader(fs2);

            string textToPrint = "";

            while (textIn.Peek() != -1) {
                textToPrint += textIn.ReadLine()+"\n"; 
                // read the data from the file and store it in the list
            }
            MessageBox.Show(textToPrint);
            // close the input stream for the text file
            textIn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application?", "Exit?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
