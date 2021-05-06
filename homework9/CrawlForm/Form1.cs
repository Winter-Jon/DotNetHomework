using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using static CrawlForm.Program;
using System.Linq;

namespace CrawlForm
{
    public partial class Form1 : Form
    {
        Form2 form2=new Form2();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
            List<string> urlList = new List<string>();
            foreach(string i in urlsResult.Keys)
            {
                System.Diagnostics.Debug.WriteLine(i);
                urlList.Add(i);
            }
            dataGridView1.DataSource = (from s in urlList select new { s }).ToList();

        }



    }
}
