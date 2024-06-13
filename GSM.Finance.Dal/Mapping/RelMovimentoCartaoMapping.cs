using GSM.Finance.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GSM.Finance.Dal.Mapping
{
    public class RelMovimentoCartaoMapping : IEntityTypeConfiguration<RelMovimentoCartao>
    {
        public void Configure(EntityTypeBuilder<RelMovimentoCartao> builder)
        {
            builder.ToTable("FI_REL_MOVIMENTO_CARTAO");
        }
    }
}
