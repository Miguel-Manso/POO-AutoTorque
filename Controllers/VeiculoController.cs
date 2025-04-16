using AutoTorque.Models;
using AutoTorque.Services;
using System;
using System.Data;

namespace AutoTorque.Controllers
{
    public class VeiculoController
    {
        DataBaseSqlServerService dataBase =
          new DataBaseSqlServerService();

        public int Inserir(Veiculo veiculo)
        {
            string queryInserir =
                "INSERT INTO Veiculo  " +
                "(Modelo, Marca, Ano, Placa, FkIdCliente)" +
                "VALUES " +
                "(@Modelo, @Marca, @Ano, @Placa, @FkIdCliente)";

            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@Modelo", veiculo.Modelo);
            dataBase.AdicionarParametros("@Marca", veiculo.Marca);
            dataBase.AdicionarParametros("@Ano", veiculo.Ano);
            dataBase.AdicionarParametros("@Placa", veiculo.Placa);
            dataBase.AdicionarParametros("@FkIdCliente", veiculo.Cliente.IdCliente);

            dataBase.ExecutarManipulacao(
                CommandType.Text, queryInserir);

            return
                Convert.ToInt32(
                    dataBase.ExecutarConsultaScalar(
                        CommandType.Text,
                        "SELECT MAX(IdVeiculo) FROM Veiculo"));
        }

        public int Alterar(Veiculo veiculo)
        {
            string queryAlterar =
                "UPDATE Veiculo SET " +
                "Modelo = @Modelo, " +
                "Marca = @Marca," +
                "Ano = @Ano, " +
                "Placa = @Placa, " +
                "FkIdCliente = @FkIdCliente " +
                "WHERE IdVeiculo = @IdVeiculo";

            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@Modelo", veiculo.Modelo);
            dataBase.AdicionarParametros("@Marca", veiculo.Marca);
            dataBase.AdicionarParametros("@Ano", veiculo.Ano);
            dataBase.AdicionarParametros("@Placa", veiculo.Placa);
            dataBase.AdicionarParametros("@FkIdCliente", veiculo.Cliente.IdCliente);
            dataBase.AdicionarParametros("@IdVeiculo", veiculo.IdVeiculo); 

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryAlterar);
        }

        public int Apagar(int IdVeiculo)
        {
            string queryApagar =
                "DELETE FROM Veiculo " +
                "WHERE IdVeiculo = @IdVeiculo";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdVeiculo", IdVeiculo);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryApagar);
        }

        public VeiculoCollection carregarVeiculo()
        {
            ClienteController clienteController = new ClienteController();

            string queryConsulta =
                   "SELECT * FROM Veiculo";

            dataBase.LimparParametros();

            DataTable dataTable =
                dataBase.ExecutarConsulta(
                    CommandType.Text, queryConsulta);

            VeiculoCollection veiculos = new VeiculoCollection();

            foreach (DataRow row in dataTable.Rows)
            {
                Veiculo veiculo = new Veiculo
                {
                    IdVeiculo = Convert.ToInt32(row["IdVeiculo"]),
                    Modelo = Convert.ToString(row["Modelo"]),
                    Marca = Convert.ToString(row["Marca"]),
                    Ano = Convert.ToInt32(row["Ano"]),
                    Placa = Convert.ToString(row["Placa"])
                };

                int clienteId = Convert.ToInt32(dataTable.Rows[0]["FkIdCliente"]);
                veiculo.Cliente = clienteController.ConsultarPorId(clienteId);

                veiculos.Add(veiculo);
            }

            return veiculos;
        }

        public Veiculo ConsultarPorId(int IdVeiculo)
        {
            string queryConsulta =
                "SELECT * FROM Veiculo " +
                "WHERE IdVeiculo = @IdVeiculo";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdVeiculo", IdVeiculo);

            DataTable dataTable =
                dataBase.ExecutarConsulta(
                    CommandType.Text, queryConsulta);

            if (dataTable.Rows.Count > 0)
            {
                Veiculo veiculo = new Veiculo();

                veiculo.IdVeiculo =
                    Convert.ToInt32(
                        dataTable.Rows[0]["IdVeiculo"]);
                veiculo.Modelo =
                    Convert.ToString(
                        dataTable.Rows[0]["Modelo"]);
                veiculo.Marca =
                    Convert.ToString(
                        dataTable.Rows[0]["Marca"]);
                veiculo.Ano =
                    Convert.ToInt32(
                        dataTable.Rows[0]["Ano"]);
                veiculo.Placa =
                    Convert.ToString(
                        dataTable.Rows[0]["Placa"]);
                veiculo.Cliente.IdCliente =
                 Convert.ToInt32(
                     dataTable.Rows[0]["FkIdCliente"]);


                return veiculo;
            }
            else

                return null;
        }
    }
}
