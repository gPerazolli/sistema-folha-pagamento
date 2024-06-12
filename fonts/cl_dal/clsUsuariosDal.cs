using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cl_models;

namespace cl_dal
{
    public class clsUsuariosDal
    {

        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataAdapter _adaptador;
        private SqlDataReader _leitor;
        private DataTable _tabela;

        public int GetNovoId()
        {
            Int32 novoId = 1;

            _conexao = clsConnection.obterConexao();

            _comandos = new SqlCommand();
            _comandos.Connection = _conexao;
            _comandos.CommandText = "select (max(id_usu) + 1) from usuarios;";

            novoId = Int32.Parse(_comandos.ExecuteScalar().ToString());

            clsConnection.fecharConexao();

            return novoId;
        }

        public void Inserir(clsUsuariosModel parUsuarios)
        {
            Int32 id = GetNovoId();

            try
            {
                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "insert into usuarios(id_usu, nome_usu, login_usu, senha_usu)" +
                                        "values (@id_usu, @nome_usu, @login_usu, @senha_usu);";
                _comandos.Parameters.Add("@id_usu", SqlDbType.Int).Value = id;
                _comandos.Parameters.Add("@nome_usu", SqlDbType.VarChar).Value = parUsuarios.Nome_usu;
                _comandos.Parameters.Add("@login_usu", SqlDbType.VarChar).Value = parUsuarios.Login_usu;
                _comandos.Parameters.Add("@senha_usu", SqlDbType.VarChar).Value = parUsuarios.Senha_usu;

                _comandos.ExecuteNonQuery();

                clsConnection.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Atualizar(clsUsuariosModel parUsuarios)
        {
            _conexao = clsConnection.obterConexao();

            _comandos = new SqlCommand();
            _comandos.Connection = _conexao;
            _comandos.CommandText = "update usuarios " +
                                    "  set nome_usu = @nome_usu," +
                                    "      login_usu = @login_usu," +
                                    "      senha_usu = @senha_usu" +
                                    " where id_usu = @id_usu;";
            _comandos.Parameters.Add("@id_usu", SqlDbType.Int).Value = parUsuarios.Id_usu;
            _comandos.Parameters.Add("@nome_usu", SqlDbType.VarChar).Value = parUsuarios.Nome_usu;
            _comandos.Parameters.Add("@login_usu", SqlDbType.VarChar).Value = parUsuarios.Login_usu;
            _comandos.Parameters.Add("@senha_usu", SqlDbType.VarChar).Value = parUsuarios.Senha_usu;

            _comandos.ExecuteNonQuery();

            clsConnection.fecharConexao();
        }

        public void Excluir(int parIdUsuario)
        {
            _conexao = clsConnection.obterConexao();

            _comandos = new SqlCommand();
            _comandos.Connection = _conexao;
            _comandos.CommandText = "delete from usuarios" +
                                    " where id_usu = @id_usu;";
            _comandos.Parameters.Add("id_usu", SqlDbType.Int).Value = parIdUsuario;

            _comandos.ExecuteNonQuery();

            clsConnection.fecharConexao();
        }

        public DataTable ListarTodos()
        {
            _conexao = clsConnection.obterConexao();

            _comandos = new SqlCommand();
            _comandos.Connection = _conexao;
            _comandos.CommandText = "select * from usuarios" +
                                    "   order by nome_usu asc";

            _tabela = new DataTable();

            _adaptador = new SqlDataAdapter(_comandos);
            _adaptador.Fill(_tabela);

            return _tabela;
        }
    }
}
