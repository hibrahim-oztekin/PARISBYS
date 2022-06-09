using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class ParisDitibContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=DitibParis;Integrated Security=True;");
        }
        public DbSet<BkBolges> BkBolges { get; set; }
        public DbSet<CrcmUyelikFormDurums> CrcmUyelikFormDurums { get; set; }
        public DbSet<Derneks> Derneks { get; set; }
        public DbSet<KurulusKanuns> KurulusKanuns { get; set; }
        public DbSet<Sehirs> Sehirs { get; set; }
    }
}
