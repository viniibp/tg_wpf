using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using TG.modelos;

namespace TG.telas.colab
{

    public partial class main : Window
    {

        public main()
        {
            InitializeComponent();
            new menu.Menu(container: menuGrid, painel: painel);
            Abrir(new home(new Usuario()));
            Colaborador c = Session.GetColaborador();
            //LoadInfos(c.Formacoes);
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
