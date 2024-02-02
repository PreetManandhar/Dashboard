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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;

/*name= Preet Manandhar
form Loto Max
This form displays random unique 8 numbers and then write and read in text  file
*/
namespace frmDashboard
{
    public partial class frmMax : Form
    {
        public frmMax()
        {
            InitializeComponent();
        }

        string path = @".\LottoNbrs.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            
          
                int lastNum = 0;
                string numbers = "";
                textBox1.Text = "";
                string currentDate = DateTime.Now.ToString();
                Random random = new Random();

                for (int i = 0; i < 8; i++)
                {
                    int randomNum = random.Next(1, 50);
                    textBox1.Text += randomNum + "\t";
                    if (i < 7) numbers += randomNum.ToString() + ",";
                    else lastNum = randomNum;
                }

                // for writing
                FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);

                // create the output stream for a text file that exists
                StreamWriter textOut = new StreamWriter(fs);

                // write the fields into text file
                textOut.WriteLine($"Max, {currentDate},  {numbers} Bonus {lastNum}");

                // close the output stream for the text file
                textOut.Close();
            }

            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally
            {
                if (fs != null) fs.Close();
            }


        }








        private void button2_Click(object sender, EventArgs e)
        {            //for reading 
            FileStream fs3 = null;

            fs3 = new FileStream(path, FileMode.OpenOrCreate,
                FileAccess.Read);

            // create the object for the input stream for a text file
            StreamReader textIn = new StreamReader(fs3);

            string textToPrint = "";

            while (textIn.Peek() != -1)
            {
                textToPrint += textIn.ReadLine() + "\n";
                // read the data from the file and store it in the list
            }
            MessageBox.Show(textToPrint);
            // close the input stream for the text file
            textIn.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application?", "Exit?", MessageBoxButtons.YesNo).ToString() != "Yes")
            {
                this.Close();
            }

           

        }
    }

}


