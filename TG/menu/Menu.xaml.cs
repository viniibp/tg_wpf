using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using TG.telas;
using TG.telas.colab;

namespace TG.menu
{
    public partial class Menu : UserControl
    {

        private Frame painel;
        private static List<Brush> cores;
        private List<SetupButton> sb;


        public Menu(Grid container, Frame painel)
        {
            InitializeComponent();
            container.Children.Add(this);
            this.painel = painel;
            prepareButtons();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Abrir(new home(new modelos.Usuario()), Pages.PaginaInicial);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Abrir(new telas.colab.dados.Dados(), Pages.DadosPessoais);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Abrir(new CursosDetalhados(), Pages.CursoDetalhado);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Abrir(new addCurso(), Pages.AddCurso);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Abrir(new Ranking(), Pages.Ranking);
        }

        private void Abrir(Page p, Pages current)
        {
            sb.Find(setup => setup.Clicked).Default(cores[0]);
            sb[(int)current].Click(cores[1]);
            painel.Content = p;
        }

        private void prepareButtons()
        {
            cores = new List<Brush>() {
                ranking.Background.CloneCurrentValue(), // cor não clicado
                paginaInicial.Background.CloneCurrentValue() // cor clicado
            };

            sb = new List<SetupButton>();

            Enum.GetValues(typeof(Pages)).Cast<Pages>().ToList().ForEach(Page =>
                    sb.Add(new SetupButton(button(list.Children[(int)Page]), Page))
            );
        }

        private Button button(UIElement button) => (Button)button;


    }
}
