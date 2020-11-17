using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.data
{
    static class Data
    {
        private static string caminho = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory.ToString()) + "\\..\\..//Assets//logo_banners//";

        public static List<Banner> banners = new List<Banner>
        {
            new Banner("UNIPRO", caminho+"logo1.jpg"),
            new Banner("ESPAÇO DO SABER", caminho+"logo2.jpg"),
            new Banner("EVOLUÇÂO CURSOS", caminho+"logo3.jpg"),
            new Banner("DUOCHAP", caminho+"logo4.jpg"),
            new Banner("AGILITY PERFORMANCE", caminho+"logo5.jpg"),
            new Banner("GREENCODE", caminho+"logo6.jpg"),
            new Banner("IDEIA CURSOS", caminho+"logo7.jpg"),
            new Banner("DALE DELE", caminho+"logo8.jpg"),
        };
    }
}
