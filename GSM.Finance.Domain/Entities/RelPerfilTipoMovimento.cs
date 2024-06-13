namespace GSM.Finance.Domain.Entities
{
    public class RelPerfilTipoMovimento
    {
        public int RelPerfilTipoMovimentoId { get; set; }
        public int PerfilId { get; set; }
        public virtual required Perfil Perfil { get; set; }
        public int TipoMovimentoId { get; set; }
    }
}
