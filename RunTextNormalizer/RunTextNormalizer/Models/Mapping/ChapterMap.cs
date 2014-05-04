using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RunTextNormalizer.Models.Mapping
{
    public class ChapterMap : EntityTypeConfiguration<Chapter>
    {
        public ChapterMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Text)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Chapter");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Section).HasColumnName("Section");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Text).HasColumnName("Text");
        }
    }
}
