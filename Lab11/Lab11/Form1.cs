using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        ppublic Form1()
        {
            InitializeComponent();
            dataGridView1.Click += dataGridView1_Click;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                label5.Text = "Current product: " + dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString() +
                    " at the price: " + dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString() +
                    " available: " + dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            }
        }

        dataGridView1.Columns.Add("Column1", "Product");
        dataGridView1.Columns.Add("Column2", "Another Column");
         dataGridView1.Columns.Add("Column3", "Parameter");

         var lastColumn = dataGridView1.Columns["Parameter"];

        if (lastColumn is DataGridViewComboBoxColumn comboBoxColumn)
{
    comboBoxColumn.Items.Add("Item1");
    comboBoxColumn.Items.Add("Item2");
    
}
}
}
