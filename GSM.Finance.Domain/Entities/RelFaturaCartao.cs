namespace GSM.Finance.Domain.Entities
{
    public class RelFaturaCartao : Entity
    {
        public Guid FaturaId { get; set; }
        public Guid CartaoId { get; set; }
    }
}
