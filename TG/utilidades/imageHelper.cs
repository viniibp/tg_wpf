using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TG.utilidades
{
    public class ImageHelper : Object
    {

        public static BitmapImage FileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "Imagem|*.jpg;*.jpeg;*.png"
            };
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                return new BitmapImage(fileUri);
            }
            else return new BitmapImage(new Uri(PathMain()+"\\..\\..//Assets//certificado_placeholder.png"));
        }

        public static BitmapImage ImagemUrl(string url) => new BitmapImage(new Uri(url));

        private static string PathMain() => Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory.ToString());

        public static void SalvarCertificado(ImageSource imageSource, string newName)
        {

            var encoder = new PngBitmapEncoder();
            string curDir = PathMain() + "\\..\\..//certificados//";
            encoder.Frames.Add(BitmapFrame.Create((BitmapSource)imageSource));
            using (FileStream stream = new FileStream(curDir + newName, FileMode.Create))
            encoder.Save(stream);
        }
    }
}
