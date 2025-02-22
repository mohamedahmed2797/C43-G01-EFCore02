using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_EFCore02
{
    internal class ItiConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(c=>c.FName).IsRequired();
            builder.Property(c => c.FName).HasColumnName("FirstName");
            builder.Property(c => c.LName).HasColumnName("LastName");
            builder.Property(d => d.Address).HasMaxLength(100);

            
        }
    }
}
