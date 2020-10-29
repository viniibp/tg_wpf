using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using TG.modelos;

namespace TG.banco
{
    public class ColaboradorDAO : DBConnection, IDefaultDAO<Colaborador>
    {

        private IMongoCollection<Colaborador> collection;

        public ColaboradorDAO()
        {
            collection = GetConnection().GetCollection<Colaborador>("Funcionario");
        }

        public void Create(Colaborador colab) => collection.InsertOne(colab);

        public Colaborador Find(Colaborador colab) => collection.Find(c =>  c.Nome.Contains(colab.Nome)).First();

        public void Remove(Colaborador colab) => collection.DeleteOne(f => f.Id == colab.Id);

        public void Update(Colaborador colab) => collection.ReplaceOne(f => f.Id == colab.Id, colab);

        public List<Colaborador> FindAll() => collection.Find(_ => true).ToList();

        public int Ranking(ObjectId id) =>
            FindAll().OrderBy(f => f.GerenciadorCursos().Pontuacao()).ToList().FindIndex(c => c.Id == id);

    }
}
