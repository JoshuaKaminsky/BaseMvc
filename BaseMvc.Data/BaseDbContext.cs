using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BaseMvc.Data.Seed;
using BaseMvc.Model;

namespace BaseMvc.Data
{
    internal class BaseDbContext : DbContext
    {
        public BaseDbContext()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<User> Users { get; set; }

        static BaseDbContext()
        {
            Database.SetInitializer(new DbSeeder());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
