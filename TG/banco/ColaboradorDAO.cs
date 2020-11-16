using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using TG.modelos;
using TG.utilidades;

namespace TG.banco
{
    public class ColaboradorDAO : DBConnection, IDefaultDAO<Colaborador>
    {

        private IMongoCollection<Colaborador> collection;

        public ColaboradorDAO()
        {
            collection = GetConnection().GetCollection<Colaborador>("Funcionario");
        }

        internal Colaborador Entrar(Usuario usuario)
        {
            var md5 = new MD5Hash();

            var funcionario = collection.Find(
                func =>
                    usuario.Username == func.Username &&
                    md5.GetMd5Hash(usuario.Senha).Equals(func.Senha)
            ).SingleOrDefault();
             
            return funcionario;
        }

        public List<Colaborador> ListRanking() => FindAll().OrderBy(c => c.Ranking()).ToList();

        public void Create(Colaborador colab) => collection.InsertOne(colab);

        public Colaborador Find(Colaborador colab) => collection.Find(c =>  c.Nome.Contains(colab.Nome)).First();

        public void Remove(Colaborador colab) => collection.DeleteOne(f => f.Id == colab.Id);

        public void Update(Colaborador colab) => collection.ReplaceOne(f => f.Id == colab.Id, colab);

        public List<Colaborador> FindAll() => collection.Find(_ => true).ToList();

        public int Ranking(ObjectId id) =>
            FindAll().OrderByDescending(f => f.GerenciadorCursos().Pontuacao).ToList().FindIndex(c => c.Id == id);

    }
}
