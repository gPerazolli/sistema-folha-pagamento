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
    public class clsFolhaDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataAdapter _adaptador;
        private SqlDataReader _leitor;
        private DataTable _tabela;

        public clsFolhaModel ObterPorId(int idFuncionario, string mesAno)
        {
            clsFolhaModel folha = null;

            try
            {
                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "select * from folha" +
                                        " where id_funcionario = @id_funcionario and mes_ano = @mes_ano;";
                _comandos.Parameters.Add("@id_funcionario", SqlDbType.Int).Value = idFuncionario;
                _comandos.Parameters.AddWithValue("@mes_ano", mesAno);

                _leitor = _comandos.ExecuteReader();

                if (_leitor.HasRows)
                {
                    _leitor.Read();

                    folha = new clsFolhaModel
                    {
                        Mes_ano = _leitor["mes_ano"].ToString(),
                        Id_funcionario = Convert.ToInt32(_leitor["id_funcionario"]),
                        Salario = decimal.Parse(_leitor["salario"].ToString()),
                        Percentual_inss = float.Parse(_leitor["percentual_inss"].ToString()),
                        Hora_extra = int.Parse(_leitor["hora_extra"].ToString()),
                        Salario_hora_extra = decimal.Parse(_leitor["salario_hora_extra"].ToString()),
                        Descontos_totais = decimal.Parse(_leitor["descontos_totais"].ToString()),
                        Salario_13 = decimal.Parse(_leitor["salario_13"].ToString()),
                        Fgts = float.Parse(_leitor["fgts"].ToString()),
                        Salario_liquido = decimal.Parse(_leitor["salario_liquido"].ToString()),
                    };
                }

                _leitor.Close();
                clsConnection.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return folha;
        }

        public void Inserir(clsFolhaModel parFolha)
        {
            _conexao = clsConnection.obterConexao();

            _comandos = new SqlCommand();
            _comandos.Connection = _conexao;
            _comandos.CommandText = "insert into folha(mes_ano, id_funcionario, salario, percentual_inss, hora_extra, salario_hora_extra, descontos_totais, salario_liquido, salario_13, fgts) " +
                                    "values (@mes_ano, @id_funcionario, @salario, @percentual_inss, @hora_extra, @salario_hora_extra, @descontos_totais, @salario_liquido, @salario_13, @fgts)";
            _comandos.Parameters.Add("@mes_ano", SqlDbType.VarChar).Value = parFolha.Mes_ano;
            _comandos.Parameters.Add("@id_funcionario", SqlDbType.Int).Value = parFolha.Id_funcionario;
            _comandos.Parameters.Add("@salario", SqlDbType.Decimal).Value = parFolha.Salario;
            _comandos.Parameters.Add("@percentual_inss", SqlDbType.Float).Value = parFolha.Percentual_inss;
            _comandos.Parameters.Add("@hora_extra", SqlDbType.Int).Value = parFolha.Hora_extra;
            _comandos.Parameters.Add("@salario_hora_extra", SqlDbType.Decimal).Value = parFolha.Salario_hora_extra;
            _comandos.Parameters.Add("@descontos_totais", SqlDbType.Decimal).Value = parFolha.Descontos_totais;
            _comandos.Parameters.Add("@salario_liquido", SqlDbType.Decimal).Value = parFolha.Salario_liquido;
            _comandos.Parameters.Add("@salario_13", SqlDbType.Decimal).Value = parFolha.Salario_13;
            _comandos.Parameters.Add("@fgts", SqlDbType.Float).Value = parFolha.Fgts;

            _comandos.ExecuteNonQuery();

            clsConnection.fecharConexao();
        }

        public void Atualizar(clsFolhaModel parFolha)
        {
            _conexao = clsConnection.obterConexao();

            _comandos = new SqlCommand();
            _comandos.Connection = _conexao;
            _comandos.CommandText = "update folha " +
                                    "     set salario = @salario," +
                                    "     percentual_inss = @percentual_inss," +
                                    "     hora_extra = @hora_extra," +
                                    "     salario_hora_extra = @salario_hora_extra," +
                                    "     descontos_totais = @descontos_totais," +
                                    "     salario_liquido = @salario_liquido," +
                                    "     salario_13 = @salario_13," +
                                    "     fgts = @fgts" +
                                    " where id_funcionario = @id_funcionario;";
            _comandos.Parameters.Add("@mes_ano", SqlDbType.VarChar).Value = parFolha.Mes_ano;
            _comandos.Parameters.Add("@id_funcionario", SqlDbType.Int).Value = parFolha.Id_funcionario;
            _comandos.Parameters.Add("@salario", SqlDbType.Decimal).Value = parFolha.Salario;
            _comandos.Parameters.Add("@percentual_inss", SqlDbType.Float).Value = parFolha.Percentual_inss;
            _comandos.Parameters.Add("@hora_extra", SqlDbType.Int).Value = parFolha.Hora_extra;
            _comandos.Parameters.Add("@salario_hora_extra", SqlDbType.Decimal).Value = parFolha.Salario_hora_extra;
            _comandos.Parameters.Add("@descontos_totais", SqlDbType.Decimal).Value = parFolha.Descontos_totais;
            _comandos.Parameters.Add("@salario_liquido", SqlDbType.Decimal).Value = parFolha.Salario_liquido;
            _comandos.Parameters.Add("@salario_13", SqlDbType.Decimal).Value = parFolha.Salario_13;
            _comandos.Parameters.Add("@fgts", SqlDbType.Float).Value = parFolha.Fgts;

            _comandos.ExecuteNonQuery();

            clsConnection.fecharConexao();
        }

        public void Excluir(int parIdFolha, string parMesFuncionario)
        {
            _conexao = clsConnection.obterConexao();

            _comandos = new SqlCommand();
            _comandos.Connection = _conexao;
            _comandos.CommandText = "delete from folha" +
                                    " where id_funcionario = @id_funcionario and mes_ano = @mes_ano;";
            _comandos.Parameters.Add("id_funcionario", SqlDbType.Int).Value = parIdFolha;
            _comandos.Parameters.Add("@mes_ano", SqlDbType.VarChar).Value = parMesFuncionario;

            _comandos.ExecuteNonQuery();

            clsConnection.fecharConexao();
        }

        public DataTable ListarTodos()
        {
            _conexao = clsConnection.obterConexao();

            _comandos = new SqlCommand();
            _comandos.Connection = _conexao;
            _comandos.CommandText = "select * from folha" +
                                    "   order by mes_ano";

            _tabela = new DataTable();

            _adaptador = new SqlDataAdapter(_comandos);
            _adaptador.Fill(_tabela);

            return _tabela;
        }
    }
}
