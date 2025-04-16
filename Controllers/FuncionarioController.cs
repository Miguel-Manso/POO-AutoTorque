using AutoTorque.Models;
using AutoTorque.Services;
using System.Data;
using System;
using AutoTorque.Views;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace AutoTorque.Controllers
{
    public class FuncionarioController
    {
        DataBaseSqlServerService dataBase =
           new DataBaseSqlServerService();

        public int Inserir(Funcionario funcionario)
        {
            string queryInserir =
                "INSERT INTO Funcionario " +
                "(Nome, Cargo, Salario, Endereco) " +
                "VALUES " +
                "(@Nome, @Cargo, @Salario, @Endereco)";

            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@Nome", funcionario.Nome);
            dataBase.AdicionarParametros("@Cargo", funcionario.Cargo);
            dataBase.AdicionarParametros("@Salario", funcionario.Salario);
            dataBase.AdicionarParametros("@Endereco", funcionario.Endereco);

            dataBase.ExecutarManipulacao(
                CommandType.Text, queryInserir);

            return
                Convert.ToInt32(
                    dataBase.ExecutarConsultaScalar(
                        CommandType.Text,
                        "SELECT MAX(IdFuncionario) FROM Funcionario"));
        }

        public int Alterar(Funcionario funcionario)
        {
            string queryAlterar =
                "UPDATE Funcionario SET " +
                "Nome = @Nome, " +
                "Cargo = @Cargo," +
                "Salario = @Salario, " +
                "Endereco = @Endereco " +
                "WHERE IdFuncionario = @IdFuncionario";

            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@Nome", funcionario.Nome);
            dataBase.AdicionarParametros("@Cargo", funcionario.Cargo);
            dataBase.AdicionarParametros("@Salario", funcionario.Salario);
            dataBase.AdicionarParametros("@Endereco", funcionario.Endereco);
            dataBase.AdicionarParametros("@IdFuncionario", funcionario.IdFuncionario);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryAlterar);
        }

        public int Apagar(int IdFuncionario)
        {
            string queryApagar =
                "DELETE FROM Funcionario " +
                "WHERE IdFuncionario = @IdFuncionario";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdFuncionario", IdFuncionario);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryApagar);
        }

        public FuncionarioCollection carregarFuncionario()
        {
            string queryConsulta =
                   "SELECT * FROM Funcionario";

            dataBase.LimparParametros();

            DataTable dataTable =
                dataBase.ExecutarConsulta(
                    CommandType.Text, queryConsulta);

            FuncionarioCollection funcionarios = new FuncionarioCollection();

            foreach (DataRow row in dataTable.Rows)
            {
                Funcionario funcionario = new Funcionario
                {
                    IdFuncionario = Convert.ToInt32(row["IdFuncionario"]),
                    Nome = Convert.ToString(row["Nome"]),
                    Cargo = Convert.ToString(row["Cargo"]),
                    Salario = Convert.ToDecimal(row["Salario"]),
                    Endereco = Convert.ToString(row["Endereco"])
                };
                funcionarios.Add(funcionario);
            }

            return funcionarios;
        }

        public Funcionario ConsultarPorId(int IdFuncionario)
        {
            string queryConsulta =
                "SELECT * FROM Funcionario " +
                "WHERE IdFuncionario = @IdFuncionario";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdFuncionario", IdFuncionario);

            DataTable dataTable =
                dataBase.ExecutarConsulta(
                    CommandType.Text, queryConsulta);

            if (dataTable.Rows.Count > 0)
            {
                Funcionario funcionario = new Funcionario();

                funcionario.IdFuncionario =
                    Convert.ToInt32(
                        dataTable.Rows[0]["IdFuncionario"]);
                funcionario.Nome =
                    Convert.ToString(
                        dataTable.Rows[0]["Nome"]);
                funcionario.Cargo =
                    Convert.ToString(
                        dataTable.Rows[0]["Cargo"]);
                funcionario.Salario =
                    Convert.ToDecimal(
                        dataTable.Rows[0]["Salario"]);
                funcionario.Endereco =
                    Convert.ToString(
                        dataTable.Rows[0]["Endereco"]);

                return funcionario;
            }
            else
                return null;
        }

    }
}
