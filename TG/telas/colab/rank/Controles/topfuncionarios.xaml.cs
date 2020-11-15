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

namespace TG.telas.colab.rank.Controles
{
    /// <summary>
    /// Interação lógica para topfuncionarios.xam
    /// </summary>
    public partial class topfuncionarios : UserControl
    {
        private InfoColaborador colab;
        private string nome;

        public void Setcolab(InfoColaborador c)
        {
            colab = c;
        }
        public topfuncionarios(string teste)
        {
            InitializeComponent();
            nome = teste;
            nomeUsuario.Content = teste;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            colab.Carregardadosinfo(nome);
        }
    }
}
