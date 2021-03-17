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

        private void oneBtn_Click(object sender, EventArgs e)
        {
            
            if (resultTbox.Text =="0")
            {
                resultTbox.Text = "1";
            }
            else
            {
                resultTbox.Text += "1";
            }
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            
            if (resultTbox.Text == "0")
            {
                resultTbox.Text = "2";
            }
            else
            {
                resultTbox.Text += "2";
            }

        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            
            if (resultTbox.Text == "0")
            {
                resultTbox.Text = "3";
            }
            else
            {
                resultTbox.Text += "3";
            }
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            
            if (resultTbox.Text == "0")
            {
                resultTbox.Text = "4";
            }
            else
            {
                resultTbox.Text += "4";
            }
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            
            if (resultTbox.Text == "0")
            {
                resultTbox.Text = "5";
            }
            else
            {
                resultTbox.Text += "5";
            }
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            
            if (resultTbox.Text == "0")
            {
                resultTbox.Text = "6";
            }
            else
            {
                resultTbox.Text += "6";
            }
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            
            if (resultTbox.Text == "0")
            {
                resultTbox.Text = "7";
            }
            else
            {
                resultTbox.Text += "7";
            }
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            
            if (resultTbox.Text == "0")
            {
                resultTbox.Text = "8";
            }
            else
            {
                resultTbox.Text += "8";
            }
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            
            if (resultTbox.Text == "0")
            {
                resultTbox.Text = "9";
            }
            else
            {
                resultTbox.Text += "9";
            }
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            
            if (resultTbox.Text == "0")
            {
                resultTbox.Text = "0";
            }
            else
            {
                resultTbox.Text += "0";
            }
        }


        private void plusBtn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(resultTbox.Text);
            mainResult = "+";
            processLbl.Text = resultTbox.Text + "+";
            resultTbox.Text = "0";
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(resultTbox.Text);
            mainResult = "-";
            processLbl.Text = resultTbox.Text + "-";
            resultTbox.Text = "0";
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(resultTbox.Text);
            mainResult = "*";
            processLbl.Text = resultTbox.Text + "*";
            resultTbox.Text = "0";
        }

        private void devideBtn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(resultTbox.Text);
            mainResult = "÷";
            processLbl.Text = resultTbox.Text + "÷";
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
