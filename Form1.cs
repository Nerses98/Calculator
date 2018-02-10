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
      
        private double value = 0;
        private string operation = "";
        private bool pressed = false;
        private bool operationended = false;
        public Form1()
        {
            InitializeComponent();
        }    
        private void NumberClick(object sender, EventArgs e)
        {

            if (result.Text == "0" || pressed == true || operationended == true)
            {
                operationended = false;
                pressed = false;
                result.Clear();
            }
            if (result.Text == "Error")
            {
                pressed = true;
            }
            Button b = sender as Button;
            if (b.Text == ".")
            {
                if(!result.Text.Contains("."))
                    result.Text += b.Text;
            }
            else
                result.Text += b.Text;
           button16.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button16_Click(object sender, EventArgs e)
        {
            
            switch (operation)
            { 
                case "+":
                    try
                    {
                        result.Text = (value + double.Parse(result.Text)).ToString();
                    }
                    catch(Exception)
                    {
                    }
                    break;
                case "-":
                    try
                    {
                        result.Text = (value - double.Parse(result.Text)).ToString();                 
                    }
                    catch (Exception)
                    {
                    }
                    break;
                case "*":
                    try
                    {
                        result.Text = (value * double.Parse(result.Text)).ToString();
                        
                    }
                    catch(Exception)
                    { }
                    break;
                case "/":
                    try
                    {
                        if (double.Parse(result.Text) != 0)
                            result.Text = (value / double.Parse(result.Text)).ToString();
                        else
                        {
                            result.Text = "Error";
                            value = 0;
                        }

                    }
                    catch (Exception)
                    {

                    }
                    break;
                    default:
                    break;
                }
            
            operationended = true;
            equation.Text = "";      
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
            result.Text = "0";
            equation.Text = "";
     
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Clear();
            result.Text = "0";       
        }
        private void operator_click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (equation.Text != "")
                button16_Click(button16, EventArgs.Empty);
           
                operation = b.Text;
            try
            {
                value = double.Parse(result.Text);
            }
            catch(Exception) { }
                pressed = true;
                equation.Text = result.Text + " " + b.Text;

            
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void button5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                button17_Click(button17, EventArgs.Empty);
            }
            if (e.KeyChar == (char)8)
            {
                button18_Click(button18, EventArgs.Empty);

            }
      
            char s = e.KeyChar;
            switch (s.ToString())
            {
                case ("0"):
                    button12.PerformClick(); 
                    break;
                case ("1"):
                    button5.PerformClick();                  
                    break;
                case ("2"):
                    button4.PerformClick();                  
                    break;
                case ("3"):
                    button3.PerformClick();                  
                    break;
                case ("4"):
                    button1.PerformClick();
                    break;
                case ("5"):
                    button7.PerformClick();
                    break;
                case ("6"):
                    button6.PerformClick();
                    break;
                case ("7"):
                    button2.PerformClick();
                    break;
                case ("8"):
                    button11.PerformClick();
                    break;
                case ("9"):
                    button10.PerformClick();
                    break;
                case "+":
                    button9.PerformClick();
                    break;
                case "-":
                    button13.PerformClick();
                    break;
                case "*":
                    button15.PerformClick();
                    break;
                case "/":
                    button14.PerformClick();
                    break;
                case ".":
                    button8.PerformClick();
                    break;
                case "=":
                    button16.PerformClick();
                    break;
                case " ":
                    button16.PerformClick();
                    break;
                default:
                    break;


            }
        
        
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
