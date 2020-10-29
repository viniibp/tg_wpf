using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.modelos.Documentacao
{
    public class Documentos
    {
        public string CPF { get; set; }
        public string RG { get; set; }
        public CarteiraTrabalho CarteiraTrabalho { get; set; }
        public string TituloEleitoral { get; set; }
        public string NumeroReservista { get; set; }
        public string UrlFoto { get; set; }
    }
}
