using System;
using System.Windows.Forms;

namespace Lab 13
{
    public partial class Form1 : Form
    {
        int index = 0;
        int[] sum = { 2, 1, 1, 1, 2 };
        string[] s = {
            " What is C#? ",
            " What is an int? ",
            " What is the foreach loop responsible for? ",
            " How does the if statement work? ",
            " How does an int differ from a short data type? "
        };
        string[,] value =
        {
            { "Programming language", "Data type", "Loop operator", "Conditional operator" },
            { "Data type", "Programming language", "Loop operator", "Conditional operator" },
            { "Loop that iterates over a collection", "Data type for integers", "Programming language", "It is incorrect" },
            { "One of the branches", "Executed based on a condition", "Control flow statement", "Conditional execution" },
            { "Size of allocated memory", "Integer data type", "Conditional execution", "Conditional execution" }
        };
        int temp = 0;
        int result = 0;

        public Form1()
        {
            InitializeComponent();
            LoadData(index);
        }

        private void LoadData(int i)
        {
            if (index >= s.Length) return;
            else
            {
                groupBox1.Text = s[index];
                radioButton1.Text = value[index, 0];
                radioButton2.Text = value[index, 1];
                radioButton3.Text = value[index, 2];
                radioButton4.Text = value[index, 3];
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            temp = 0;
            if (radioButton1.Checked) temp = 0;
            else if (radioButton2.Checked) temp = 1;
            else if (radioButton3.Checked) temp = 2;
            else if (radioButton4.Checked) temp = 3;

            if (temp == sum[index]) result++;

            index++;
            if (index < s.Length)
            {
                LoadData(index);
            }
            else
            {
                MessageBox.Show("Quiz completed. You got " + result + " out of " + s.Length + " questions correct.");
                index = 0;
                result = 0;
                LoadData(index);
            }
        }
    }
}
