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

namespace TG.telas.colab.dados
{
    /// <summary>
    /// Interação lógica para Dados.xam
    /// </summary>
    public partial class Dados : Page
    {

        private static List<Brush> cores;

        private string username;

        public Dados(string username)
        {
            InitializeComponent();
            cores = new List<Brush>() {
                bt1.Background.CloneCurrentValue(), // cor clicado
                bt2.Background.CloneCurrentValue() // cor não clicado
            };
            baseFrame.Content = new Alteraveis(username);
            this.username = username;
        }

        private void AbrirAlteraveis(object sender, RoutedEventArgs e)
        {
            baseFrame.Content = new Alteraveis(username);
            onClick(0, 1);
        }

        private void AbrirInalteraveis(object sender, RoutedEventArgs e)
        {
            baseFrame.Content = new Inalteraveis();
            onClick(1, 0);
        }

        private void onClick(int one, int two)
        {
            bt1.Background = cores[one];
            bt2.Background = cores[two];
        }

        private void baseFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
