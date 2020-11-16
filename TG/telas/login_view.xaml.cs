     using MongoDB.Bson;
using System;
using System.Windows;
using TG.modelos;
using TG.telas.colab;
using TG.utilidades;

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
            //Qualquercoisa();

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var usuario = new Usuario{ Username = nomeUsuario.Text, Senha = senha.Password};
            usuario.Entrar();
            Maiscoisa();
            Hide();
            LimparCampos();
            new main().ShowDialog();
            Show();
            nomeUsuario.Focus();

        }
        public void Maiscoisa()
        {
            Formacao f = new Formacao
            {
                Id = ObjectId.GenerateNewId(),
                NomeCurso = "Curso 3",
                TipoCurso = "Curso de Teste",
                AreaCurso = "TI",
                CargaHoraria = "20",
                DataInicio = new DateTime(2018, 01, 01),
                DataTermino = new DateTime(2018, 10, 01),
                Valido = true,
                Peso = 5,
                Pontos = 20
            };
            Session.GetColaborador().AdicionarCurso(f);
         }
        public void Qualquercoisa()
        {
            var carteiratrabalho = new modelos.Documentacao.CarteiraTrabalho("2222", "0222");

            var documentos = new modelos.Documentacao.Documentos
            {
                CPF = "222.222.222-22",
                RG = "11.111.111-1",
                CarteiraTrabalho = carteiratrabalho,
            };

            var dt = new modelos.Documentacao.DadosTrabalhistas
            {
                Registro = "222222-2",
                Cargo = "programador",
                Setor = "TI",
                DataAdmissao = DateTime.Today,
                JornadaTrabalho = 8,
                Salario = 2_050.00f,
            };

            var dp = new modelos.Documentacao.DadosPessoais
            {
                DataNascimento = new DateTime(2000, 10, 13),
                EstadoCivil = "Solteiro",
                Genero = "n sei",
                Sexo = "Feminino",
                Idade = 23,
                QtdFilhos = 2
            };

            var police = new Colaborador
            {
                Nome = "Iuri Paz",
                Username = "prog",
                Senha = new MD5Hash().GetMd5Hash("123"),
                AtivoContratado = true,
                Documentos = documentos,
                DadosPessoais = dp,

            };
            police.Salvar();
            police.AtualizarDadosTrabalhistas(dt);

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
