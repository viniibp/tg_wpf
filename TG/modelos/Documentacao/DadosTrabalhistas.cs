using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.modelos.Documentacao
{
    public class DadosTrabalhistas
    {
        public string Cargo { get; set; }
        public string Setor { get; set; }
        public string Registro { get; set; }
        public DateTime DataAdmissao { get; set; }
        public sbyte JornadaTrabalho { get; set; } //6 a 8 horas diarias
        public string Naturalidade { get; set; }
        public string Nacionalidade { get; set; }
        public float Salario { get; set; }

    }
}
