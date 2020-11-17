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
            new Banner("Posto Ipiranga", caminho+"logo1.jpg"),
            new Banner("Maria ta errada fodase 2", caminho+"logo2.jpg"),
            new Banner("Maria ta errada fodase 3", caminho+"logo3.jpg"),
            new Banner("Maria ta errada fodase 4", caminho+"logo4.jpg"),
            new Banner("Maria ta errada fodase 5", caminho+"logo5.jpg"),
            new Banner("Maria ta errada fodase 6", caminho+"logo6.jpg"),
            new Banner("Maria ta errada fodase 7", caminho+"logo7.jpg"),
            new Banner("Maria ta errada fodase 8", caminho+"logo8.jpg"),
        };
    }
}
