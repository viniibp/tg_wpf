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
using TG.modelos;

namespace TG.telas.colab.rank
{
    /// <summary>
    /// Interação lógica para InfoColaborador.xam
    /// </summary>
    public partial class InfoColaborador : Page
    {
        public InfoColaborador()
        {
            InitializeComponent();
        }
       public void Carregardadosinfo(string nome)
        {
            colocacao.Content = 1;
            nivel.Content = 21;
            nCursos.Content = 6;
            nomeUsuario.Content = nome;
        }
    }
}
