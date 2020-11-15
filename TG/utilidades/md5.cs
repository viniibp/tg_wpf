using System.Security.Cryptography;
using System.Text;

namespace TG.utilidades
{
    public class MD5Hash
    {
        public string GetMd5Hash(string input)
        {
            MD5 md5 = MD5.Create();

            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            System.Console.WriteLine(sb.ToString());
            return sb.ToString();

        }
    }
}
