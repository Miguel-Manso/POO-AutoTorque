using AutoTorque.Models;
using AutoTorque.Services;
using System;
using System.Data;

namespace AutoTorque.Controllers
{
    public class PagamentoController
    {
        DataBaseSqlServerService dataBase =
           new DataBaseSqlServerService();

        public int Inserir(Pagamento pagamento)
        {
            string queryInserir =
                "INSERT INTO Pagamento  " +
                "(DtPagamento, Parcela, ValorTotal, ValorPago, Troco, ObservacaoInterna)" +
                "VALUES " +
                "(@DtPagamento, @Parcela, @ValorTotal, @ValorPago, @Troco, @ObservacaoInterna)";

            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@DtPagamento", pagamento.DtPagamento);
            dataBase.AdicionarParametros("@Parcela", pagamento.Parcela);
            dataBase.AdicionarParametros("@ValorTotal", pagamento.VlrTotal);
            dataBase.AdicionarParametros("@ValorPago", pagamento.VlrPago);
            dataBase.AdicionarParametros("@Troco", pagamento.Troco);
            dataBase.AdicionarParametros("@ObservacaoInterna", pagamento.ObservacaoInterna);

            dataBase.ExecutarManipulacao(
                CommandType.Text, queryInserir);

            return
                Convert.ToInt32(
                    dataBase.ExecutarConsultaScalar(
                        CommandType.Text,
                        "SELECT MAX(IdPagamento) FROM Pagamento"));
        }

        public int Alterar(Pagamento pagamento)
        {
            string queryAlterar =
                "UPDATE Pagamento SET " +
                "DtPagamento = @DtPagamento, " +
                "Parcela = @Parcela," +
                "ValorTotal = @ValorTotal, " +
                "ValorPago = @ValorPago, " +
                "Troco = @Troco, " +
                "ObservacaoInterna = @ObservacaoInterna " +
                "WHERE IdPagamento = @IdPagamento";

            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@DtPagamento", pagamento.DtPagamento);
            dataBase.AdicionarParametros("@Parcela", pagamento.Parcela);
            dataBase.AdicionarParametros("@ValorTotal", pagamento.VlrTotal);
            dataBase.AdicionarParametros("@ValorPago", pagamento.VlrPago);
            dataBase.AdicionarParametros("@Troco", pagamento.Troco);
            dataBase.AdicionarParametros("@ObservacaoInterna", pagamento.ObservacaoInterna);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryAlterar);
        }

        public int Apagar(int IdPagamento)
        {
            string queryApagar =
                "DELETE FROM Pagamento " +
                "WHERE IdPagamento = @IdPagamento";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdPagamento", IdPagamento);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryApagar);
        }

        public PagamentoCollection carregarPagamento()
        {
            string queryConsulta =
                   "SELECT * FROM Pagamento";

            dataBase.LimparParametros();

            DataTable dataTable =
                dataBase.ExecutarConsulta(
                    CommandType.Text, queryConsulta);

            PagamentoCollection pagamentos = new PagamentoCollection();

            foreach (DataRow row in dataTable.Rows)
            {
                Pagamento pagamento = new Pagamento
                {
                    IdPagamento = Convert.ToInt32(row["IdPagamento"]),
                    DtPagamento = Convert.ToDateTime(row["DtPagamento"]),
                    Parcela = Convert.ToInt32(row["Parcela"]),
                    VlrTotal = Convert.ToDecimal(row["ValorTotal"]),
                    VlrPago = Convert.ToDecimal(row["ValorPago"]), 
                    Troco = Convert.ToDecimal(row["Troco"]),
                    ObservacaoInterna = Convert.ToString(row["ObservacaoInterna"])
                };
                pagamentos.Add(pagamento);
            }

            return pagamentos;
        }

        public Pagamento ConsultarPorId(int IdPagamento)
        {
            string queryConsulta =
                "SELECT * FROM Pagamento " +
                "WHERE IdPagamento = @IdPagamento";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdPagamento", IdPagamento);

            DataTable dataTable =
                dataBase.ExecutarConsulta(
                    CommandType.Text, queryConsulta);

            if (dataTable.Rows.Count > 0)
            {
                Pagamento pagamento = new Pagamento();

                pagamento.IdPagamento =
                    Convert.ToInt32(
                        dataTable.Rows[0]["IdPagamento"]);
                pagamento.DtPagamento =
                    Convert.ToDateTime(
                        dataTable.Rows[0]["DtPagamento"]);
                pagamento.Parcela =
                    Convert.ToInt32(
                        dataTable.Rows[0]["Parcela"]);
                pagamento.VlrTotal =
                    Convert.ToDecimal(
                        dataTable.Rows[0]["ValorTotal"]);
                pagamento.VlrPago =
                    Convert.ToDecimal(
                        dataTable.Rows[0]["ValorPago"]);
                pagamento.Troco =
                    Convert.ToDecimal(
                        dataTable.Rows[0]["Troco"]);
                pagamento.ObservacaoInterna =
                    Convert.ToString(
                        dataTable.Rows[0]["ObservacaoInterna"]);

                return pagamento;
            }
            else

                return null;
        }
    }
}
