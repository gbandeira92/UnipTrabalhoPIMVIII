using Microsoft.EntityFrameworkCore;

namespace PIMVIII.Models
{
    public class MainContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Telephone> Telephone { get; set; }
        public DbSet<TelephoneType> TelephoneType { get; set; }

        public MainContext(DbContextOptions<MainContext> options) : base(options) { }
    }
}
