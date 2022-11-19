using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;

namespace Inventory
{
    public partial class MyContext : DbContext
    {
        public MyContext()
            : base(@"Data Source=.;Initial Catalog=InventoryDB;Integrated Security=True")
        {
        }
        public DbSet<Category> categorie { get; set; }
        public DbSet<Supplier> supplier { get; set; }
        public DbSet<SalesMan> salesMan { get; set; }
        public DbSet<Customer> customer { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<Invoice> invoice { get; set; }
        public DbSet<PurchaseInvoice> purchaseInvoice { get; set; }
        public DbSet<InvoiceProduct> invoiceProducts { get; set; }
        public DbSet<PurchaseInvoiceProduct> purchaseInvoiceProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvoiceProduct>().HasKey(c => new { c.InvoiceID,  c.ProductID });
            modelBuilder.Entity<PurchaseInvoiceProduct>().HasKey(c=> new {c.PurchaseInvoiceID, c.ProductID});
        }




    }
}
