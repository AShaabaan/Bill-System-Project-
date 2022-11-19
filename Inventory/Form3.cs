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

namespace Inventory
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            SuccedLabel.Visible= false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        //Send Values Inserted By User From Fields Below To Database//
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Regex _phone_regx = new Regex(@"^01[0-2,5]\d{8}$");
            if (!(_phone_regx.IsMatch(txtSuppllierPhone.Text)))
            {
                MessageBox.Show("Enter a Valid Phone Number!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var myContext = new MyContext();
            try
            {
                //Create an Object From Supplier To Send Inserted Data By it//
                var supplier = new Supplier ()
                {
                    Name = txtSuppllierName.Text,
                    Phone = txtSuppllierPhone.Text,
                    Address = txtSpplierAddress.Text,

                };

                //After Send Values To Database Clear Fileds// 
                myContext.supplier.Add(supplier);
                txtSuppllierName.Text = "";
                txtSuppllierPhone.Text = "";
                txtSpplierAddress.Text = "";
                SuccedLabel.Visible = true;
                myContext.SaveChanges();

            }
            catch (Exception a)
            {
                SuccedLabel.Visible = false;
                MessageBox.Show("You Can't Insert Empty Values", "Warning!" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Back To Main Form And Close Current Form//
        private void BtnCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
