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
            Hide();
            LimparCampos();
            usuario.Entrar();
            //Maiscoisa();
            System.Console.WriteLine(Session.GetColaborador().Nome);
            new main().ShowDialog();
            Show();
            nomeUsuario.Focus();

        }
        public void Maiscoisa()
        {
            Formacao f = new Formacao
            {
                Id = ObjectId.GenerateNewId(),
                NomeCurso = "Nome Curso",
                TipoCurso = "Curso de Extensão",
                AreaCurso = "Sei lá",
                CargaHoraria = "80",
                DataInicio = new DateTime(2018, 01, 01),
                DataTermino = new DateTime(2018, 10, 01),
                Valido = false,
                Peso = 0,
                Pontos = 0
            };
            Session.GetColaborador().AdicionarCurso(f);
         }
        public void Qualquercoisa()
        {
            var carteiratrabalho = new modelos.Documentacao.CarteiraTrabalho("4002", "8922");

            var documentos = new modelos.Documentacao.Documentos
            {
                CPF = "449.550.477-10",
                RG = "00.000.008-8",
                CarteiraTrabalho = carteiratrabalho
            };

            var dt = new modelos.Documentacao.DadosTrabalhistas
            {
                Registro = "00000-00",
                Cargo = "gerente",
                Setor = "rh",
                DataAdmissao = DateTime.Today,
                JornadaTrabalho = 8,
                Salario = 1_045.00f,
            };

            var dp = new modelos.Documentacao.DadosPessoais
            {
                DataNascimento = new DateTime(2000, 10, 13),
                EstadoCivil = "online",
                Genero = "batman",
                Sexo = "masculino",
                Idade = 19,
                QtdFilhos = 0
            };

            var police = new Colaborador
            {
                Nome = "vinicius batista",
                Username = "admin",
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
