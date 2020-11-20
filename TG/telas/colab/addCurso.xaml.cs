using MongoDB.Bson;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using TG.modelos;
using TG.utilidades;

namespace TG.telas.colab
{
    public partial class addCurso : Page
    {
        const string placeHolder = "certificado_placeholder.png";

        public addCurso()
        {
            InitializeComponent();
        }


        private void Save(object sender, RoutedEventArgs e)
        {
            if (TudoPreenchido())
            {
                alert.Visibility = Visibility.Hidden;
                var curso = Curso();
                curso.URLCertificado = urlImagem(curso.Id.ToString()+".jpg");
                Colaborador f = Session.GetColaborador();
                f.AdicionarCurso(curso);
                dr.IsOpen = false;
                MessageBox.Show("Sucesso","O curso foi registrado com sucesso!", MessageBoxButton.OK);
            }
            else alert.Visibility = Visibility.Visible;

        }

        private ComboBoxItem item(object o) => (ComboBoxItem)o ?? null; 

        private string urlImagem(string id)
        {
            ImageHelper.SalvarCertificado(certificado.ImageSource, id);
            return id;
        }

        private Formacao Curso()
        {
            return new Formacao
            {
                Id = ObjectId.GenerateNewId(),
                NomeCurso = nomeCurso.Text,
                TipoCurso = item(formatoCurso.SelectedItem).Content.ToString(),
                AreaCurso = areaCurso.Text,
                CargaHoraria = tempoDuracao.Text,
                DataInicio = dataInicio.DisplayDate,
                DataTermino = dataConclusao.DisplayDate,
                Valido = false,
                Peso = 0,
                Pontos = 0
            } ;
        }

        private bool TudoPreenchido()
        {
            bool preenchido = true;

            if(nomeCurso.Text.Equals("")) preenchido = FalsePreenchido(nomeCurso);
            if(areaCurso.Text.Equals("")) preenchido = FalsePreenchido(areaCurso);
            if(tempoDuracao.Text.Equals("")) preenchido = FalsePreenchido(tempoDuracao);
            if(item(formatoCurso.SelectedItem) == null) preenchido = FalsePreenchido(formatoCurso);

            if (certificado.ImageSource.ToString().Contains(placeHolder))
            {
                img.BorderBrush = Brushes.Red;
                preenchido = false;
            }

            return preenchido;
        }

        private void ResetaCor(object sender, KeyEventArgs e) => ToControl(sender).BorderBrush = Brushes.Gray;
        
        private void ResetaCor(object sender, SelectionChangedEventArgs e) => ToControl(sender).BorderBrush = Brushes.Gray;

        private void ResetaCor(object sender, EventArgs e) => img.BorderBrush = Brushes.Gray;

        private Control ToControl(object o) => (Control)o;

        private bool FalsePreenchido(Control c)
        {
            c.BorderBrush = Brushes.Red;
            return false;
        }
            
        private void getImage(object sender, RoutedEventArgs e)
        {
            BitmapImage imagem = ImageHelper.FileDialog();
            if (imagem != null) certificado.ImageSource = imagem;           
        }


    }
}
