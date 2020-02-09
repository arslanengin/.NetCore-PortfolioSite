using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Mapping
{
    public class WorkMap : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {
            builder.HasKey(t => t.WorkID);
            builder.Property(t => t.WorkName).IsRequired();
            builder.HasOne(c => c.Category).WithMany(t => t.Works).HasForeignKey(t => t.CategoryID);
            builder.HasMany(t => t.Photos).WithOne(t => t.Work).HasForeignKey(t => t.WorkID);
        }
    }
}
