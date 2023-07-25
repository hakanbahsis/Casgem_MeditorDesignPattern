using Microsoft.EntityFrameworkCore;

namespace WebUI.DAL
{
    public class Context:DbContext
    {
        public Context()
        {
            
        }
        public Context(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
