using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Configurations
{
    public class PromoCodeConfiguration : IEntityTypeConfiguration<PromoCode>
    {
        public void Configure(EntityTypeBuilder<PromoCode> builder)
        {
            builder
                .ToTable("PromoCodes")
                .HasKey(x => x.Id);

            builder
                .Property(x => x.ServiceInfo)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .Property(x => x.BeginDate)
                .IsRequired();

            builder
                .Property(x => x.EndDate)
                .IsRequired();

            builder
                .Property(x => x.PartnerName)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .HasOne(x => x.PartnerManager)
                .WithMany();

            builder
                .HasOne(x => x.Preference)
                .WithMany();
        }
    }
}
