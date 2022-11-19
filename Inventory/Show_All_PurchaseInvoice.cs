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
    public partial class Show_All_PurchaseInvoice : Form
    {
        public Show_All_PurchaseInvoice()
        {
            InitializeComponent();
        }

        private void Show_All_PurchaseInvoice_Load(object sender, EventArgs e)
        {
            MyContext myContext = new MyContext();

            dataGridView1.DataSource = myContext.purchaseInvoice.Select(p => new { p.Id, p.Total, SupplierName = p.supplier.Name, SalesManName = p.SalesMan.Name , p.Date }).ToList();

        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
