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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void BtnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnShowAllProduct_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //form1.Close();
            this.Hide();
            All_Product_in_Stock all_Product_In_Stock = new All_Product_in_Stock();
            all_Product_In_Stock.ShowDialog();
            this.Visible = true;



        }

        private void BtnShowAllInvoices_Click(object sender, EventArgs e)
        {
            this.Hide();
            All_Invoices all_Invoices = new All_Invoices();
            all_Invoices.ShowDialog();
            this.Visible = true;

        }

        private void BtnProductLessANumber_Click(object sender, EventArgs e)
        {
            this.Hide();
            Filteration_Products filteration_Products = new Filteration_Products();
            filteration_Products.ShowDialog();
            this.Visible = true;
        }

        private void BtnShowAllPurchasencoives_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_All_PurchaseInvoice show_All_PurchaseInvoice = new Show_All_PurchaseInvoice();
            show_All_PurchaseInvoice.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Filtreation_Product_by_Category filtreation_Product_By_Category = new Filtreation_Product_by_Category();
            filtreation_Product_By_Category.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowSoldedItems showSoldedItems = new ShowSoldedItems();
            showSoldedItems.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowBackedItems showBackedItems = new ShowBackedItems();
            showBackedItems.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FilterationProductByPrice filterationProductByPrice  = new FilterationProductByPrice();
            filterationProductByPrice.ShowDialog();
            this.Visible = true;
        }
    }
}
