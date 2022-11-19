using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Invoice
    {
        public int ID { get; set; }
        public decimal? Total { get; set; }




        public DateTime? Date { get; set; }
        public SalesMan SalesMan { get; set; }
        public Customer Customer { get; set; }



        //public List<Product> products { get; set; }

        //[ForeignKey("products")]
        //public int productID { get; set; } 



    }
}
