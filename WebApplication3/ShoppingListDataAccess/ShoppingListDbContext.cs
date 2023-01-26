using Microsoft.EntityFrameworkCore;

namespace WebApplication3.ShoppingListDataAccess
{
    public class ShoppingListDbContext : DbContext
    {
        public DbSet<ShoppingItem> ShoppingItems { get; set; }

        public ShoppingListDbContext(DbContextOptions<ShoppingListDbContext> options) : base(options)
        {

        }
    }
}
