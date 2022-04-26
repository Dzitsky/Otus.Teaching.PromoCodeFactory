using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .ToTable("Customers")
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
                .HasMany(x => x.Preferences)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.CustomerId);

            builder
                .HasMany(x => x.PromoCodes)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}