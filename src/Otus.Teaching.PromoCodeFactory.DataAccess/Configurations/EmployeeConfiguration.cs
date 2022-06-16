using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;
using System;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .ToTable("Employees")
                .HasKey(x => x.Id);

            builder
                .Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(x => x.AppliedPromocodesCount)
                .IsRequired();

            builder
                .HasOne(x => x.Role)
                .WithMany()
                .HasForeignKey(x => x.RoleId);
        }
    }
}
