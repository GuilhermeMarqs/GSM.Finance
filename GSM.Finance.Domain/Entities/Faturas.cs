namespace GSM.Finance.Domain.Entities
{
    public class Faturas : Entity
    {
        public List<Movimento> MovimentosFatura { get; set; }
        public DateTime DataVencimento { get; set; }

    }
}
