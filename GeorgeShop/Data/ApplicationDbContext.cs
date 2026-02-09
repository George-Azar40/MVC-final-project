using GeorgeShop.Models;
using Microsoft.EntityFrameworkCore;

namespace GeorgeShop.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=db38620.public.databaseasp.net; Database=db38620; User Id=db38620; Password=7d_Mp!T38Fa%; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;");
          
            
            //optionsBuilder.UseSqlServer("Data Source=.;Database=MVC-13;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

            optionsBuilder.UseSqlServer("Data Source=.;Database=MVC-13;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
