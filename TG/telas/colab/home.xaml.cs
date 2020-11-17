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
using TG.data;
using TG.modelos;
using TG.telas.colab;
using TG.telas.colab.home_controls.banners;

namespace TG.telas
{
    /// <summary>
    /// Interação lógica para home.xam
    /// </summary>
    public partial class home : Page
    {
        public home()
        {
            InitializeComponent();
            TesteBanners();
        }

        private void TesteBanners()
        {
            var listBanners = data.Data.banners;
            bool chooseModel = true;

            for (int i = 0; i < listBanners.Count; i+=4)
            {
                var vert = getBanner
                (
                    chooseModel,
                    listBanners[i] ?? null,
                    listBanners[i+1] ?? null,
                    listBanners[i+2] ?? null, 
                    listBanners[i+3] ?? null
                 );
                painel.Children.Add(vert);
                chooseModel = !chooseModel;
            }
        }

        private UserControl getBanner(bool chooseModel, Banner b1, Banner b2, Banner b3, Banner b4)
        {
            if (chooseModel)
            {
                return new model1(b1, b2, b3, b4, chooseModel);
            }
            else
            {
                var m = new model1(b1, b2, b3, b4, chooseModel);
                m.Switch();
                return m;
            }
        }
    }
}
