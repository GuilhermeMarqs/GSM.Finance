using GSM.Finance.Domain.Enums;

namespace GSM.Finance.Domain.Entities
{
    public class Cartao : Entity
    {
        public BandeiraCartaoEnum Bandeira { get; set; }
        public string FechamentoFatura { get; set; }
        public decimal Limite { get; set; }
    }
}
