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
            nomeUsuario.Text = "admin";
            senha.Password = "123";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var usuario = new Usuario{ Username = nomeUsuario.Text, Senha = senha.Password};
            Hide();
            LimparCampos();
            usuario.Entrar();
            System.Console.WriteLine(Session.GetColaborador().Nome);
            new main().ShowDialog();
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
