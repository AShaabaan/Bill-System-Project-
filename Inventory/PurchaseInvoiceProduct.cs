using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class PurchaseInvoiceProduct
    {
        

        public int PurchaseInvoiceID { get; set; }
        public int ProductID { get; set; }

        public PurchaseInvoice PurchaseInvoice { get; set; }
        public Product Product { get; set; }

        [Required]
        public decimal PurchasingPrice { get; set; }

        public int CountofProduct { get; set; }
        public decimal PriceofTotalProduct { get; set; }

    }
}
