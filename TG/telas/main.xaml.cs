using MongoDB.Bson;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using TG.banco;
using TG.modelos;
using TG.telas.colab.home_controls;

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
            nomeLogado.Content = colaborador.Nome;
            LoadTop5();
            LoadInfos(colaborador.Formacoes);
        }

        private void LoadTop5()
        {
            top4Painel.Children.Clear();
            var topList = new ColaboradorDAO().ListRanking();
            if(topList.Count > 4) topList.RemoveRange(3, topList.Count-4);
            modelos.Gerenciador.GerenciadorCursos gc;
            ObjectId idLogado = Session.GetColaborador().Id;
            foreach (var c in topList)
            {
                gc = new modelos.Gerenciador.GerenciadorCursos(c.Formacoes);
                Top4 top = new Top4();
                if (c.Id == idLogado) top.MySelf();
                top.setDados(c.Nome, gc.Media);
                top4Painel.Children.Add(top);
            }
        }

        private void LoadInfos(List<Formacao> f)
        {
            modelos.Gerenciador.GerenciadorCursos gc = new modelos.Gerenciador.GerenciadorCursos(f);
            Nivel.Content = "Nível " + gc.Nivel(nivel, gc.Pontuacao).Level.ToString();

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
