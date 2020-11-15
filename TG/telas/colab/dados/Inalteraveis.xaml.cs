using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Effects;
using TG.modelos.Documentacao;

namespace TG.telas.colab.dados
{
    public partial class Inalteraveis : Page
    {
        private Brush Default, Checked;

        public Inalteraveis(DadosTrabalhistas dadosTrabalhistas)
        {
            InitializeComponent();
            LoadIcons();
            LoadDados(dadosTrabalhistas);
  
        }

        private void LoadDados(DadosTrabalhistas dt)
        {
            dataAdmissao.Text = dt.DataAdmissao.ToString();
            setor.Text = dt.Setor;
            cargo.Text = dt.Cargo;
            jornadaSemanal.Text = dt.JornadaTrabalho.ToString();
            nacionalidade.Text = dt.Nacionalidade;
            naturalidade.Text = dt.Naturalidade;
            salario.Text = dt.Salario.ToString();
            registro.Text = dt.Registro;
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            salario.Effect = null;
            icon.Foreground = Checked;
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            salario.Effect = new BlurEffect { Radius = 20 };
            icon.Foreground = Default;
        }

        private void LoadIcons()
        {
            salario.Effect = new BlurEffect { Radius = 20 };
            Default = icon.Foreground;
            Checked = toggle.Foreground;
        }

    }
}
