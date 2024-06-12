using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cl_models
{
    public class clsFuncionariosModel
    {
        private int _id_funcionario;
        private string _nome;
        private string _cpf;
        private string _cargo;
        private DateTime _data_admissao;
        private string _ctps;
        private bool _situacao;

        public int Id_funcionario
        {
            get { return _id_funcionario; }
            set { _id_funcionario = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
        
        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        public DateTime Data_admissao
        {
            get { return _data_admissao; }
            set { _data_admissao = value; }
        }

        public string Ctps
        {
            get { return _ctps; }
            set { _ctps = value; }
        }

        public bool Situacao
        {
            get { return _situacao; }
            set { _situacao = value; }
        }
    }
}
