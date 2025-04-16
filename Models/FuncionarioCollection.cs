using System.Collections.Generic;
using System.Linq;

namespace AutoTorque.Models
{
    public class FuncionarioCollection : List<Funcionario>
    {
        public void Adicionar(Funcionario funcionario)
        {
            this.Add(funcionario);
        }

        public void Remover(Funcionario funcionario)
        {
            this.Remove(funcionario);
        }

        public List<Funcionario> Listar()
        {
            return this.ToList();
        }
    }
}