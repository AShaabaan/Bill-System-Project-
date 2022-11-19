using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class ShowSoldedItems : Form
    {
        public ShowSoldedItems()
        {
            InitializeComponent();
        }

      

        private void ShowSoldedItems_Load(object sender, EventArgs e)
        {
            MyContext myContext = new MyContext();

            dataGridView1.DataSource = myContext.invoiceProducts.Select(p => new { p.Product.Name, Category = p.Product.category.Name, p.Product.Count ,p.PriceofTotalProduct,p.Invoice.Date }).ToList();

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            MyContext myContext = new MyContext();
            var report = myContext.invoiceProducts.Where(p => p.Invoice.Date >= dp_startDate.Value && p.Invoice.Date <= dp_endDate.Value).Select(p => new
            { p.Product.Name, Category = p.Product.category.Name,p.Product.Count ,p.PriceofTotalProduct, p.Invoice.Date }).ToList();

            dataGridView1.DataSource = report;
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
