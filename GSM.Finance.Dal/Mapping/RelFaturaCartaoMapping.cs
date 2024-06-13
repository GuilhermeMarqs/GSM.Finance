using GSM.Finance.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GSM.Finance.Dal.Mapping
{
    public class RelFaturaCartaoMapping : IEntityTypeConfiguration<RelFaturaCartao>
    {
        public void Configure(EntityTypeBuilder<RelFaturaCartao> builder)
        {
            builder.ToTable("FI_REL_FATURA_CARTAO");
        }
    }
}
