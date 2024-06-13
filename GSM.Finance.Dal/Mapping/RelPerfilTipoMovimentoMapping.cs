using GSM.Finance.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GSM.Finance.Dal.Mapping
{
    public class RelPerfilTipoMovimentoMapping : IEntityTypeConfiguration<RelPerfilTipoMovimento>
    {
        public void Configure(EntityTypeBuilder<RelPerfilTipoMovimento> builder)
        {
            builder.ToTable("FI_REL_PERFIL_TIPO_MOVIMENTO");
        }
    }
}
