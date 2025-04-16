using System.Collections.Generic;
using System.Linq;

namespace AutoTorque.Models
{
    public class PagamentoCollection : List<Pagamento>
    {
        public void Adicionar(Pagamento pagamento)
        {
            this.Add(pagamento);
        }

        public void Remover(Pagamento pagamento)
        {
            this.Remove(pagamento);
        }

        public List<Pagamento> Listar()
        {
            return this.ToList();
        }
    }
}