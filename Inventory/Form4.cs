using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            SuccedLabel.Visible = false;
        }

        //Send Values Inserted By User From Fields Below To Database//
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Regex _phone_regx = new Regex(@"^01[0-2,5]\d{8}$");
            if (!(_phone_regx.IsMatch(txtCustomerPhone.Text)))
            {
                MessageBox.Show("Enter a Valid Phone Number!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var myContext = new MyContext();
            try
            {
                //Create an Object From Customer To Send Inserted Data By it//
                var customer = new Customer()
                {
                    Name = txtCustomerName.Text,
                    Phone = txtCustomerPhone.Text,
                    Address = txtCustomerAddress.Text,
                };

                //After Send Values To Database Clear Fileds//
                myContext.customer.Add(customer);
                txtCustomerName.Text = "";
                txtCustomerPhone.Text = "";
                txtCustomerAddress.Text = "";
                SuccedLabel.Visible = true;
                myContext.SaveChanges();

            }
            catch (Exception a)
            {   
                SuccedLabel.Visible = false;
                MessageBox.Show("Inputs can not be empty", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Back To Main Form And Close Current Form
        private void BtnCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
