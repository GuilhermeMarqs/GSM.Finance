namespace GSM.Finance.Domain.Entities
{
    public class RelMovimentoCartao : Entity
    {
        public Guid MovimentoId { get; set; }
        public Guid CartaoId { get; set; }
    }
}
