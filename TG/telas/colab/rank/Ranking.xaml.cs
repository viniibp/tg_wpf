﻿using System;
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
using TG.banco;
using TG.telas.colab.rank.Controles;

namespace TG.telas.colab.rank
{
    /// <summary>
    /// Interação lógica para Ranking.xam
    /// </summary>
    public partial class Ranking : Page
    {
        public Ranking()
        {
            InitializeComponent();
            InfoColaborador infoColab = new InfoColaborador();
            Load(infoColab);
            infoColaborador.Content = infoColab;
            infoColab.Carregardadosinfo(Session.GetColaborador());
        }

        public void Load(InfoColaborador colaborador)
        {
            var todosColab = new ColaboradorDAO().ListRanking();
            var Id = Session.GetColaborador().Id;

            foreach (var colab in todosColab)
            {
                topfuncionarios topFuncionarios = new topfuncionarios(colab);
                topFuncionarios.Setcolab(colaborador);
                if (colab.Id == Id) topFuncionarios.MySelf();
                painel.Children.Add(topFuncionarios);

            }
        }
    }
}
