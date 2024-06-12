using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace cl_dal
{
    public class clsConnection
    {
        private static SqlConnection _conexao;
        private static SqlCommand _comandos;
        private static SqlDataAdapter _adptador;
        private static SqlDataReader _reader;
        private static DataTable _tabela;

        private static string _stringconexao =
            "Data Source =LAPTOP-6U1LH3RM\\SQLEXPRESS;" +
            "Initial Catalog =db_folha;" +
            "Integrated Security = True;";
            //"TrustServerCertificate = True;";

        public static SqlConnection obterConexao()
        {
            try
            {
                _conexao = new SqlConnection();
                _conexao.ConnectionString = _stringconexao;
                _conexao.Open();
                return _conexao;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void fecharConexao()
        {
            if(_conexao.State == ConnectionState.Open)
            {
                _conexao.Close();
            }
        }
    }
}