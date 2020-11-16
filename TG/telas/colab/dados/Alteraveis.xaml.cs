using MaterialDesignThemes.Wpf;
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

namespace TG.telas.colab.dados
{
    /// <summary>
    /// Interação lógica para DadosAlteraveis.xam
    /// </summary>
    public partial class Alteraveis : Page
    {
        public Alteraveis()
        {
            InitializeComponent();
            Colaborador c = Session.GetColaborador();
            LoadTelefones(c.Contatos.Telefones);
            
        }

        private void LoadTelefones(List<string> telefones)
        {
            painel.Children.Clear();
            foreach (var telefone in telefones)
            {
                Chip chip = new Chip() { Content = telefone, Margin = new Thickness(10), };
                painel.Children.Add(chip);
            }
        }
    }
}
