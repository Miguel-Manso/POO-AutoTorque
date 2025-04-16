using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace AutoTorque.Models
{
    public class Servico
    {
        public int IdServico { get; set; }
        public string Descricao { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        public string Categoria { get; set; }
        public Funcionario Funcionario { get; set; }
        public Pagamento Pagamento { get; set; } = new Pagamento();

        public string DtInicioCategoriaVlrTotalParcela
        {
            get
            {
                return DtInicio + " - " + Categoria + " - " + Pagamento.VlrTotal + " - " + Pagamento.Parcela;
            }
        }
    }
}