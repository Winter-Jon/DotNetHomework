using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CrawlForm
{
    public partial class Form2 : Form
    {
        public string startUrl { get ; set ; }

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            startUrl = textBox1.Text;
            try
            {
                new Uri(startUrl);
            }
            catch(System.UriFormatException)
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.urlsResult.Clear();
            SimpleCrawler simpleCrawler = new SimpleCrawler();
            simpleCrawler.CrawlStart(startUrl);
        }
    }
}
