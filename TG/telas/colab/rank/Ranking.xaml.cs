using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TG.telas.colab.rank.Controles;

namespace TG.telas.colab.rank
{
    /// <summary>
    /// Interação lógica para Ranking.xam
    /// </summary>
    public partial class Ranking : Page
    {
        public Ranking()
        {
            InitializeComponent();
            InfoColaborador infoColab = new InfoColaborador();
            Load(infoColab);
            infoColaborador.Content = infoColab;
        }
        public void Load(InfoColaborador colaborador)
        {
            List<string> dados = new List<string> { "string", "botato", "ynhasuo", "string", "botato", "ynhasuo", "string", "botato", "ynhasuo" };
            foreach (var dado in dados)
            {
               
                topfuncionarios topFuncionarios = new topfuncionarios(dado);
                topFuncionarios.Setcolab(colaborador);
                painel.Children.Add(topFuncionarios);

            }
        }

        
    }
}
