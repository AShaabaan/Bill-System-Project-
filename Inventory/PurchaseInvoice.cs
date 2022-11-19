using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class PurchaseInvoice
    {
        public int Id { get; set; }
        
        [Required]
        public decimal Total { get; set; }
        
        //[Required]
        //public Product product { get; set; }
        
        public DateTime? Date { get; set; }
        public Supplier supplier { get; set; }
        public SalesMan SalesMan { get; set; }

    }
}
