using System;

namespace AutoTorque.Models
{
    public class Pagamento
    {
        public int IdPagamento { get; set; }
        public DateTime DtPagamento { get; set; }
        public int Parcela { get; set; }
        public decimal VlrTotal { get; set; }
        public decimal VlrPago { get; set; }
        public decimal Troco { get; set; }
        public string ObservacaoInterna { get; set; }

    }
}