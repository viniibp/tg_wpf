using MongoDB.Driver;
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

        public void Create()
        {
            throw new System.NotImplementedException();
        }

        public void Delete()
        {
            throw new System.NotImplementedException();
        }

        public Colaborador Find()
        {
            throw new System.NotImplementedException();
        }

        public Colaborador FindAll()
        {
            throw new System.NotImplementedException();
        }

        public void Remove()
        {
            throw new System.NotImplementedException();
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }
    }
}
