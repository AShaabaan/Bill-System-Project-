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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SuccedLabel.Visible= false;
        }

        //Back To Main Form And Close Current Form
        private void BtnCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Send Values Inserted By User From Fields Below To Database
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
            var myContext = new MyContext();
            try
            {
                //Create an Object From Category To Send Inserted Data By it
                var category = new Category()
                {
                    //ID = int.Parse(textBox1.Text)
                    Name = textBox1.Text,
                   
                };

                //After Send Values To Database Clear Fileds 
                myContext.categorie.Add(category);
                textBox1.Text = "";
                SuccedLabel.Visible= true;
                myContext.SaveChanges();

            }
            catch (Exception a)
            {
                SuccedLabel.Visible = false;
                MessageBox.Show("You Can't Send Empty Values", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        
    }
}
