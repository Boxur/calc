using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum state
{
    add,substract,divide,multiply,none
}

namespace calc
{
    public partial class Calculator : Form
    {
        double num1=0;
        double num2=0;
        state state = state.none;

        public Calculator()
        {
            InitializeComponent();
        }
        private void reset()
        {
            char a = label1.Text[label1.Text.Length - 1];
            if (a == '+' || a == '-' || a == '*' || a == '/')
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
        }

        private void ButtonClick(string button)
        {
            textBox1.Text += button;
        }

        private void operation()
        {
            if (textBox1.Text == "")
                return;
            switch(state)
            {
                case state.none:
                    num1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                    num2 = num1;
                    num1 = 0;
                    label1.Text = Convert.ToString(num2);
                    break;
                case state.add:
                    num1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                    num2 += num1;
                    num1 = 0;
                    label1.Text = Convert.ToString(num2);
                    break;
                case state.substract:
                    num1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                    num2 -= num1;
                    num1 = 0;
                    label1.Text = Convert.ToString(num2);
                    break;
                case state.multiply:
                    num1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                    num2 *= num1;
                    num1 = 0;
                    label1.Text = Convert.ToString(num2);
                    break;
                case state.divide:
                    num1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                    num2 /= num1;
                    num1 = 0;
                    label1.Text = Convert.ToString(num2);
                    break;
                default:
                    break;
            }
        }

        //buttons
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            num1 = 0;
            num2 = 0;
            state = state.none;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operation();
            state = state.divide;
            reset();
            label1.Text += "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operation();
            state = state.multiply;
            reset();
            label1.Text += "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operation();
            state = state.substract;
            reset();
            label1.Text += "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operation();
            state = state.add;
            reset();
            label1.Text += "+";
        }
        
        private void button12_Click(object sender, EventArgs e)
        {
            operation();
            state = state.none;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            ButtonClick(".");
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            if (textBox1.Text[0]=='-')
            {
                textBox1.Text =  textBox1.Text.Substring(1);
            }else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            ButtonClick("0");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonClick("9");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonClick("8");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonClick("7");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonClick("6");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonClick("5");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonClick("4");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonClick("3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonClick("2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonClick("1");
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
