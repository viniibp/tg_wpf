using System.Windows;
using TG.controles;
using TG.modelos;
using TG.telas.colab.dados;

namespace TG.telas.colab
{
    /// <summary>
    /// Lógica interna para home_view.xaml
    /// </summary>
    public partial class Home_view : Window
    {

        private Usuario usuarioCorrente;

        public Home_view(Usuario u)
        {//kk
            InitializeComponent();
            usuarioCorrente = u;
            teste.Content = usuarioCorrente.Username;
            Load();
        }

        private void AbrirDadosPage(object sender, RoutedEventArgs e)
        {
            Dados dadosPage = new Dados();
            Content = dadosPage;
        }

        private void Load()
        {
            for (int i = 0; i < 10; i++)
            {
                Curso c = new Curso();
                painel.Children.Add(c);
                c.Text(i.ToString());
            }
        }

        private void AbrirCursosDetalhados(object sender, RoutedEventArgs e)
        {
            CursosDetalhados cd = new CursosDetalhados();
            Content = cd;
        }
    }
}
