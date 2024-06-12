using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cl_models;
using System.Runtime.CompilerServices;

namespace cl_dal
{
    public class clsFuncionariosDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataAdapter _adaptador;
        private SqlDataReader _leitor;
        private DataTable _tabela;

        public clsFuncionariosModel ObterPorId(int idFuncionario)
        {
            clsFuncionariosModel funcionario = null;

            try
            {
                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "select id_funcionario, nome, cpf, cargo, data_admissao, ctps, situacao" +
                                        " from funcionarios" +
                                        " where id_funcionario = @id_funcionario;";
                _comandos.Parameters.Add("@id_funcionario", SqlDbType.Int).Value = idFuncionario;

                _leitor = _comandos.ExecuteReader();

                if (_leitor.HasRows)
                {
                    _leitor.Read();

                    funcionario = new clsFuncionariosModel
                    {
                        Id_funcionario = Convert.ToInt32(_leitor["id_funcionario"]),
                        Nome = _leitor["nome"].ToString(),
                        Cpf = _leitor["cpf"].ToString(),
                        Cargo = _leitor["cargo"].ToString(),
                        Data_admissao = Convert.ToDateTime(_leitor["data_admissao"]),
                        Ctps = _leitor["ctps"].ToString(),
                        Situacao = Convert.ToBoolean(_leitor["situacao"])
                    };
                }

                _leitor.Close();
                clsConnection.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return funcionario;
        }

          
        public int GetNovoId()
        {
            Int32 novoId = 1;

            _conexao = clsConnection.obterConexao();

            _comandos = new SqlCommand();
            _comandos.Connection = _conexao;
            _comandos.CommandText = "select (max(id_funcionario) + 1) from funcionarios;";

            novoId = Int32.Parse(_comandos.ExecuteScalar().ToString());

            clsConnection.fecharConexao();

            return novoId;
        }

        public void Inserir(clsFuncionariosModel parFuncionarios)
        {
            Int32 id = GetNovoId();

            try
            {
                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "insert into funcionarios(id_funcionario, nome, cpf, cargo, data_admissao, ctps, situacao)" +
                                        "values (@id_funcionario, @nome, @cpf, @cargo, @data_admissao, @ctps, @situacao);";
                _comandos.Parameters.Add("@id_funcionario", SqlDbType.Int).Value = id;
                _comandos.Parameters.Add("@nome", SqlDbType.VarChar).Value = parFuncionarios.Nome;
                _comandos.Parameters.Add("@cpf", SqlDbType.VarChar).Value = parFuncionarios.Cpf;
                _comandos.Parameters.Add("@cargo", SqlDbType.VarChar).Value = parFuncionarios.Cargo;
                _comandos.Parameters.Add("@data_admissao", SqlDbType.Date).Value = parFuncionarios.Data_admissao;
                _comandos.Parameters.Add("@ctps", SqlDbType.VarChar).Value = parFuncionarios.Ctps;
                _comandos.Parameters.Add("@situacao", SqlDbType.Bit).Value = parFuncionarios.Situacao;

                _comandos.ExecuteNonQuery();

                clsConnection.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Atualizar(clsFuncionariosModel parFuncionarios)
        {
            _conexao = clsConnection.obterConexao();

            _comandos = new SqlCommand();
            _comandos.Connection = _conexao;
            _comandos.CommandText = "update funcionarios " +
                                    "  set nome = @nome," +
                                    "      cpf = @cpf," +
                                    "      cargo = @cargo," +
                                    "      data_admissao = @data_admissao," +
                                    "      ctps = @ctps," +
                                    "      situacao = @situacao  " +
                                    " where id_funcionario = @id_funcionario;";
            _comandos.Parameters.Add("@id_funcionario", SqlDbType.Int).Value = parFuncionarios.Id_funcionario;
            _comandos.Parameters.Add("@nome", SqlDbType.VarChar).Value = parFuncionarios.Nome;
            _comandos.Parameters.Add("@cpf", SqlDbType.VarChar).Value = parFuncionarios.Cpf;
            _comandos.Parameters.Add("@cargo", SqlDbType.VarChar).Value = parFuncionarios.Cargo;
            _comandos.Parameters.Add("@data_admissao", SqlDbType.Date).Value = parFuncionarios.Data_admissao;
            _comandos.Parameters.Add("@ctps", SqlDbType.VarChar).Value = parFuncionarios.Ctps;
            _comandos.Parameters.Add("@situacao", SqlDbType.Bit).Value = parFuncionarios.Situacao;

            _comandos.ExecuteNonQuery();

            clsConnection.fecharConexao();
        }

        public DataTable ListarTodos()
        {
            _conexao = clsConnection.obterConexao();

            _comandos = new SqlCommand();
            _comandos.Connection = _conexao;
            _comandos.CommandText = "select id_funcionario, nome, cpf, cargo, data_admissao, ctps, situacao" +
                                    " from funcionarios" +
                                    "   order by nome asc; ";

            _tabela = new DataTable();

            _adaptador = new SqlDataAdapter(_comandos );
            _adaptador.Fill(_tabela);

            return _tabela;
        }

    }
}
