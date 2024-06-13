
using DemoExam.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DemoExam.Database
{
    internal class ExamContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new SqlConnectionStringBuilder();
            builder.InitialCatalog = "demoexam";
            builder.DataSource = "localhost";
            builder.UserID = "sa";
            builder.Password = "123";
            builder.Encrypt = false;
            builder.IntegratedSecurity = false;

            optionsBuilder.UseSqlServer(builder.ConnectionString);
        }

        public DbSet<Client> Clients => Set<Client>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Product> Products => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
