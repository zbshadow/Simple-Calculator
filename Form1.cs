using System;
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
            decimal results = 0;
            switch (operator1)
            {
                case "+":
                    results = operand1 + operand2;
                    break;
                case "-":
                    results = operand1 - operand2;
                    break;
                case "*":
                    results = operand1 * operand2;
                    break;
                case "/":
                    results = operand1 / operand2;
                    break;
            }

            return results;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //gathers numbers for calculation from the form and the operator
            decimal operand1 = Convert.ToDecimal(txtOperand1);
            decimal operand2 = Convert.ToDecimal(txtOperand2);
            string operator1 = txtResult.Text;

            decimal results = Calculate(operand1, operator1, operand2);

            txtResult.Text = String.Format("{0:f4}", results);
        }
    }
}
