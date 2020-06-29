using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            decimal results = .0m;
            
            if (operator1 == "+")
            {
                results = operand1 + operand2;
            }
            else if (operator1 == "-")
            {
                results = operand1 - operand2;
            }
            else if (operator1 == "*")
            {
                results = operand1 * operand2;
            }
            else if (operator1 == "/")
            {
                results = operand1 / operand2;
            }

            return results;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //gathers numbers for calculation from the form and the operator
            decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
            decimal operand2 = Convert.ToDecimal(txtOperand2.Text);
            string operator1 = txtOperator.Text;

            Debug.WriteLine(operator1);

            decimal results = Calculate(operand1, operator1, operand2);

            txtResult.Text = String.Format("{0:f4}", results);
            txtOperand1.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtField_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }
}
