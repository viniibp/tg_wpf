using System;
using System.Windows.Controls;
using System.Windows.Media;
using TG.modelos;

namespace TG.telas.colab.curso_detalhado.controles
{

    public partial class CursoDetalhado : UserControl
    {
        public CursoDetalhado(Formacao f)
        {
            InitializeComponent();
            LoadDados(f);
            setBGColor();
        }

        private void setBGColor()
        {
            string[] inits = new string[]{ "#FF6448FE", "#FFFE6197", "#FF61A3FE", "#FFFFA738", "#FFFF5DCD" };
            string[] ends = new string[] { "#FF5FC6FF", "#FFFFB463", "#FF63FFD5", "#FFFFE130", "#FFFF8484" };

            var random = new Random().Next(0,4);

            Color newInit = (Color)ColorConverter.ConvertFromString(inits[random]);
            Color newEnd = (Color)ColorConverter.ConvertFromString(inits[random]);
            init.Color = newInit;
            init.Color = newEnd;
        }

        private void LoadDados(Formacao f)
        {
            nomeCurso.Content = f.NomeCurso;
            cargaHoraria.Text = f.CargaHoraria;
            dataInicio.Text = f.DataInicio.ToShortDateString();
            dataTermino.Text = f.DataTermino.ToShortDateString();
            peso.Value = f.Peso;
            pontos.Text = f.Pontos.ToString();
        }
    }
}
