using System.Data.SqlClient;
using System.Data;
using System;

namespace AutoTorque.Services
{
    public class DataBaseSqlServerService
    {
        private SqlConnection CriarConexao()
        {
            SqlConnection conexao =
                new SqlConnection();

            conexao.ConnectionString =
                "Data Source=localhost;" + //Servidor
                "Initial Catalog=AutoTorque;" + //Nome do Banco
                "Integrated Security=True;" + //Autenticação do Windows (usuario logado)
                "User Instance=false;"; //Usar o usuario da maquina

            conexao.Open();
            return conexao;
        }

        private
            SqlParameterCollection sqlParameterCollection =
             new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void
            AdicionarParametros(
                string nomeParametro,
                object valorParametro)
        {
            sqlParameterCollection.Add(
                new SqlParameter(
                    nomeParametro, valorParametro));
        }

        public int ExecutarManipulacao(
            CommandType commandType,
            string nomeStoredeOuTextoSql)
        {
            try
            {
                SqlConnection sqlConnection =
                    CriarConexao();

                SqlCommand sqlCommand =
                    sqlConnection.CreateCommand();

                sqlCommand.CommandType = commandType;

                sqlCommand.CommandText =
                    nomeStoredeOuTextoSql;

                foreach (SqlParameter sqlParameter
                    in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(
                        sqlParameter.ParameterName,
                        sqlParameter.Value);
                }

                return sqlCommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw new Exception(
                    "Houve uma falha ao executar " +
                    "o comando no banco de dados. " +
                    "\r\n" +
                    "Mensagem original: " +
                    ex.Message);
            }
        }

        public DataTable ExecutarConsulta(
            CommandType commandType,
            string nomeStoredeOuTextoSql)
        {
            try
            {
                SqlConnection sqlConnection =
                    CriarConexao();

                SqlCommand sqlCommand =
                    sqlConnection.CreateCommand();

                sqlCommand.CommandType = commandType;

                sqlCommand.CommandText =
                    nomeStoredeOuTextoSql;

                foreach (SqlParameter sqlParameter
                    in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(
                        sqlParameter.ParameterName,
                        sqlParameter.Value);
                }

                SqlDataAdapter sqlDataAdapter =
                    new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Houve uma falha ao executar " +
                    "a consulta no banco de dados. " +
                    "\r\n" +
                    "Mensagem original: " +
                    ex.Message);
            }
        }

        public object ExecutarConsultaScalar(
            CommandType commandType,
            string nomeStoredeOuTextoSql)
        {
            try
            {
                SqlConnection sqlConnection =
                    CriarConexao();

                SqlCommand sqlCommand =
                    sqlConnection.CreateCommand();

                sqlCommand.CommandType = commandType;

                sqlCommand.CommandText =
                    nomeStoredeOuTextoSql;

                foreach (SqlParameter sqlParameter
                    in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(
                        sqlParameter.ParameterName,
                        sqlParameter.Value);
                }

                return sqlCommand.ExecuteScalar();

            }

            catch (Exception ex)
            {
                throw new Exception(
                    "Houve uma falha ao executar " +
                    "a consulta scalar no banco de dados. " +
                    "\r\n" +
                    "Mensagem original: " +
                    ex.Message);
            }
        }
    }
}