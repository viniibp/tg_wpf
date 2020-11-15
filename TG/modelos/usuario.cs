using MongoDB.Bson;
using TG.banco;

namespace TG.modelos
{
    public class Usuario
    {
        [MongoDB.Bson.Serialization.Attributes.BsonId]
        public ObjectId Id { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }

        public Colaborador Entrar()
        {
            Colaborador colaborador = new ColaboradorDAO().Entrar(this);
            Session.SetSessao(colaborador);
            return colaborador;
        }

        public void Sair()
        {
            Session.CloseSession();
        }
    }
}
