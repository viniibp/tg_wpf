﻿using System.Windows;
using TG.modelos;

namespace TG.telas.colab
{
    /// <summary>
    /// Lógica interna para home_view.xaml
    /// </summary>
    public partial class Home_view : Window
    {

        private Usuario currentUser;

        public Home_view(Usuario u)
        {
            InitializeComponent();
            currentUser = u;
            teste.Content = currentUser.Username;
        }
    }
}
