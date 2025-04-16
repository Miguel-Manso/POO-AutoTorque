namespace AutoTorque.Models
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public string Endereco { get; set; }

        public string NomeCargoSalario
        {
            get
            {
                return Nome + " - " + Cargo + " - " + Salario;
            }
        }
    }
}