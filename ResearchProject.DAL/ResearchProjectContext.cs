using Microsoft.EntityFrameworkCore;
using ResearchProject.Models;

namespace ResearchProject.DAL
{
    public class ResearchProjectContext : DbContext
    {
        public ResearchProjectContext(DbContextOptions<ResearchProjectContext> options)
            : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Addres> Addresses { get; set; }
    }
}