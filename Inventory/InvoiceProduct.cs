using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class InvoiceProduct
    {

        public int InvoiceID { get; set; }
        public int ProductID { get; set; }

        public Invoice Invoice { get; set; }
        public Product Product { get; set; }


        public int CountofProduct { get; set; }
        public decimal PriceofTotalProduct { get; set; }



    }
}
