using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDashboard
{
    internal class Class
    {

        
        //properties
        private decimal currentValue;   //A decimal that stores the result currently displayed by the calculator.
        private decimal operand1;   //A decimal that stores the value of the first operand
        private decimal operand2;   //A decimal that stores the value of the second operand
        private string op;          //A string type that stores the value of the operator

        public decimal CurrentValue
        {
            get { return currentValue;  }
            set { currentValue=value; }
        }
        public decimal Operand1
        {
            get { return operand1; }
            set { operand1 = value; }
        }
        public decimal Operand2
        {
            get { return operand2; }
            set { operand2 = value; }
        }
        public string Op
        {
            get { return op; }
            set { op = value; }
        }

        public void Add(string displayValue)
        {
            operand1 = Convert.ToDecimal(displayValue);
            currentValue =operand1;
            op = "+";
        }

        public void Subtract(string displayValue)
        {
            operand1 = Convert.ToDecimal(displayValue);
            currentValue = operand1;
            op = "-";
        }

        public void Multiply(string displayValue)
        {
            operand1 = Convert.ToDecimal(displayValue);
            currentValue = operand1;
            op = "*";
        }

        public void Divide(string displayValue)
        {
            operand1 = Convert.ToDecimal(displayValue);
            currentValue = operand1;
            op = "/";
        }

        public string Equals(string displayValue)
        {
            //operand2 =  Convert.ToDecimal(displayValue);
            //currentValue = DoOperation();
           
            //return displayValue;
            operand2 = Convert.ToDecimal(displayValue);
            switch (op)
            {
                case "+":
                    operand1 += operand2;
                    break;
                case "-":
                    operand1 -= operand2;
                    break;
                case "*":
                    operand1 *= operand2;
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                    }
                    operand1 /= operand2;
                    break;
                default:
                    
                    break;
                    
            }
            return operand1.ToString();
        }

        public void Clear()
        {
            currentValue = 0;
            operand1 = 0;
            operand2 = 0;
            op = null;
        }
       

       
    }
}

