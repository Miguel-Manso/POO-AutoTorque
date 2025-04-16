using System.Collections.Generic;
using System.Linq;

namespace AutoTorque.Models
{
    public class VeiculoCollection : List<Veiculo>
    {
        public void Adicionar(Veiculo veiculo)
        {
            this.Add(veiculo);
        }

        public void Remover(Veiculo veiculo)
        {
            this.Remove(veiculo);
        }

        public List<Veiculo> Listar()
        {
            return this.ToList();
        }
    }
}