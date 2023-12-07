using BlogASPNET.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogASPNET.Data.Mappings{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
          //Table
          builder.ToTable("Category");

          //Primary key
          builder.HasKey(x => x.Id);

          //Identity
          builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

          //Properties
          builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("NVARCHAR()")
            .HasMaxLength(80);

          builder.Property(x => x.Slug)
            .IsRequired()
            .HasColumnName("Slug")
            .HasColumnType("VARCHAR()")
            .HasMaxLength(80);

          //Indices
          builder.HasIndex(x => x.Slug, "IX_Category_Slug").IsUnique();
        }
    }
}