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
        private List<Formacao> Formacoes;
        
        public CursosDetalhados()
        {
            InitializeComponent();
            Formacoes = new List<Formacao> {
                new Formacao(),
                new Formacao(),
                new Formacao(),
                new Formacao(),
                new Formacao(),
                new Formacao(),
                new Formacao(),
                new Formacao(),
            };
            listarCursos(Formacoes);
        }

        private void listarCursos(List<Formacao> formacoes)
        {
            formacoes.ForEach(f => PrepararCurso(f));
        }

        private void PrepararCurso(Formacao f = null)
        {
            CursoDetalhado cd = new CursoDetalhado(f);
            painel.Children.Add(cd);
        }
    }
}
