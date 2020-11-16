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
            LoadDados(c);
            
        }

        private void LoadDados(Colaborador c)
        {
            nome.Text = c.Nome;
            if (c.Documentos != null)
            {
                cpf.Text = c.Documentos.CPF;
                rg.Text = c.Documentos.RG;
                tituloEleitor.Text = c.Documentos.TituloEleitoral;
            }
            if (c.Contatos != null)
            {
                email.Text = c.Contatos.Email;
                LoadTelefones(c.Contatos.Telefones);

            }
        }

        private void LoadTelefones(List<string> telefones)
        {
            painel.Children.Clear();
            if (telefones != null)
            {
                foreach (var telefone in telefones)
                {
                    var telControl = new Telefone.Telefone(telefone);
                    painel.Children.Add(telControl);
                }
            }
            else painel.Children.Add(new Chip() { Content = "Sem telefones registrados!", Margin = new Thickness(10) });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!newTelefone.Text.Equals(""))
            {
                Colaborador f = Session.GetColaborador();
                f.Contatos.AddTelefone(newTelefone.Text);
                LoadTelefones(f.Contatos.Telefones);
                newTelefone.Clear();
            }
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            var colaborador = Session.GetColaborador();
            colaborador.Nome = nome.Text;
            if (colaborador.Contatos == null) colaborador.Contatos = new modelos.Documentacao.Contato();
            colaborador.Contatos.Email = email.Text;

            foreach (Telefone.Telefone tel in painel.Children)
            {
                string numero = tel.GetTelefone();
                Console.WriteLine(tel.ToRemove() + " telefone -> " + numero);
                if (tel.ToRemove()) colaborador.Contatos.Telefones.Remove(numero);
                if (!colaborador.Contatos.Telefones.Contains(numero) && tel.ToRemove() == false) colaborador.Contatos.AddTelefone(numero);
            }

            colaborador.Atualizar();
            LoadDados(colaborador);
        }
    }
}
