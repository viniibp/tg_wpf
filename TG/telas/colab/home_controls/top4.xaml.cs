using System.Windows.Controls;
using System.Windows.Media;

namespace TG.telas.colab.home_controls
{
    public partial class Top4 : UserControl
    {
        public Top4()
        {
            InitializeComponent();
        }

        public void setDados(string nomeColab, double mediaColab)
        {
            nome.Content = nomeColab;
            mediaPesos.Value = int.Parse(mediaColab.ToString());
        }

        public void MySelf()
        {
            painel.Background = Brushes.LightBlue;
        }
    }
}
