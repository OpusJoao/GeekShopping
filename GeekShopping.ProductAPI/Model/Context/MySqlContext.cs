using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(){}
        public MySqlContext(DbContextOptions<MySqlContext> options): base(options){}

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product{ Id = 2, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 3, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 4, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 5, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 6, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 7, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 8, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 9, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 10, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 11, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 12, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 13, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 14, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 15, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 16, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 17, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 18, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 19, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 20, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 21, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 22, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 23, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" },
                new Product{ Id = 24, Name = "name", Price = new decimal(2000), Description = "description", CategoryName = "informatica", ImageUrl = "localhost" }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
