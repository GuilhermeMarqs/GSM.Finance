namespace GSM.Finance.Dal.Entities
{
    public class Faturas
    {
        public List<Movimento> MovimentosFatura { get; set; }
        public DateTime DataVencimento { get; set; }
        
    }
}
