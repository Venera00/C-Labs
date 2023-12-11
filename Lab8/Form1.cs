using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                MessageBox.Show("CheckBox1 is selected");
            if (checkBox2.Checked == true)
                MessageBox.Show("CheckBox2 is selected");
            if (checkBox3.Checked == true)
                MessageBox.Show("CheckBox3 is selected");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.CheckState.ToString());
            MessageBox.Show(checkBox2.CheckState.ToString());
            MessageBox.Show(checkBox3.CheckState.ToString());
            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Checked;
            checkBox3.CheckState = CheckState.Indeterminate;
            if (checkBox2.CheckState == CheckState.Checked)
            {
                MessageBox.Show("The state of option 2 is equal to selected");
            }
            else
                MessageBox.Show("The state of choice item 2 is not selected or not defined");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                MessageBox.Show("The radioButton1 item is selected");
            if (radioButton2.Checked == true)
                MessageBox.Show("RadioButton2 is selected");
            if (radioButton3.Checked == true)
                MessageBox.Show("RadioButton3 is selected");
            MessageBox.Show("We can only select one item");

        }
    }
}
