using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CdCatalogue
{
    public partial class Form3 : Form
    {
        private newform form1;

        public Form3(newform form1)
        {
            InitializeComponent();
            this.form1 = form1;
           
        }
        //update datagridview row data
        private void button1_Click(object sender, EventArgs e)
        {
            form1.dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
            form1.dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
            form1.dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text;
            form1.dataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;

            // to close form after updating
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
