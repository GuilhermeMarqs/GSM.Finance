using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using GSM.Finance.Domain.Entities;

namespace GSM.Finance.Dal.Mapping
{
    public class CartaoMapping : IEntityTypeConfiguration<Cartao>
    {
        public void Configure(EntityTypeBuilder<Cartao> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("FI_CARTOES");
        }
    }
}
