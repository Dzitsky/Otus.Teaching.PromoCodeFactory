using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Configurations
{
    public class PartnerPromoCodeLimitConfiguration : IEntityTypeConfiguration<PartnerPromoCodeLimit>
    {
        public void Configure(EntityTypeBuilder<PartnerPromoCodeLimit> builder)
        {
        }
    }
}
