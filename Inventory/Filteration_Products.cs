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
    public partial class Filteration_Products : Form
    {
        public Filteration_Products()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyContext myContext = new MyContext();
            if (numericUpDown1.Value != 0 && numericUpDown2.Value==0)
            {
                dataGridView1.DataSource = myContext.product.Select(p => new { p.Name, p.Price, p.Count, Category = p.category.Name }).Where(p => p.Count >= numericUpDown1.Value).ToList();

            }
            else if(numericUpDown2.Value != 0 && numericUpDown1.Value == 0)
            { 
                dataGridView1.DataSource = myContext.product.Select(p => new { p.Name, p.Price, p.Count, Category = p.category.Name }).Where(p => p.Count <= numericUpDown2.Value).ToList();

            }
            else 
            {
                dataGridView1.DataSource = myContext.product.Select(p => new { p.Name, p.Price, p.Count, Category = p.category.Name }).Where(p => p.Count <= numericUpDown2.Value && p.Count >= numericUpDown1.Value).ToList();

            }

        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
