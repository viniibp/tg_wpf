using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using TG.modelos;

namespace TG.telas.colab
{

    public partial class main : Window
    {
        Colaborador colaborador;

        public main()
        {
            InitializeComponent();
            new menu.Menu(container: menuGrid, painel: painel);
            Abrir(new home(new Usuario()));

            colaborador = Session.GetColaborador();

            LoadInfos(colaborador.Formacoes);
        }

        private void LoadInfos(List<Formacao> f)
        {
            modelos.Gerenciador.GerenciadorCursos gc = new modelos.Gerenciador.GerenciadorCursos(f);
            Nivel.Content = "Nível " + gc.Nivel(nivel, gc.Pontuacao()).Level.ToString();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Abrir(new home(new Usuario()));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Abrir(new dados.Dados());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Abrir(new CursosDetalhados(colaborador));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Abrir(new addCurso());
        }

        private void Abrir(Page p)
        {
            painel.Content = p;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Session.CloseSession();
            Close();
        }
    }
}
