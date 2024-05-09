namespace GSM.Finance.Dal.Entities
{
    public class Cartao
    {
        public int CartaoId { get; set; }  
        public BandeiraCartaoEnum Bandeira { get; set; }
        public string FechamentoFatura { get; set; }
        public decimal Limite { get; set; }
    }
}
