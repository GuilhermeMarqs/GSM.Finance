using GSM.Finance.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GSM.Finance.Dal.Mapping
{
    public class RelCartaoPerfilMapping : IEntityTypeConfiguration<RelCartaoPerfil>
    {
        public void Configure(EntityTypeBuilder<RelCartaoPerfil> builder)
        {
            builder.HasKey(p => p.PerfilId);

            builder.ToTable("FI_REL_CARTAO_PERFIL");
        }
    }
   
}
