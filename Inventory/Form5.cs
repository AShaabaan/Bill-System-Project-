using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            SuccedLabel.Visible = false;
            Update_Label.Visible = false;
            Delete_Label.Visible = false;

        }

        //Send Values Inserted By User From Fields Below To Database//
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var myContext = new MyContext();
            try
            {   //Create an Object From Product To Send Inserted Data By it//
                var product = new Product()
                {
                    Name = txtProductName.Text,
                    Count = (int)N_U_D_ProductCount.Value,
                    Price = N_U_D_ProductPrice.Value,
                    category = myContext.categorie.FirstOrDefault(x => x.Name == categoryCombox.Text),
                };
                
                //After Send Values To Database Clear Fileds//
                myContext.product.Add(product);
                txtProductName.Text = "";
                N_U_D_ProductPrice.Value = 0;  
                N_U_D_ProductCount.Value = 0;
                categoryCombox.Text = "";
                SuccedLabel.Visible = true;
                myContext.SaveChanges();

            }
            catch (Exception a)
            {
                SuccedLabel.Visible = false;
                MessageBox.Show("Inputs can't be empty", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //Back To Main Form And Close Current Form//
        private void BtnCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Fill ComboBox When Load With Names of Categories// 
        private void Form5_Load(object sender, EventArgs e)
        {
            var myContext = new MyContext();
            var _Category = myContext.categorie;

            // Fill categoryCombox When Load With Names of Category //
            foreach (var item in _Category)
            {
                categoryCombox.Items.Add(item.Name);
            }

            // Fill C_Box_Upt_Product When Load With Names of Products //
            var _Product = myContext.product;
            foreach (var item in _Product)
            {
                C_Box_Upt_Product.Items.Add(item.Name);
            }
        }

        private void C_Box_Upt_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get Selected Product Values From Database  
            MyContext myContext = new MyContext();
            var _ProductSelect = myContext.product.FirstOrDefault(p => p.Name == C_Box_Upt_Product.Text);

            //Fill Fields by Returned Data From Database To Modify it
            categoryCombox.SelectedIndex  = _ProductSelect.CategoryID - 1;
            txtProductName.Text = _ProductSelect.Name;
            N_U_D_ProductPrice.Value = _ProductSelect.Price;
            N_U_D_ProductCount.Value = _ProductSelect.Count;

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {

            if (C_Box_Upt_Product.Text.Length == 0)
            {
                MessageBox.Show("You Can't Insert Empty Data", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(txtProductName.Text.Length== 0)
                {
                    MessageBox.Show("You Can't Update Empty Data", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MyContext myContext = new MyContext();
                    var _ProductSelect = myContext.product.FirstOrDefault(p => p.Name == C_Box_Upt_Product.Text);
                    _ProductSelect.Name = txtProductName.Text;
                    _ProductSelect.category = myContext.categorie.FirstOrDefault(x => x.Name == categoryCombox.Text);
                    _ProductSelect.Price = N_U_D_ProductPrice.Value;
                    _ProductSelect.Count = (int)N_U_D_ProductCount.Value;

                    myContext.Entry(_ProductSelect).State = EntityState.Modified;
                    myContext.SaveChanges();
                    Update_Label.Visible = true;


                    //Clear Fields After Update
                    C_Box_Upt_Product.Text="";
                    txtProductName.Text = "";
                    N_U_D_ProductPrice.Value = 0;
                    N_U_D_ProductCount.Value = 0;
                    categoryCombox.SelectedValue = "";

                }

            }
            


        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (C_Box_Upt_Product.Text.Length == 0)
            {
                MessageBox.Show("You Can't Delete Empty Data", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                //Delete Product and Its Values From Database
                MyContext myContext = new MyContext();
                var _ProductSelect = myContext.product.FirstOrDefault(p => p.Name == C_Box_Upt_Product.Text);
                myContext.Entry(_ProductSelect).State = EntityState.Deleted;
                myContext.SaveChanges();
                Delete_Label.Visible = true;

                //Clear Fields After Delete
                C_Box_Upt_Product.Text = "";
                txtProductName.Text = "";
                N_U_D_ProductPrice.Value = 0;
                N_U_D_ProductCount.Value = 0;
                categoryCombox.Text = "";
            }
            

        }
    }
}
