using GSM.Finance.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GSM.Finance.Dal.Mapping
{
    public class MovimentoMapping : IEntityTypeConfiguration<Movimento>
    {
        public void Configure(EntityTypeBuilder<Movimento> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("FI_MOVIMENTOS");
        }
    }
}
