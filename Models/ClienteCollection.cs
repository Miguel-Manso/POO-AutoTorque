using System.Collections.Generic;
using System.Linq;

namespace AutoTorque.Models
{
    public class ClienteCollection : List<Cliente>
    {
        public void Adicionar(Cliente cliente)
        {
            this.Add(cliente);
        }

        public void Remover(Cliente cliente)
        {
            this.Remove(cliente);
        }

        public List<Cliente> Listar()
        {
            return this.ToList();
        }
    }
}