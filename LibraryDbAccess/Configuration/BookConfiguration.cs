using LibraryConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDbAccess.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Comment).HasMaxLength(50);

            builder.Property(e => e.IdAuthor).HasColumnName("Id_Author");

            builder.Property(e => e.IdCategory).HasColumnName("Id_Category");

            builder.Property(e => e.IdPress).HasColumnName("Id_Press");

            builder.Property(e => e.IdThemes).HasColumnName("Id_Themes");

            builder.Property(e => e.Name).HasMaxLength(100);

            builder.HasOne(d => d.IdAuthorNavigation)
                .WithMany(p => p.Books)
                .HasForeignKey(d => d.IdAuthor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Books_Author");

            builder.HasOne(d => d.IdCategoryNavigation)
                .WithMany(p => p.Books)
                .HasForeignKey(d => d.IdCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Books_Category");

            builder.HasOne(d => d.IdPressNavigation)
                .WithMany(p => p.Books)
                .HasForeignKey(d => d.IdPress)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Books_Press");

            builder.HasOne(d => d.IdThemesNavigation)
                .WithMany(p => p.Books)
                .HasForeignKey(d => d.IdThemes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Books_Theme");
        }
    }
}
