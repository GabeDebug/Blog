using System.Data;
using Blog.Model;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class Repository<TModel> where TModel : class
        //? classe genérica de repositório — TModel representa qualquer entidade (ex: Usuario, Produto)
        //? A restrição "where TModel : class" garante que só aceita tipos de referência (classes)
    {
        private readonly SqlConnection _connection;
        public Repository(SqlConnection connection)
                => _connection = connection;
        public IEnumerable<TModel> Get()
            => _connection.GetAll<TModel>();
        public TModel Get(int id)
            => _connection.Get<TModel>(id);
        public void Get(TModel model)
            => _connection.Insert<TModel>(model);
        //? Sintaxe "=>" é equivalente a: { _connection = connection; }
        public void Update(TModel model)
             => _connection.Update<TModel>(model); // Executa o UPDATE no banco
        public void Delete(TModel model)
            => _connection.Delete<TModel>(model); //? // Executa o DELETE no banco
        public void Delete(int id)
        {
            var model = _connection.Get<TModel>(id);
            _connection.Delete<TModel>(model);
        }
    }
}