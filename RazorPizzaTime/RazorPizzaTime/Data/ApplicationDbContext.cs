using Microsoft.EntityFrameworkCore;
using RazorPizzaTime.Models;

namespace RazorPizzaTime.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrderModel> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
