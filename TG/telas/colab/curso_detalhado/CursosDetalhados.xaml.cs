using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TG.modelos;
using TG.telas.colab.curso_detalhado.controles;

namespace TG.telas.colab
{
    /// <summary>
    /// Interação lógica para CursosDetalhados.xam
    /// </summary>
    public partial class CursosDetalhados : Page
    {
        
        public CursosDetalhados(Colaborador c)
        {
            InitializeComponent();
            Carregar(c);
        }

        private void Carregar(Colaborador c)
        {
            var manager = c.GerenciadorCursos();
            var media = manager.Media;
            int validos = manager.Validos;
            var pontos = manager.Pontuacao;

            qtdCursos.Content = manager.TotalCursos().ToString();
            mediaPesos.Value = int.Parse(media.ToString());
            pontosTotais.Content = pontos.ToString();
            qtdValidos.Content = validos.ToString();

            ranking.Content = c.Ranking().ToString();
            listarCursos(c.Formacoes);
            
        }

        private void listarCursos(List<Formacao> formacoes)
        {
            if(formacoes != null) formacoes.ForEach(f => PrepararCurso(f));
        }

        private void PrepararCurso(Formacao f)
        {
            if (f.Valido)
            {
                CursoDetalhado cd = new CursoDetalhado(f);
                painel.Children.Add(cd);
            }
        }

    }
}
