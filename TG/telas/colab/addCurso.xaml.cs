using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TG.modelos;
using TG.utilidades;

namespace TG.telas.colab
{
    public partial class addCurso : Page
    {
        public addCurso()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var curso = Curso();
            curso.URLCertificado = urlImagem(curso.Id.ToString()+".jpg");
            //Colaborador f = Session.GetColaborador();
            //f.AdicionarCurso(curso);
        }

        private ComboBoxItem item(object o) => (ComboBoxItem)o; 

        private string urlImagem(string id)
        {
            ImageHelper.SalvarCertificado(certificado.Source, id);
            return id;
        }

        private Formacao Curso()
        {
            return TudoPreenchido() ? new Formacao
            {
                Id = ObjectId.GenerateNewId(),
                NomeCurso = nomeCurso.Text ?? "",
                TipoCurso = item(formatoCurso.SelectedItem).Content.ToString() ?? "",
                AreaCurso = areaCurso.Text ?? "",
                CargaHoraria = tempoDuracao.Text ?? "",
                DataInicio = dataInicio.DisplayDate,
                DataTermino = dataConclusao.DisplayDate,
                Valido = false,
                Peso = 0,
                Pontos = 0
            } 
            : 
            null;
        }

        private bool TudoPreenchido()
        {
            return true;
        }

        private void getImage(object sender, RoutedEventArgs e)
        {
            certificado.Source = ImageHelper.FileDialog();
        }
    }
}
