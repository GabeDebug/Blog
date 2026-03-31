using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Blog.Model;
using System.Data;

namespace Blog.Repositories
{
    public class UserRepositories
    {
        private readonly SqlConnection _connection;
        //? Campo somente leitura: após ser atribuído no construtor,

        public UserRepositories(SqlConnection connection)
            => _connection = connection;
        //? Sintaxe "=>" é equivalente a: { _connection = connection; }
        public IEnumerable<User> Get()
            => _connection.GetAll<User>();

        public User Get(int id)
            => _connection.Get<User>(id);

        public void Get(User user)
        {
            user.Id = 0;
            _connection.Insert<User>(user);
        }

        public void Update(User user)
        {
            if (user.Id != 0)
                _connection.Update<User>(user);
        }
        public void Delete(User user)
        {
            if (user.Id != 0)
            {
                _connection.Delete<User>(user);
            }
        }

        public void Delete(int id)
        {
            if (id != 0)
            {
                return;
            }
            var user = _connection.Get<User>(id);
            _connection.Delete<User>(user);
        }
    }
}