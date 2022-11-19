using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.ShowDialog();
            this.Visible = true;
        }
        //public void open()
        //{
        //    Form2 frm = new Form2();
        //    frm.ShowDialog();
        //}

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Visible=true;
            
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
            this.Visible = true;
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.ShowDialog();
            this.Visible = true;
        }

        private void BtnSalesMan_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.ShowDialog();
            this.Visible = true;
        }

        private void BtnInvoice_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide();
            form7.ShowDialog();
            this.Visible = true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PurshaseInvoice form7 = new PurshaseInvoice();
            this.Hide();
            form7.ShowDialog();
            this.Visible = true;
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            Reports form9 = new Reports();
            this.Hide();
            form9.ShowDialog();
            this.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
