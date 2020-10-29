using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.modelos.Documentacao
{
    public class CarteiraTrabalho
    {
        public string Numero { get; set; }
        public string Serie { get; set; }

        public CarteiraTrabalho(string numero, string serie)
        {
            Numero = numero;
            Serie = serie;
        }
    }
}
