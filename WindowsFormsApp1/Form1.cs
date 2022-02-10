using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        int num = 0;
        int numTwo = 0;

        bool first = false;
        bool numTwoTrue = false;

        string selection = "";

        public Form1() { InitializeComponent(); }



        #region Numbers

        private void num1(object sender, EventArgs e)
        {
            if (first == true) label1.Text += "1";
            else
            {
                label1.Text = "1";
                first = true;
            }

            if (numTwoTrue == false) num = int.Parse(label1.Text);
            else { numTwo = int.Parse(label1.Text); }

        }

        private void num2(object sender, EventArgs e)
        {
            if (first == true) label1.Text += "2";
            else
            {
                label1.Text = "2";
                first = true;
            }

            if (numTwoTrue == false) num = int.Parse(label1.Text);
            else { numTwo = int.Parse(label1.Text); }

        }

        private void num3(object sender, EventArgs e)
        {
            if (first == true) label1.Text += "3";
            else
            {
                label1.Text = "3";
                first = true;
            }

            if (numTwoTrue == false) num = int.Parse(label1.Text);
            else { numTwo = int.Parse(label1.Text); }

        }

        private void num4(object sender, EventArgs e)
        {
            if (first == true) label1.Text += "4";
            else
            {
                label1.Text = "4";
                first = true;
            }

            if (numTwoTrue == false) num = int.Parse(label1.Text);
            else { numTwo = int.Parse(label1.Text); }
        }

        private void num5(object sender, EventArgs e)
        {
            if (first == true) label1.Text += "5";
            else
            {
                label1.Text = "5";
                first = true;
            }

            if (numTwoTrue == false) num = int.Parse(label1.Text);
            else { numTwo = int.Parse(label1.Text); }
        }

        private void num6(object sender, EventArgs e)
        {
            if (first == true) label1.Text += "6";
            else
            {
                label1.Text = "6";
                first = true;
            }

            if (numTwoTrue == false) num = int.Parse(label1.Text);
            else { numTwo = int.Parse(label1.Text); }
        }

        private void num7(object sender, EventArgs e)
        {
            if (first == true) label1.Text += "7";
            else
            {
                label1.Text = "7";
                first = true;
            }

            if (numTwoTrue == false) num = int.Parse(label1.Text);
            else { numTwo = int.Parse(label1.Text); }
        }

        private void num8(object sender, EventArgs e)
        {
            if (first == true) label1.Text += "8";
            else
            {
                label1.Text = "8";
                first = true;
            }

            if (numTwoTrue == false) num = int.Parse(label1.Text);
            else { numTwo = int.Parse(label1.Text); }
        }

        private void num9(object sender, EventArgs e)
        {
            if (first == true) label1.Text += "9";
            else
            {
                label1.Text = "9";
                first = true;
            }

            if (numTwoTrue == false) num = int.Parse(label1.Text);
            else { numTwo = int.Parse(label1.Text); }
        }


        private void num0(object sender, EventArgs e)
        {
            if(label1.Text != "0")
            {
                if (first == true) label1.Text += "0";
                else
                {
                    label1.Text = "0";
                    first = true;
                }

                if (numTwoTrue == false) num = int.Parse(label1.Text);
                else { numTwo = int.Parse(label1.Text); }
            }
        }


        #endregion

        #region Selection


        private void Toplam(object sender, EventArgs e)
        {
            selection = "+";

            if (numTwoTrue == true)
            {
                string result = "";
                result += num + numTwo;
                label1.Text = result;
                label2.Text = result + " +";
                num = int.Parse(result);
                first = false;
            }
            else
            {
                numTwoTrue = true;
                label2.Text = num + " +";
                first = false;
            }

        }


        private void Cixmaq(object sender, EventArgs e)
        {
            selection = "-";

            if (numTwoTrue == true)
            {
                string result = "";
                result += num - numTwo;
                label1.Text = result;
                label2.Text = result + " -";
                num = int.Parse(result);
                first = false;
            }
            else
            {
                numTwoTrue = true;
                label2.Text = num + " -";
                first = false;
            }
        }


        private void Vurma(object sender, EventArgs e)
        {

            selection = "*";


            if (numTwoTrue == true)
            {
                string result = "";
                result += num * numTwo;
                label1.Text = result;
                label2.Text = result + " x";
                num = int.Parse(result);
                first = false;
            }
            else
            {
                numTwoTrue = true;
                label2.Text = num + " x";
                first = false;
            }
        }


        private void Bolme(object sender, EventArgs e)
        {

            selection = "/";


            if (numTwoTrue == true)
            {
                string result = "";
                result += num / numTwo;
                label1.Text = result;
                label2.Text = result + " ÷";
                num = int.Parse(result);
                first = false;
            }
            else
            {
                numTwoTrue = true;
                label2.Text = num + " ÷";
                first = false;
            }
        }


        private void Beraber(object sender, EventArgs e)
        {
            string result = "";

            if(num != 0 && numTwo != 0)
            {
                if(selection == "+")
                {
                    result += num + numTwo;
                    label1.Text = result;
                    label2.Text = result + " +";
                    first = false;
                }
                else if(selection == "-")
                {
                    result += num - numTwo;
                    label1.Text = result;
                    label2.Text = result + " -";
                    first = false;

                }
                else if (selection == "*")
                {
                    result += num * numTwo;
                    label1.Text = result;
                    label2.Text = result + " *";
                    first = false;

                }
                else if (selection == "/")
                {
                    result += num / numTwo;
                    label1.Text = result;
                    label2.Text = result + " ÷";
                    first = false;

                }
            }
        }




        #endregion



        private void Clear(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "";
            first = false;
            numTwoTrue = false;
            num = 0;
            numTwo = 0;
            selection = "";
        }

        private void ClearE(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void Remove(object sender, EventArgs e)
        {
            string selection = "";
            string newNumber = "";

            if(label1.Text != "0")
            {
                if(label1.Text.Length == 1)
                {
                    label1.Text = "0";
                    first = false;
                }
                else
                {
                    selection = label1.Text;
                    for (int i = 0; i < label1.Text.Length - 1; i++)
                    {
                        newNumber += selection[i];
                    }

                    if (numTwoTrue == false) num = int.Parse(newNumber);
                    else numTwo = int.Parse(newNumber);

                    label1.Text = newNumber;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
    }
}
