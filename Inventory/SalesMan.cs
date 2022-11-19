using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class SalesMan
    {
        public int ID { get; set; }

        [Required , MaxLength (50)]
        public string Name { get; set; }
        [Required , MaxLength(15)]
        public string Phone { get; set; }
        [Required , MaxLength (100)]
        public string Address { get; set; }
    }
}
