using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class Form1 : Form
    {
        string calcString;
        bool clearNextEntry = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberBtn_Click(object sender, EventArgs e)
        {
            if (clearNextEntry == true)
            {
                CalculationBox.Text = "";
                clearNextEntry = false;
            }
               
            CalculationBox.Text += ((Button)sender).Text;
            
        }

        private void MathFunc_Click(object sender, EventArgs e)
        {
            clearNextEntry = true;
            calcString += CalculationBox.Text;
            calcString += ((Button)sender).Text;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            CalculationBox.Text = "0";
            calcString = "";
            clearNextEntry = false;
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            clearNextEntry = true;
            calcString += CalculationBox.Text;

            CalculateTree calcTree = new CalculateTree(calcString);
            CalculationBox.Text = calcTree.Answer;

            calcString = "";
        }
    }
}