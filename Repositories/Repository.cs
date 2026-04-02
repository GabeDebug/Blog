using System.Data;
using Blog.Model;
using Blog.Repositories;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class Repository<TModel> where TModel : class
        //? classe genérica de repositório — TModel representa qualquer entidade (ex: Usuario, Produto)
        //? A restrição "where TModel : class" garante que só aceita tipos de referência (classes)
    {
        private SqlConnection connection;

        public Repository(SqlConnection connection)
        {
            this.connection = connection;
        }

        public IEnumerable<TModel> Get()
            => Database.Connection.GetAll<TModel>();
        public TModel Get(int id)
            => Database.Connection.Get<TModel>(id);
        public void Get(TModel model)
            => Database.Connection.Insert<TModel>(model);
        //? Sintaxe "=>" é equivalente a: { _connection = connection; }

        public void Update(TModel model)
            => Database.Connection.Update<TModel>(model); // Executa o UPDATE no banco
        public void Delete(TModel model)
            => Database.Connection.Delete<TModel>(model); //? Executa o DELETE no banco
        public void Delete(int id)
        {
            var model = Database.Connection.Get<TModel>(id);
            Database.Connection.Delete<TModel>(model);
        }
    }
}