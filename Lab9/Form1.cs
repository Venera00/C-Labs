using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
       using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication9
    {
        public partial class Form2 : Form
        {
            public Form2()
            {
                InitializeComponent();
            }

            public string FirstName
            {
                get { return textBox1.Text; }
                set { textBox1.Text = value; }
            }

            public string LastName
            {
                get { return textBox2.Text; }
                set { textBox2.Text = value; }
            }

            public int Age
            {
                get { return (int)numericUpDown1.Value; }
                set { numericUpDown1.Value = value; }
            }


        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Form2 editForm = new Form2();
        if (editForm.ShowDialog()! = DialogResult.OK)
            return; 

        ListViewItem newItem = listView1.Items.Add(editForm.FirstName);
        newItem.SubItems.Add(editForm.LastName);
        newItem.SubItems.Add(editForm.Age.ToString());
    }
    and edit for the button
private void button2_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0)
            return;

        ListViewItem item = listView1.SelectedItems[0];

        Form2 editForm = new Form2();

        editForm.FirstName = item.Text;
        editForm.LastName = item.SubItems[1].Text;
        editForm.Age = Convert.ToInt32(item.SubItems[2].Text);

        if (editForm.ShowDialog()! = DialogResult.OK)
            return;

        item.Text = editForm.FirstName;
        item.SubItems[1].Text = editForm.LastName;
        item.SubItems[2].Text = editForm.Age.ToString();
    }

