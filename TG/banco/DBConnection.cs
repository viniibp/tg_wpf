using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Windows;

namespace TG.banco
{
    public class DBConnection
    {
        protected IMongoDatabase GetConnection()
        {
                var nomeBanco = "RH";
                var setings = new MongoClientSettings
                {
                    ServerSelectionTimeout = new TimeSpan(0, 0, 3),

                };

                var cliente = new MongoClient(setings);

                IMongoDatabase db = cliente.GetDatabase(nomeBanco);
                return db;
            
        }

        public bool TestConnection()
        {
            try
            {
                var comando = new BsonDocument("ping", 1);
                var resultado = GetConnection().RunCommandAsync<BsonDocument>(comando).Result;
                return true;
            }
            catch (Exception e)
            {
                if (e.InnerException is TimeoutException)
                MessageBox.Show("Não foi possível conectar ao servidor", "Erro");
                return false;
            }
        }
    }
}
