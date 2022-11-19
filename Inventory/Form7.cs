using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            SuccedLabel.Visible= false;
           
        }

        //Back To Main Form And Close Current Form//
        private void BtnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        decimal _Product_total_price = 0;
        
        
        int _Count_of_Product;

        //total price of one invoice
        decimal Invoice_total_price = 0;

        //Get The Below Data From Database
        private void Form7_Load(object sender, EventArgs e)
        {   
            R_D_SalesMan.Checked = true;

            //Fill ComboBox_SalesMan When Load With Names of SalesMen//
            var myContext = new MyContext();
            var _SalesMen = myContext.salesMan;
            foreach (var item in _SalesMen)
            {
                C_box_SalesManName.Items.Add(item.Name);
            }

            //Fill ComboBox_Product When Load With Names of Products//
            var _Product = myContext.product;
            foreach (var item in _Product)
            {
                C_box_ProductName.Items.Add(item.Name);
            }

            //Fill ComboBox_Customer When Load With Names of Customers//
            var _Customer = myContext.customer;
            foreach (var item in _Customer)
            {
                C_box_CustomerName.Items.Add(item.Name);
            }
        }


        //get number of products Names available in stock
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {   
            var myContext = new MyContext();
            var _Product = myContext.product.FirstOrDefault(x => x.Name == C_box_ProductName.Text);
            
            //Empty combox to change product
            C_box_ProductQuantity.Items.Clear();
            
            // Fill C_box_ProductQuantity With Count of Product Selected By [ C_box_ProductName ]//
            for (int i = 1; i <= _Product.Count ; i++)
            {
                C_box_ProductQuantity.Items.Add(i); 
            }
            

        }

        //Post Data in DataGridview
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyContext myContext = new MyContext();
            //Get Count of Product and Appear it in DataGridview
            _Count_of_Product = C_box_ProductQuantity.SelectedIndex + 1;

            // Get Product Name 
            var _Product = myContext.product.FirstOrDefault(x => x.Name == C_box_ProductName.Text);

            //Get Product Tota Price by Multiply  [ Quantity * Price ]
            _Product_total_price = _Product.Price * _Count_of_Product;

            //Fill DataGridView by (productName, Price, toal price, quantity)
            dataGridView1.Rows.Add(_Product.Name, _Product.Price, _Count_of_Product, _Product_total_price);

            //Increse Invoice Total Price For Every Product Total Price Inserted 
            Invoice_total_price += _Product_total_price;

            //Display Total Price Of Invoice Inside Disabled TxtBox
            txtTotalprice.Text = Invoice_total_price.ToString();

        }

        //Send Values Inserted By User From Fields Below To Database//
        //Save invoice in database in invoiceProduct
        private void BtnAdd_Click(object sender, EventArgs e)
        {

           var myContext = new MyContext();

            try {
                // Create an Object From Invoice To Send Inserted Data By it //
                var _Invoice = new Invoice()
                {
                    Total = Invoice_total_price,
                    Date = DateTime.Now,
                    Customer = myContext.customer.FirstOrDefault(c => c.Name == C_box_CustomerName.Text),
                    SalesMan = myContext.salesMan.FirstOrDefault(s => s.Name == C_box_SalesManName.Text),
                };
                myContext.invoice.Add(_Invoice);


                // Generate Invoice_Id and Get Values Of Product (_Id , _Price , _Count),..
                // From DataGridView And Send It To Database in table Invoice_Prodict
                foreach (DataGridViewRow item in this.dataGridView1.Rows)
                {
                    int _productCount;
                    _productCount = int.Parse(item.Cells["Col_Quantity"].Value.ToString());
                    string productName = item.Cells["Col_ProductName"].Value.ToString();
                    var _Product = myContext.product.FirstOrDefault(p => p.Name == productName);
                    _Product.Count -= _productCount;

                    //Creat an Object From Invoice Product To Send Inserted Data By it
                    InvoiceProduct soldedItems = new InvoiceProduct()
                    {
                        CountofProduct = _productCount,
                        InvoiceID = _Invoice.ID,
                        ProductID = _Product.ID,
                        PriceofTotalProduct = _productCount * _Product.Price,
                    };
                    myContext.invoiceProducts.Add(soldedItems);
                }
                //myContext.invoiceProducts.Add(soldedItems);
                myContext.SaveChanges();

                //-- Clear Fields Below After Insert Data to Database --//
                SuccedLabel.Visible = true;
                C_box_CustomerName.Text = "";
                C_box_ProductName.Text = "";
                C_box_ProductQuantity.Text = "";
                C_box_SalesManName.Text = "";
                txtTotalprice.Text = "";
                //-----------------------------------------------------//


                //Get ..Col_TotalPrice.. Value And Delete it From Total Price Before Send it To Database 
                Invoice_total_price = 0;
                dataGridView1.Rows.Clear();

                txtTotalprice.Text = Invoice_total_price.ToString();

            }
            catch 
            {
                MessageBox.Show("You can't enter same product twice", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //Delete Row From Datagridview and Decrese its Value From Total Price 
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                //Get ..Col_TotalPrice.. Value And Delete it From Total Price Before Send it To Database 
                Invoice_total_price -= decimal.Parse( item.Cells["Col_TotalPrice"].Value.ToString());
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            txtTotalprice.Text = Invoice_total_price.ToString();

        }


        //Switch Btween SalesMan And Customer 
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (R_D_SalesMan.Checked)
            {
                CustomerLabel.Visible = false;
                SalesManLabel.Visible = true;
                C_box_CustomerName.Visible = false;
                C_box_SalesManName.Visible = true;
            }
            else
            {
                CustomerLabel.Visible = true;
                SalesManLabel.Visible = false;
                C_box_CustomerName.Visible = true;
                C_box_SalesManName.Visible = false;

            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (R_D_SalesMan.Checked)
            {
                CustomerLabel.Visible = false;
                SalesManLabel.Visible = true;
                C_box_CustomerName.Visible = false;
                C_box_SalesManName.Visible = true;
            }
            else
            {
                CustomerLabel.Visible = true;
                SalesManLabel.Visible = false;
                C_box_CustomerName.Visible = true;
                C_box_SalesManName.Visible = false;


            }

        }

        ///total price should be insert to database
        ///quantity 
        ///update and delete for datagrid view
        ///decrease product count
        ///purshae invoice 
        ///reports 
    }
}
