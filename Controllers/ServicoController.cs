using AutoTorque.Models;
using AutoTorque.Services;
using System;
using System.Data;
using System.Linq;

namespace AutoTorque.Controllers
{
    public class ServicoController
    {
        DataBaseSqlServerService dataBase =
          new DataBaseSqlServerService();

        public int Inserir(Servico servico)
        {
            string queryInserir =
                "INSERT INTO Servico  " +
                "(Descricao, DtInicio, DtFim, Categoria, FkIdFuncionario)" +
                "VALUES " +
                "(@Descricao, @DtInicio, @DtFim, @Categoria, @FkIdFuncionario)";

            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@Descricao", servico.Descricao);
            dataBase.AdicionarParametros("@DtInicio", servico.DtInicio);
            dataBase.AdicionarParametros("@DtFim", servico.DtFim);
            dataBase.AdicionarParametros("@Categoria", servico.Categoria);
            dataBase.AdicionarParametros("@FkIdFuncionario", servico.Funcionario.IdFuncionario);


            dataBase.ExecutarManipulacao(
                CommandType.Text, queryInserir);

            return
                Convert.ToInt32(
                    dataBase.ExecutarConsultaScalar(
                        CommandType.Text,
                        "SELECT MAX(IdServico) FROM Servico"));
        }

        public int Alterar(Servico servico)
        {
            string queryAlterar =
                "UPDATE Servico SET " +
                "Descricao = @Descricao, " +
                "DtInicio = @DtInicio," +
                "DtFim = @DtFim, " +
                "Categoria = @Categoria, " +
                "FkIdFuncionario = @FkIdFuncionario " +
                "WHERE IdServico = @IdServico";

            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@Descricao", servico.Descricao);
            dataBase.AdicionarParametros("@DtInicio", servico.DtInicio);
            dataBase.AdicionarParametros("@DtFim", servico.DtFim);
            dataBase.AdicionarParametros("@Categoria", servico.Categoria);
            dataBase.AdicionarParametros("@FkIdFuncionario", servico.Funcionario.IdFuncionario);
            dataBase.AdicionarParametros("@IdServico", servico.IdServico);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryAlterar);
        }

        public int Apagar(int IdServico)
        {
            string queryApagar =
                "DELETE FROM Servico " +
                "WHERE IdServico = @IdServico";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdServico", IdServico);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryApagar);
        }

        public ServicoCollection carregarServico()
        {
            FuncionarioController funcionarioController = new FuncionarioController();
            PagamentoController pagamentoController = new PagamentoController();
            string queryConsulta =
                   "SELECT * FROM Servico";

            dataBase.LimparParametros();

            DataTable dataTable =
                dataBase.ExecutarConsulta(
                    CommandType.Text, queryConsulta);

            ServicoCollection servicos = new ServicoCollection();

            foreach (DataRow row in dataTable.Rows)
            {
                Servico servico = new Servico
                {
                    IdServico = Convert.ToInt32(row["IdServico"]),
                    Descricao = Convert.ToString(row["Descricao"]),
                    DtInicio = Convert.ToDateTime(row["DtInicio"]),
                    DtFim = Convert.ToDateTime(row["DtFim"]),
                    Categoria = Convert.ToString(row["Categoria"])
                };

                int funcionarioId = Convert.ToInt32(dataTable.Rows[0]["FkIdFuncionario"]);
                servico.Funcionario = funcionarioController.ConsultarPorId(funcionarioId);

                Pagamento pagamento = pagamentoController.ConsultarPorId(servico.IdServico); 
                servico.Pagamento = pagamento;


                servicos.Add(servico);
            }

            return servicos;
        }

        public Servico ConsultarPorId(int IdServico)
        {
            string queryConsulta =
                "SELECT * FROM Servico " +
                "WHERE IdServico = @IdServico";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdServico", IdServico);

            DataTable dataTable =
                dataBase.ExecutarConsulta(
                    CommandType.Text, queryConsulta);

            if (dataTable.Rows.Count > 0)
            {
                Servico servico = new Servico();

                servico.IdServico =
                    Convert.ToInt32(
                        dataTable.Rows[0]["IdServico"]);
                servico.DtInicio =
                    Convert.ToDateTime(
                        dataTable.Rows[0]["DtInicio"]);
                servico.DtFim =
                    Convert.ToDateTime(
                        dataTable.Rows[0]["DtFim"]);
                servico.Categoria =
                    Convert.ToString(
                        dataTable.Rows[0]["Categoria"]);
                servico.Descricao =
                   Convert.ToString(
                       dataTable.Rows[0]["Descricao"]);
                servico.Funcionario.IdFuncionario =
                    Convert.ToInt32(
                        dataTable.Rows[0]["FkIdFuncionario"]);

                return servico;
            }
            else

                return null;
        }
    }
}
