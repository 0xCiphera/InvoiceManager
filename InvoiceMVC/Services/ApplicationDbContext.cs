using InvoiceMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoiceMVC.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Invoice> Invoices { get; set; } = null!;

        //protected ApplicationDbContext()
        //{
        //}
    }
}
