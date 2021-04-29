using System;
using System.Windows.Forms;
using static CrawlForm.Program;

namespace CrawlForm
{
    public partial class Form1 : Form
    {
        Form2 form2=new Form2();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = bindingSource1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
            bindingSource1.DataSource = urlsResult.Keys;

        }



    }
}
