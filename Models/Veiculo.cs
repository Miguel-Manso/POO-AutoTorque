namespace AutoTorque.Models
{
    public class Veiculo
    {
        public int IdVeiculo { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public Cliente Cliente { get; set; }
        public string ModeloMarcaPlaca
        {
            get
            {
                return Modelo + " - " + Marca + " - " + Placa;
            }
        }
    }
}