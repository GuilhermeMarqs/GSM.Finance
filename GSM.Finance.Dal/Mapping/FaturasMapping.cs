using GSM.Finance.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GSM.Finance.Dal.Mapping
{
    public class FaturasMapping : IEntityTypeConfiguration<Faturas>
    {
        public void Configure(EntityTypeBuilder<Faturas> builder)
        {
            builder.HasKey(p => p.FaturaId);

            builder.ToTable("FI_FATURAS");
        }
    }
}
