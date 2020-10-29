using System.Collections.Generic;

namespace TG.modelos.Documentacao
{
    public class Contato
    {
        public List<string> Telefones { get; set; }
        public string Email { get; set; }

        public void AddTelefone(string tel)
        {
            if (Telefones == null) Telefones = new List<string>();
            Telefones.Add(tel);
        }
    }
}
