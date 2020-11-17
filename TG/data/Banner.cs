using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.data
{
    public class Banner
    {
        public string Nome { get; set; }
        public string URL { get; set; }

        public Banner(string nome, string url)
        {
            Nome = nome;
            URL = url;
        }
    }
}
