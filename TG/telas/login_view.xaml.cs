using System.Windows;
using TG.modelos;
using TG.telas.colab;

namespace TG
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var usuario = new Usuario{ Username = nomeUsuario.Text, Senha = senha.Password};
            var colab = new Home_view(usuario);
            Hide();
            LimparCampos();
            colab.ShowDialog();
            Show();
            nomeUsuario.Focus();

        }

        private void LimparCampos()
        {
            nomeUsuario.Clear();
            senha.Clear();
        }

        private void Fechar(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
