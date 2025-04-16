using System.Collections.Generic;
using System.Linq;

namespace AutoTorque.Models
{
    public class ServicoCollection : List<Servico>
    {
        public void Adicionar(Servico servico)
        {
            this.Add(servico);
        }

        public void Remover(Servico servico)
        {
            this.Remove(servico);
        }

        public List<Servico> Listar()
        {
            return this.ToList();
        }
    }
}