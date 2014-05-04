using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RunTextNormalizer.Models.Mapping
{
    public class KeywordMap : EntityTypeConfiguration<Keyword>
    {
        public KeywordMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Keyword1)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.NormalizedKeyword)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Keyword");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ChapterId).HasColumnName("ChapterId");
            this.Property(t => t.Keyword1).HasColumnName("Keyword");
            this.Property(t => t.NormalizedKeyword).HasColumnName("NormalizedKeyword");

            // Relationships
            this.HasRequired(t => t.Chapter)
                .WithMany(t => t.Keywords)
                .HasForeignKey(d => d.ChapterId);

        }
    }
}
