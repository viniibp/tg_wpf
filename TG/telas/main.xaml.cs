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
using System.Windows.Shapes;

namespace TG.telas.colab
{

    public partial class main : Window
    {

        public main()
        {
            InitializeComponent();
            painel.Content = new home(new modelos.Usuario());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            painel.Content = new home(new modelos.Usuario());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            painel.Content = new dados.Dados();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            painel.Content = new CursosDetalhados();
        }
    }
}
