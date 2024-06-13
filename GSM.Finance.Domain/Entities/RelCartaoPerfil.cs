namespace GSM.Finance.Domain.Entities
{
    public class RelCartaoPerfil : Entity
    {
        public Guid PerfilId { get; set; }
        public Guid CartaoId { get; set; }
    }
}
