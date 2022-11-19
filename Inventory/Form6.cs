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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            SuccedLabel.Visible = false;
        }

        //Send Values Inserted By User From Fields Below To Database//
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Regex _phone_regx = new Regex(@"^01[0-2,5]\d{8}$");
            if (!(_phone_regx.IsMatch(Txt_SalesMan_Phone.Text)))
            {
                MessageBox.Show("Enter a Valid Phone Number!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var myContext = new MyContext();
            try
            {
                //Create an Object From SalesMan To Send Inserted Data By it//
                var salesMan = new SalesMan()
                {
                    Name = Txt_SalesMan_Name.Text,
                    Phone = Txt_SalesMan_Phone.Text,
                    Address = Txt_SalesMan_Address.Text,
                };

                //After Send Values To Database Clear Fileds//
                myContext.salesMan.Add(salesMan);
                Txt_SalesMan_Name.Text = "";
                Txt_SalesMan_Phone.Text = "";
                Txt_SalesMan_Address.Text = "";
                SuccedLabel.Visible = true;
                myContext.SaveChanges();

            }
            catch (Exception a)
            {
                SuccedLabel.Visible = false;
                MessageBox.Show("Inputs Can't be empty", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Back To Main Form And Close Current Form//
        private void BtnCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
