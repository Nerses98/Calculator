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
            button16.Focus();
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
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operation)
                {
                    case "+":
                        result.Text = (value + double.Parse(result.Text)).ToString();
                        break;
                    case "-":
                        result.Text = (value - double.Parse(result.Text)).ToString();
                        break;
                    case "*":
                        result.Text = (value * double.Parse(result.Text)).ToString();
                        break;
                    case "/":
                        if (double.Parse(result.Text) != 0)
                            result.Text = (value / double.Parse(result.Text)).ToString();
                        else
                        {
                            result.Text = "Error";
                        }
                        break;
                    default:
                        break;

                }
                //value = 0;
                
            }
            catch(Exception)
            {
            }         
            operationended = true;
            equation.Text = "";      
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button16.Focus();
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
            button16.Focus();
            result.Clear();
            result.Text = "0";       
        }
        private void operator_click(object sender, EventArgs e)
        {
            button16.Focus();
            Button b = sender as Button;

            if (equation.Text != "")
            {
                button16_Click(button16, EventArgs.Empty);
            }
                operation = b.Text;
            try
            {
                value = double.Parse(result.Text);
            }
            catch(Exception) { }
                pressed = true;
                equation.Text = value.ToString() + " " + b.Text;

            
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
                button23_Click(button23, EventArgs.Empty);

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

       

        private void Unar_Operation(object sender, EventArgs e)
        {
            button16.Focus();
            Button b = sender as Button;
            string unaroperation = b.Text;
            try
            {
                switch (unaroperation)
                {

                    case "±":
                        if (!result.Text.Contains("-"))
                            result.Text = "-" + result.Text;
                        else
                           result.Text=result.Text.Remove(0,1);
                        break;
                    case "√":
                        result.Text = Math.Sqrt(double.Parse(result.Text)).ToString();
                        operationended = true;
                        break;
                    case "%":
                        result.Text = ((value * double.Parse(result.Text)) / 100).ToString();
                        break;
                    case "1/x":
                        if (result.Text != "0")
                        {
                            result.Text = (1 / (double.Parse(result.Text))).ToString();
                            operationended = true;
                        }
                        else
                        { result.Text = "Error";
                            operationended = true;
                        }
                        break;
                    default:
                        break;

                }
            }
            catch (Exception)
            { }

            
        }

        private void button23_Click(object sender, EventArgs e)
        {  if (!operationended)
            {
                button16.Focus();
                if (result.Text.Length == 1)
                    result.Text = "0";
                else
                    result.Text = result.Text.Remove(result.Text.Length - 1, 1);
            }
        }
    }
}
