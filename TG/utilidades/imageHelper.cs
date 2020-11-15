using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TG.utilidades
{
    public class imageHelper : Object
    {

        public static BitmapImage FileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                return new BitmapImage(fileUri);
            }
            else return new BitmapImage();
        }

        public static void SalvarCertificado(ImageSource imageSource, string newName)
        {

            var encoder = new PngBitmapEncoder();
            string curDir = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory.ToString()) + "\\..\\..//certificados//";
            encoder.Frames.Add(BitmapFrame.Create((BitmapSource)imageSource));
            using (FileStream stream = new FileStream(curDir + newName, FileMode.Create))
            encoder.Save(stream);
        }
    }
}
