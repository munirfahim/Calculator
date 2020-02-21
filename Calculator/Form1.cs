using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculation(string sig) {

            switch (sig)
            {
                case "9":
                    textBox1.Text+="9";
                    break;
                case "8":
                    textBox1.Text += "8";
                    break;
                case "7":
                    textBox1.Text += "7";
                    break;
                case "6":
                    textBox1.Text += "6";
                    break;
                case "5":
                    textBox1.Text += "5";
                    break;
                default:
                    break;

            }


        
        } 

        private void buttonall(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Text=="." && textBox1.Text.Contains('.'))
                return;
            textBox1.Text += b.Text;
        }

        Boolean flag = false;

        private void buttoncalc(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (flag == false)
            {
                
                textBox1.Text += b.Text;
                flag= true;
            }
            else
            {
                calc();
                textBox1.Text += b.Text;
            }

        
        }

        private void calc() {
            string a = textBox1.Text;
            string[] calc;

            if (a.Contains('+')){

                calc = a.Split('+');
                if (calc.Length != 2)
                    return;
                    double b = Double.Parse(calc[0]) + Double.Parse(calc[1]);
                    textBox1.Text = b.ToString();
            }
            else if (a.Contains('-'))
            {
                calc = a.Split('-');
                if (calc.Length != 2)
                    return;
                    double b = Double.Parse(calc[0]) - Double.Parse(calc[1]);
                    textBox1.Text = b.ToString();
                
            }
            else if (a.Contains('*'))
            {
                calc = a.Split('*');
                
                
                    double b = Double.Parse(calc[0]) * Double.Parse(calc[1]);
                    textBox1.Text = b.ToString();
                
            }
            else if (a.Contains('/'))
            {
                calc = a.Split('/');
                if (Int32.Parse(calc[1]) == 0)
                    textBox1.Text = "SYNTAX ERROR";
                else
                {
                    double b = Double.Parse(calc[0]) / Double.Parse(calc[1]);
                    textBox1.Text = b.ToString();
                }
            }
        
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           // show("9");

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string[] calc;

            if (a.Contains('+'))
            {
                calc = a.Split('+');
                if (calc.Length != 2 || a.Contains('-') || a.Contains('*') || a.Contains('/'))
                    textBox1.Text = "SYNTAX ERROR";
                else
                {
                    double b = Double.Parse(calc[0]) + Double.Parse(calc[1]);
                    textBox1.Text = b.ToString();
                }
            }
            else if (a.Contains('-'))
            {
                calc = a.Split('-');
                if (calc.Length != 2 || a.Contains('+') || a.Contains('*') || a.Contains('/'))
                    textBox1.Text = "SYNTAX ERROR";
                else
                {
                    double b = Double.Parse(calc[0]) - Double.Parse(calc[1]);
                    textBox1.Text = b.ToString();
                }
            }
            else if (a.Contains('*'))
            {
                calc = a.Split('*');
                if (calc.Length != 2 || a.Contains('+') || a.Contains('-') || a.Contains('/'))
                    textBox1.Text = "SYNTAX ERROR";
                else
                {
                    double b = Double.Parse(calc[0]) * Double.Parse(calc[1]);
                    textBox1.Text = b.ToString();
                }
            }
            else if (a.Contains('/'))
            {
                calc = a.Split('/');
                if (calc.Length != 2 || a.Contains('+') || a.Contains('*') || a.Contains('-') || Int32.Parse(calc[1])==0)
                    textBox1.Text = "SYNTAX ERROR";
                else
                {
                    double b = Double.Parse(calc[0]) / Double.Parse(calc[1]);
                    textBox1.Text = b.ToString();
                }
            }
            else
                textBox1.Text = "";
        }
    }
}
