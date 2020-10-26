using MongoDB.Driver;

namespace TG.banco
{
    public class DBConnection
    {
        protected IMongoDatabase GetConnection()
        {
            var nomeBanco = "RH";

            var cliente = new MongoClient();

            IMongoDatabase db = cliente.GetDatabase(nomeBanco);
            return db;
        }
    }
}
