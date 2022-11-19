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
    public partial class All_Product_in_Stock : Form
    {
        public All_Product_in_Stock()
        {
            InitializeComponent();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void All_Product_in_Stock_Load(object sender, EventArgs e)
        {
            MyContext myContext = new MyContext();
            
            dataGridView1.DataSource = myContext.product.Where(p=>p.Count>0).Select(p => new { p.Name, p.Price, p.Count, Category = p.category.Name }).ToList();

            
        }
    }
}
