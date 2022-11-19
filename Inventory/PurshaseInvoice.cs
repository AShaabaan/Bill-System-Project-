using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory
{
    public partial class PurshaseInvoice : Form
    {
        public PurshaseInvoice()
        {
            InitializeComponent();
            SuccedLabel.Visible = false;

        }
        decimal totalPrice=0;
        //Back To Main Form And Close Current Form//
        private void BtnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void Btn_Add_To_DGV_Click(object sender, EventArgs e)
        {

            if (productcombox.Text.Length == 0)
            {
                MessageBox.Show("You can't insert empty data", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (salesManCombox.Text.Length == 0 && suppliercombox.Text.Length == 0)
                {
                    MessageBox.Show("You can't insert empty data", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MyContext myContext = new MyContext();

                    decimal _Quantity = QuantityofProductNm.Value;

                    var _product = myContext.product.FirstOrDefault(x => x.Name == productcombox.Text);
                    if (R_D_Supplier.Checked)
                    {
                        decimal _totalPriceProduct = ProductPriceNm.Value * _Quantity;

                        dataGridView1.Rows.Add(_product.Name, ProductPriceNm.Value, _Quantity, _totalPriceProduct, suppliercombox.Text, salesManCombox.Text);

                        totalPrice += _totalPriceProduct;

                        txtTotalprice.Text = totalPrice.ToString();
                    }
                    else
                    {
                        decimal _totalPriceProduct = _product.Price * _Quantity;

                        dataGridView1.Rows.Add(_product.Name, _product.Price, _Quantity, _totalPriceProduct, suppliercombox.Text, salesManCombox.Text);

                        totalPrice += _totalPriceProduct;

                        txtTotalprice.Text = totalPrice.ToString();
                    }
                }
            }
        }

        //Send Values Inserted By User From Fields Below To Database//
        private void BtnAdd_Click(object sender, EventArgs e)
        {   
            try
            {
                var myContext = new MyContext();

                var _purchaseInvoice = new PurchaseInvoice()
                {
                    Total = decimal.Parse(txtTotalprice.Text),
                    Date = DateTime.Now,
                    supplier = myContext.supplier.FirstOrDefault(c => c.Name == suppliercombox.Text),
                    SalesMan = myContext.salesMan.FirstOrDefault(s => s.Name == salesManCombox.Text),
                };
                myContext.purchaseInvoice.Add(_purchaseInvoice);

                foreach (DataGridViewRow item in this.dataGridView1.Rows)
                {
                    //Declare Varibals to Hold return Values From DataGridView For Every Column
                    int _productCount;
                    _productCount = int.Parse(item.Cells["col_Quantity"].Value.ToString());
                    string _productName = item.Cells["col_ProductName"].Value.ToString();
                    //string supplier = item.Cells["col_Supplier"].Value.ToString();
                    //string salesMan = item.Cells["col_SalesMan"].Value.ToString();

                    //Insert Values Which are Stored In Previous Varibals in Database
                    var product = myContext.product.FirstOrDefault(p => p.Name == _productName);
                    //var supllier = myContext.supplier.FirstOrDefault(p => p.Name == supplier);
                    //var salesMann = myContext.salesMan.FirstOrDefault(p => p.Name == salesMan);

                    product.Count += _productCount;

                    if (R_D_Supplier.Checked)
                    {
                        product.Price = ProductPriceNm.Value + (ProductPriceNm.Value * 10 / 100);
                        //Create an Object From Purchase Invlice To Send Inserted Data By it
                        PurchaseInvoiceProduct buyPrice = new PurchaseInvoiceProduct()
                        {
                            CountofProduct = _productCount,
                            Product = product,
                            PurchasingPrice = (decimal)item.Cells["col_ProductPrice"].Value,
                            PriceofTotalProduct = _productCount * (decimal)item.Cells["col_ProductPrice"].Value,
                        };

                        myContext.purchaseInvoiceProducts.Add(buyPrice);

                    }
                    else 
                    {
                        PurchaseInvoiceProduct buyPrice = new PurchaseInvoiceProduct()
                        {
                            CountofProduct = _productCount,
                            Product = product,
                            PurchasingPrice = product.Price,
                            PriceofTotalProduct = _productCount * product.Price,
                        };

                        myContext.purchaseInvoiceProducts.Add(buyPrice);
                        
                    }
                }
                myContext.SaveChanges();

                SuccedLabel.Visible = true;
                totalPrice = 0;
                dataGridView1.Rows.Clear();
                SuccedLabel.Visible = true;
                ProductPriceNm.Value = 0;
                productcombox.Text = "";
                QuantityofProductNm.Value = 0;
                salesManCombox.Text = "";
                txtTotalprice.Text = "";

            }
            catch
            {

                MessageBox.Show("You can't insert empty data", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        //Get The Below Data From Database When From Loaded
        private void PurshaseInvoice_Load(object sender, EventArgs e)
        {
            R_D_SalesMan.Checked = true;
            ProductPriceNm.Visible = false;
            label4.Visible = false;
            var myContext = new MyContext();

            //Fill "suppliercombox" When Load With Names of Supplier//
            var suplliers = myContext.supplier;
            foreach (var _supplier in suplliers)
            {
                suppliercombox.Items.Add(_supplier.Name);
            }

            //Fill "productcombox" When Load With Names of Products//
            var products = myContext.product;
            foreach (var _product in products)
            {
                productcombox.Items.Add(_product.Name);
            }

            //Fill "salesMancombox" When Load With Names of SalesMen//
            var salesMen = myContext.salesMan;
            foreach (var _salesMan in salesMen)
            {
                salesManCombox.Items.Add(_salesMan.Name);
            }

        }

      


        //Delete Row From Datagridview and Decrese its Value From Total Price 
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            //Get "col_ProductPrice Value And Delete it From Total Price Before Send it To Database 
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                totalPrice -= decimal.Parse(item.Cells["col_ProductPrice"].Value.ToString());
                dataGridView1.Rows.RemoveAt(item.Index);
            }

            //Display Total Price Of Invoice Inside Disabled TxtBox
            txtTotalprice.Text = totalPrice.ToString();
        }


        //Switch Btween SalesMan And Customer 
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (R_D_SalesMan.Checked)
            {
                SupplierLabel.Visible = false;
                SalesManLabel.Visible = true;
                suppliercombox.Visible = false;
                salesManCombox.Visible = true;
            }
            else
            {
                SupplierLabel.Visible = true;
                SalesManLabel.Visible = false;
                suppliercombox.Visible = true;
                salesManCombox.Visible = false;


            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (R_D_SalesMan.Checked)
            {
                SupplierLabel.Visible = false;
                SalesManLabel.Visible = true;
                suppliercombox.Visible = false;
                salesManCombox.Visible = true;
                ProductPriceNm.Visible = false;
                label4.Visible = false;
            }
            else
            {
                SupplierLabel.Visible = true;
                SalesManLabel.Visible = false;
                suppliercombox.Visible = true;
                salesManCombox.Visible = false;

                ProductPriceNm.Visible = true;
                label4.Visible = true;
            }
        }

       
    }
}
