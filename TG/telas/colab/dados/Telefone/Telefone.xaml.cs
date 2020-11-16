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

namespace TG.telas.colab.dados.Telefone
{
    /// <summary>
    /// Interação lógica para Telefone.xam
    /// </summary>
    public partial class Telefone : UserControl
    {
        private string telefone;
        private bool toRemove;

        public Telefone(string tel)
        {
            InitializeComponent();
            telefone = tel;
            lb_telefone.Content = tel;
            toRemove = false;
        }

        public string GetTelefone() => telefone;

        public bool ToRemove() => toRemove;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            toRemove = !toRemove;
            if (toRemove)
            {
                border.Background = Brushes.LightGray;
                trash.Foreground = Brushes.Red;
            }
            else border.Background = trash.Foreground = Brushes.White;
        }
    }
}
