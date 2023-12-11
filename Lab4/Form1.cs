using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            private void button1_Click(object sender, EventArgs e)
            {
                double i = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double result = (i + b) / c;
                textBox4.Text = Convert.ToString(result);
                // or
                //textBox4.Text = Convert.ToString ((Convert.ToDouble (textBox1.Text) + Convert.ToDouble (textBox2.Text)) / Convert.ToDouble (textBox3.Text));
            }
            on the second button the Click event
private void button2_Click(object sender, EventArgs e)
        {// check which radiobutton was selected
            if (radioButton1.Checked == true)
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 10 / 100);
            if (radioButton2.Checked == true)
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 20 / 100);
            if (radioButton3.Checked == true)
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 50 / 100);
        }

    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            private void button1_Click(object sender, EventArgs e)
            {
                double i = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double result = (i + b) / c;
                textBox4.Text = Convert.ToString(result);
                // or
                //textBox4.Text = Convert.ToString ((Convert.ToDouble (textBox1.Text) + Convert.ToDouble (textBox2.Text)) / Convert.ToDouble (textBox3.Text));
            }
            on the second button the Click event
private void button2_Click(object sender, EventArgs e)
        {// check which radiobutton was selected
            if (radioButton1.Checked == true)
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 10 / 100);
            if (radioButton2.Checked == true)
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 20 / 100);
            if (radioButton3.Checked == true)
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 50 / 100);
        }

    }
}
}
