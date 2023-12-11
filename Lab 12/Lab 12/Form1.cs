using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace YourNamespace
{
    public partial class Form1 : Form
    {
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataTable table;
        private BindingSource bindingSource = new BindingSource();
        private int enteredRowIndex = -1;

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridViews();
            InitializeDataTable();
        }

        private void InitializeDataGridViews()
        {
            dataGridView1 = new DataGridView();
            dataGridView1.Location = new Point(10, 10);
            dataGridView1.Size = new Size(400, 150);
            Controls.Add(dataGridView1);

            dataGridView2 = new DataGridView();
            dataGridView2.Location = new Point(10, 200);
            dataGridView2.Size = new Size(400, 150);
            Controls.Add(dataGridView2);

            dataGridView1.Columns.Add("LastName", "Last Name");
            dataGridView1.Columns.Add("FirstName", "First Name");
            dataGridView1.Columns.Add("Age", "Age");

            dataGridView1.Rows.Add("Ivanov", "Peter", 12);
            dataGridView1.Rows.Add("Abdylbaev", "Ruslan", 12);
            dataGridView1.Rows.Add("Ruslanova", "Zarina", 12);
            dataGridView1.Rows.Add("Igorov", "Peter", 12);
            dataGridView1.Rows.Add("Ivanov", "Sergey", 12);
        }

        private void InitializeDataTable()
        {
            table = new DataTable();
            table.Columns.Add("Column1", typeof(string));
            table.Columns.Add("Column2", typeof(string));
            table.Columns.Add("Column3", typeof(int));

            bindingSource.DataSource = table;
            dataGridView2.DataSource = bindingSource;
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            dataGridView1.Rows[enteredRowIndex].DefaultCellStyle.BackColor = Color.White;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[1, i].FormattedValue.ToString().Trim().ToLower().Contains(toolStripTextBox1.Text.Trim().ToLower()))
                {
                    dataGridView1.CurrentCell = dataGridView1[1, i];
                    enteredRowIndex = i;
                    dataGridView1.Rows[enteredRowIndex].DefaultCellStyle.BackColor = Color.Aqua;
                    return;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Event for form load
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Click event for Button 1
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Click event for Button 2
        }
    }
}
