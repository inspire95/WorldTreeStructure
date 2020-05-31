using World.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace World.DAL
{
    public class TreeContext : DbContext
    {

        public TreeContext() : base("TreeContext")
        {
        }

        public DbSet<Tree> Trees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}