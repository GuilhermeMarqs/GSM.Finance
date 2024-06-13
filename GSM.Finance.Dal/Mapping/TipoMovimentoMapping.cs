using GSM.Finance.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GSM.Finance.Dal.Mapping
{
    public class TipoMovimentoMapping : IEntityTypeConfiguration<TipoMovimento>
    {
        public void Configure(EntityTypeBuilder<TipoMovimento> builder)
        {
            builder.ToTable("FI_TIPO_MOVIMENTO");
        }
    }
}
