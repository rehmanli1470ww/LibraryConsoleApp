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
    public class TCardConfiguration : IEntityTypeConfiguration<TCard>
    {
        public void Configure(EntityTypeBuilder<TCard> builder)
        {
            builder.ToTable("T_Cards");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.DateIn).HasColumnType("datetime");

            builder.Property(e => e.DateOut).HasColumnType("datetime");

            builder.Property(e => e.IdBook).HasColumnName("Id_Book");

            builder.Property(e => e.IdLib).HasColumnName("Id_Lib");

            builder.Property(e => e.IdTeacher).HasColumnName("Id_Teacher");

            builder.HasOne(d => d.IdBookNavigation)
                .WithMany(p => p.TCards)
                .HasForeignKey(d => d.IdBook)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_T_Cards_Book");

            builder.HasOne(d => d.IdLibNavigation)
                .WithMany(p => p.TCards)
                .HasForeignKey(d => d.IdLib)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_T_Cards_Lib");

            builder.HasOne(d => d.IdTeacherNavigation)
                .WithMany(p => p.TCards)
                .HasForeignKey(d => d.IdTeacher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_T_Cards_Teacher");
        }
    }
}
