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
using TG.modelos.Gerenciador;

namespace TG.telas.colab.rank
{
    /// <summary>
    /// Interação lógica para InfoColaborador.xam
    /// </summary>
    public partial class InfoColaborador : Page
    {

        public InfoColaborador()
        {
            InitializeComponent();
        }

        public void Carregardadosinfo(Colaborador c)
        {
            GerenciadorCursos gc = new GerenciadorCursos(c.Formacoes);
            colocacao.Text = c.Ranking().ToString();
            nivel.Text = gc.Nivel(gc.Pontuacao).ToString();
            nCursos.Text = gc.TotalCursos().ToString();
            nome.Content = c.Nome;
            mediaPeso.Value = int.Parse(gc.Media.ToString());
        }
    }
}
