using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Main
{
    public partial class CalculatorMain : Form
    {
        double num1, num2;
        string mainResult;

        public CalculatorMain()
        {
            InitializeComponent();
        }

     

        private void NumberButtonClickHandler(object sender, EventArgs e)
        {
            string buttonValue = (sender as Button).Text;

            if (resultTbox.Text == "0")
            {
                resultTbox.Text = buttonValue;
            }
            else
            {
                resultTbox.Text += buttonValue;
            }
        }

        private void PlusMinusMultiplyDivideButtonHandler(object sender, EventArgs e)
        {
            string buttonValue = (sender as Button).Text;
            num1 = Convert.ToDouble(resultTbox.Text);
            mainResult = buttonValue;
            processLbl.Text = resultTbox.Text + buttonValue;
            resultTbox.Text = "0";
        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(resultTbox.Text);
            mainResult = "√";
            processLbl.Text = "√" + resultTbox.Text;
            num1 = Math.Sqrt(num1);
            resultTbox.Text = Convert.ToString(num1);
        }

        private void powBtn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(resultTbox.Text);
            mainResult = "^2";
            processLbl.Text = resultTbox.Text + "*" + num1;
            resultTbox.Text = Convert.ToString(Math.Pow(num1,2));
        }

        private void dxBtn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(resultTbox.Text);
            mainResult = "1÷";
            processLbl.Text = 1 + "÷" + num1;
            resultTbox.Text = Convert.ToString(1 / num1);
        }

        private void modeBtn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(resultTbox.Text);
            mainResult = "%";
            processLbl.Text = resultTbox.Text + "%";
            resultTbox.Text = "0";
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(resultTbox.Text);
            if(mainResult == "+")
            {
                resultTbox.Text = Convert.ToString(num1 + num2);
                processLbl.Text = " ";
            }
            if(mainResult == "-")
            {
                resultTbox.Text = Convert.ToString(num1 - num2);
                processLbl.Text = " ";
            }
            if(mainResult == "*")
            {
                resultTbox.Text = Convert.ToString(num1 * num2);
                processLbl.Text = " ";
            }
            if(mainResult == "÷")
            {
                resultTbox.Text = Convert.ToString(num1 / num2);
                processLbl.Text = " ";
            }
            if(mainResult == "%")
            {
                resultTbox.Text = Convert.ToString(num1 % num2);
                processLbl.Text = " ";
            }
        }

        private void lcBtn_Click_1(object sender, EventArgs e)
        {
            if(Convert.ToDouble(resultTbox.Text) > 0)
            {
                resultTbox.Text = resultTbox.Text.Remove(resultTbox.Text.Length - 1, 1);
                if (resultTbox.Text.Length == 0)
                {
                    resultTbox.Text = "0";
                }
            }
        }


        private void fcBtn_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(resultTbox.Text)!=0)
            {
                resultTbox.Text = "0";
                processLbl.Text = " ";
            }
        }
    }
}
