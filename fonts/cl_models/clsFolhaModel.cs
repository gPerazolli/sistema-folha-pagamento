using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_models
{
    public class clsFolhaModel
    {
        private static string _mes_ano;
        private static int _id_funcionario;
        private static decimal _salario;
        private static float _percentual_inss;
        private static int _hora_extra;
        private static decimal _salario_hora_extra;
        private static decimal _descontos_totais;
        private static decimal _salario_liquido;
        private static decimal _salario_13;
        private static float _fgts;

        public string Mes_ano
        {
            get { return _mes_ano; }
            set { _mes_ano = value; }
        }

        public int Id_funcionario
        {
            get { return _id_funcionario; }
            set { _id_funcionario = value; }
        }

        public decimal Salario
        {
            get { return _salario; }
            set { _salario = value; }
        }

        public float Percentual_inss
        {
            get { return _percentual_inss; }
            set { _percentual_inss = value; }
        }

        public int Hora_extra
        {
            get { return _hora_extra; }
            set { _hora_extra = value; }
        }

        public decimal Salario_hora_extra
        {
            get { return _salario_hora_extra; }
            set { _salario_hora_extra = value; }
        }

        public decimal Descontos_totais
        {
            get { return _descontos_totais; }
            set { _descontos_totais = value; }
        }

        public decimal Salario_13
        {
            get { return _salario_13; }
            set { _salario_13 = value; }
        }

        public float Fgts
        {
            get { return _fgts; }
            set { _fgts = value; }
        }

        public decimal Salario_liquido
        {
            get { return _salario_liquido; }
            set { _salario_liquido = value; }
        }
    }

}
