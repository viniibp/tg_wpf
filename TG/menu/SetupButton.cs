using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace TG.menu
{
    public class SetupButton
    {
        private Button Button { get; set; }
        private Pages Page { get; set; }
        public bool Clicked { get; set; }

        public SetupButton(Button button, Pages page)
        {
            Button = button;
            Page = page;
            Clicked = page == Pages.PaginaInicial ? true : false;
        }

        public void Default(Brush def)
        {
            Button.Background = def;
            Clicked = false;
        }

        public void Click(Brush click)
        {
            Button.Background = click;
            Clicked = true;
        }
    }
}
