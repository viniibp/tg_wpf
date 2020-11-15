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
using TG.controles;
using TG.modelos;
using TG.telas.colab;

namespace TG.telas
{
    /// <summary>
    /// Interação lógica para home.xam
    /// </summary>
    public partial class home : Page
    {
        protected static Usuario usuarioCorrente;

        public home(Usuario u)
        {
            usuarioCorrente = u;
            InitializeComponent();
            usuarioCorrente = u;
            Load();
        }

        private void Load()
        {
            for (int i = 0; i < 10; i++)
            {
                Curso c = new Curso();
                painel.Children.Add(c);
                c.Text(i.ToString());
            }
        }
    }
}
