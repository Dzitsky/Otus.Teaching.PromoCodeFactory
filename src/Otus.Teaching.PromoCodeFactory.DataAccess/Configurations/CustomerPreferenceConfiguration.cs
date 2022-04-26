using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Configurations
{
    public class CustomerPreferenceConfiguration : IEntityTypeConfiguration<CustomerPreference>
    {
        public void Configure(EntityTypeBuilder<CustomerPreference> builder)
        {
            builder
                .ToTable("CustomerPreferences")
                .HasKey(x => new { x.CustomerId, x.PreferenceId });

            builder
                .HasOne(x => x.Customer)
                .WithMany(x => x.Preferences)
                .HasForeignKey(x => x.CustomerId);

            builder
                .HasOne(x => x.Preference)
                .WithMany()
                .HasForeignKey(x => x.PreferenceId);
        }
    }
}
