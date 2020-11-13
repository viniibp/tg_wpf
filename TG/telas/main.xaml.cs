using System.Windows;
using System.Windows.Controls;

namespace TG.telas.colab
{

    public partial class main : Window
    {

        public main()
        {
            InitializeComponent();
            new menu.Menu(container: menuGrid, painel: painel);
            Abrir(new home(new modelos.Usuario()));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Abrir(new home(new modelos.Usuario()));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Abrir(new dados.Dados());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Abrir(new CursosDetalhados());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Abrir(new addCurso());
        }

        private void Abrir(Page p)
        {
            painel.Content = p;
        }
    }
}
