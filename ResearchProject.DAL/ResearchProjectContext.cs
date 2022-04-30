using Microsoft.EntityFrameworkCore;
using ResearchProject.Models;

namespace ResearchProject.DAL
{
    public class ResearchProjectContext : DbContext
    {
        public ResearchProjectContext(DbContextOptions<ResearchProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Veterinary> Veterinaries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}