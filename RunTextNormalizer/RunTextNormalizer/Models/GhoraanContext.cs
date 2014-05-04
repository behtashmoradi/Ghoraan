using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RunTextNormalizer.Models.Mapping;

namespace RunTextNormalizer.Models
{
    public partial class GhoraanContext : DbContext
    {
        static GhoraanContext()
        {
            Database.SetInitializer<GhoraanContext>(null);
        }

        public GhoraanContext()
            : base("Name=GhoraanContext")
        {
        }

        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Keyword> Keywords { get; set; }
 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ChapterMap());
            modelBuilder.Configurations.Add(new KeywordMap());
         }
    }
}
