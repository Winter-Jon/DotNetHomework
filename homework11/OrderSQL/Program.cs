using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderForm;
using OrderSQL;

namespace OrderSQL
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var db=new OrderDBContext()) 
            {
                var o = new Order { Id = 1,Name="dfa" };
                db.Orders.Add(o);
                db.SaveChanges();
             }
                Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
