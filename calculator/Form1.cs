using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TextBox curTxtBox;
        
        private void btnEqual_Click(object sender, EventArgs e)
        {
            //verification of proper input 
            if (double.TryParse(txtBxLeft.Text, out double num1) && double.TryParse(txtbxRight.Text, out double num2))
            {
                string action = cmbxAction.SelectedItem?.ToString();
                switch(action)
                {
                    case "+":
                        lblResult.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        lblResult.Text = (num1 - num2).ToString();
                        break;
                    case "*":
                        lblResult.Text = (num1 * num2).ToString();
                        break;
                    case "/":
                        if(num2 == 0)
                        {
                            MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        lblResult.Text = (num1 / num2).ToString();
                        break;
                    case "^":
                        lblResult.Text = (Math.Pow(num1, num2)).ToString();
                        break;
                    case "~":
                        lblResult.Text = (Math.Sqrt(num1)).ToString();
                        break;
                    default:
                        MessageBox.Show("Please select a valid operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //
        private void ChainChars(object sender, EventArgs e)
        {
            string chr = ((Button)sender).Text;
            //prevention of duplication of dots.
            if (chr == "." && curTxtBox.Text.Contains('.'))
            {
                return;
            }
            curTxtBox.Text += chr;
        }
        //handle textboxs.
        private void SelectedTextBox(object sender, EventArgs e)
        {
            curTxtBox = ((TextBox)sender);
        }
        //choose operator
        private void SelectedAction(object sender, EventArgs e)
        {
            cmbxAction.SelectedItem = ((Button)sender).Text;
            curTxtBox = txtbxRight;
        }

        private void Clear(object sender, EventArgs e)
        {
            txtBxLeft.Clear();
            txtbxRight.Clear();
            lblResult.Clear();
            cmbxAction = null;
            curTxtBox = txtBxLeft;
        }

        private void cmbxAction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
