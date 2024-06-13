﻿using GSM.Finance.Domain.Enums;

namespace GSM.Finance.Domain.Entities
{
    public class Movimento : Entity
    {
        public MovimentoEnum Tipo { get; set; }
        public required DateTime DataInclusão { get; set; }   
        public required string Descricao { get; set; }
        public bool Efetivado { get; set; }
        public decimal Valor {  get; set; }
        public Guid? TipoMovimentoId { get; set; }
        public int? FaturaId { get; set; }
    }
}
