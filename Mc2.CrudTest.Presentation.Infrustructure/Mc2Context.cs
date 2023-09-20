using Mc2.CrudTest.Presentation.Domain;
using Microsoft.EntityFrameworkCore;

namespace Mc2.CrudTest.Presentation.Infrustructure
{
    public class Mc2Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = default!;

        private static bool _created = false;
        public Mc2Context()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureCreated();
            }
        }
        public Mc2Context(DbContextOptions<Mc2Context> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.1.101;User Id=sa;PWD=123;Database=Mc2DBTest;TrustServerCertificate=Yes;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>(e =>
            {
                e.HasIndex(x => new { x.FirstName, x.LastName, x.DateOfBirth }).IsUnique();
            });
        }
    }
}