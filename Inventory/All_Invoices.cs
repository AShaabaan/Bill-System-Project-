using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class All_Invoices : Form
    {
        public All_Invoices()
        {
            InitializeComponent();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void All_Invoices_Load(object sender, EventArgs e)
        {
            MyContext myContext = new MyContext();
           
            
            dataGridView1.DataSource = myContext.invoice.Select(p => new { p.ID, p.Date , Customer = p.Customer.Name, Sales_Man = p.SalesMan.Name ,p.Total }).ToList();


        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            MyContext myContext = new MyContext();
            var report = myContext.invoice.Where(p => p.Date >= dp_startDate.Value && p.Date <= dp_endDate.Value).Select(p => new 
            { Bill_Number = p.ID, p.Total,CustomerName = p.Customer.Name, SalesManName = p.SalesMan.Name }).ToList();

            dataGridView1.DataSource = report;
        }
    }
}
