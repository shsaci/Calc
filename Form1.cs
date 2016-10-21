using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn1.Text;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnMinus.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPlus.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnClear.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnClear.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn10.Text;
        }
        
    }
}
