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
using TG.data;
using TG.utilidades;

namespace TG.telas.colab.home_controls.banners
{
    /// <summary>
    /// Interação lógica para model1.xam
    /// </summary>
    public partial class model1 : UserControl
    {
        public model1(Banner b1, Banner b2, Banner b3, Banner b4, bool chooseSide)
        {
            InitializeComponent();
            if(b1 != null) Banner1(b1);
            if(b2 != null) Banner2(b2);
            if(b3 != null) Banner3(b3);
            if(b4 != null) Banner4(b4);
        }

        public void Switch()
        {
            var copy = stack1.Children;

            grid.Children.Clear();

            grid.Children.Add(stack2);
            grid.Children.Add(stack1);
        }

        private void Banner1(Banner banner)
        {
            nome1.Content = banner.Nome;
            img1.ImageSource = ImageSource(banner.URL);
        }

        private void Banner2(Banner banner)
        {
            img2.ImageSource = ImageSource(banner.URL);
        }

        private void Banner3(Banner banner)
        {
            img3.ImageSource = ImageSource(banner.URL);
        }

        private void Banner4(Banner banner)
        {
            nome4.Content = banner.Nome;
            img4.ImageSource = ImageSource(banner.URL);
        }

        private BitmapImage ImageSource(string url) => ImageHelper.ImagemUrl(url);
    }
}
