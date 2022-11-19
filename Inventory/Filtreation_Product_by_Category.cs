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
    public partial class Filtreation_Product_by_Category : Form
    {
        public Filtreation_Product_by_Category()
        {
            InitializeComponent();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Filtreation_Product_by_Category_Load(object sender, EventArgs e)
        {
            var myContext = new MyContext();

            var category = myContext.categorie;
            foreach (var _product in category)
            {
                comboBox1.Items.Add(_product.Name);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var myContext = new MyContext();
            dataGridView1.DataSource = myContext.product.Where(p => p.category.Name == comboBox1.Text).Select(p => new { p.Name, p.Price, p.Count, Category = p.category.Name }).ToList();

        }

        //identity of customer 
        //sales man in purchase invoice 
        //reports 
        //explain your knowledge about project

    }
}
