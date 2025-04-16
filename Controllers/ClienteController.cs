using AutoTorque.Models;
using AutoTorque.Services;
using System.Data;
using System;

namespace AutoTorque.Controllers
{
    public class ClienteController
    {
        DataBaseSqlServerService dataBase =
            new DataBaseSqlServerService();

        public int Inserir(Cliente cliente)
        {
            string queryInserir =
                "INSERT INTO Cliente " +
                "(Nome, Cpf, Telefone, Endereco) " +
                "VALUES " +
                "(@Nome, @Cpf, @Telefone, @Endereco)";

            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@Nome", cliente.Nome);
            dataBase.AdicionarParametros("@Cpf", cliente.CPF);
            dataBase.AdicionarParametros("@Telefone", cliente.Telefone);
            dataBase.AdicionarParametros("@Endereco", cliente.Endereco);

            dataBase.ExecutarManipulacao(
                CommandType.Text, queryInserir);

            return
                Convert.ToInt32(
                    dataBase.ExecutarConsultaScalar(
                        CommandType.Text,
                        "SELECT MAX(IdCliente) FROM Cliente"));
        }

        public int Alterar(Cliente cliente)
        {
            string queryAlterar =
                "UPDATE Cliente SET " +
                "Nome = @Nome, " +
                "Cpf = @Cpf," +
                "Telefone = @Telefone, " +
                "Endereco = @Endereco " +
                "WHERE IdCliente = @IdCliente";

            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@Nome", cliente.Nome);
            dataBase.AdicionarParametros("@Cpf", cliente.CPF);
            dataBase.AdicionarParametros("@Telefone", cliente.Telefone);
            dataBase.AdicionarParametros("@Endereco", cliente.Endereco);
            dataBase.AdicionarParametros("@IdCliente", cliente.IdCliente);
                
            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryAlterar);
        }

        public int Apagar(int IdCliente)
        {
            string queryApagar =
                "DELETE FROM Cliente " +
                "WHERE IdCliente = @IdCliente";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdCliente", IdCliente);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryApagar);
        }

        public ClienteCollection carregarCliente()
        {
            string queryConsulta =
                   "SELECT * FROM Cliente ORDER BY Nome ASC";

            dataBase.LimparParametros();

            DataTable dataTable =
                dataBase.ExecutarConsulta(
                    CommandType.Text, queryConsulta);

            ClienteCollection clientes = new ClienteCollection();

            foreach (DataRow row in dataTable.Rows)
            {
                Cliente cliente = new Cliente
                {
                    IdCliente = Convert.ToInt32(row["IdCliente"]), 
                    Nome = Convert.ToString(row["Nome"]),
                    CPF = Convert.ToString(row["Cpf"]),
                    Endereco = Convert.ToString(row["Endereco"]),
                    Telefone = Convert.ToString(row["Telefone"])
                };
                clientes.Add(cliente);
            }

            return clientes;
        }

        public Cliente ConsultarPorId(int IdCliente)
        {
            string queryConsulta =
                "SELECT * FROM Cliente " +
                "WHERE IdCliente = @IdCliente";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdCliente", IdCliente);

            DataTable dataTable =
                dataBase.ExecutarConsulta(
                    CommandType.Text, queryConsulta);

            if (dataTable.Rows.Count > 0)
            {
                Cliente cliente = new Cliente();

                cliente.IdCliente =
                    Convert.ToInt32(
                        dataTable.Rows[0]["IdCliente"]);
                cliente.Nome =
                    Convert.ToString(
                        dataTable.Rows[0]["Nome"]);
                cliente.CPF =
                    Convert.ToString(
                        dataTable.Rows[0]["Cpf"]);
                cliente.Telefone =
                    Convert.ToString(
                        dataTable.Rows[0]["Telefone"]);
                cliente.Endereco =
                    Convert.ToString(
                        dataTable.Rows[0]["Endereco"]);

                return cliente;
            }
            else

                return null;
        }
    }
}