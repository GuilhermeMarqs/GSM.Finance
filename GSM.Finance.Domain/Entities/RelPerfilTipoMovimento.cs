namespace GSM.Finance.Domain.Entities
{
    public class RelPerfilTipoMovimento : Entity
    {
        public Guid PerfilId { get; set; }
        public virtual required Perfil Perfil { get; set; }
        public Guid TipoMovimentoId { get; set; }
    }
}
