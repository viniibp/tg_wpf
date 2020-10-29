using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.modelos.Documentacao
{
    public class DadosPessoais
    {
        public sbyte Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public sbyte QtdFilhos { get; set; }
        public string EstadoCivil { get; set; }
        public string Sexo { get; set; }
        public string Genero { get; set; }
    }
}
