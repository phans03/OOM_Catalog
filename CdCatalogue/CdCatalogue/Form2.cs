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
    public partial class Form2 : Form
    {
        private newform form1;

        public Form2(newform form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            // to close form after adding
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
