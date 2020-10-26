using MongoDB.Bson;

namespace TG.modelos
{
    public class Usuario
    {
        [MongoDB.Bson.Serialization.Attributes.BsonId]
        public ObjectId Id { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }

        public object Entrar()
        {
            return null;
        }
    }
}
