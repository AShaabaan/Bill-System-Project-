using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Product
    {
        public int ID { get; set; }
        
        [Required, MaxLength(50)]
        public string Name { get; set; }
        
        [Required]
        public int Count { get; set; }
        
        [Required]
        public decimal Price { get; set; }
        
        [Required]
        public int CategoryID { get; set; }

        [ForeignKey ("CategoryID")]
        public virtual Category category { get; set; }



        //public List<Invoice> invoices { get; set; }
        //public Invoice invoice { get; set; }


        //[ForeignKey("category")]
        //public int ? categtory_id { get; set; }   



    }
}
