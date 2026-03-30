using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Blog.Model;
using System.Data;

namespace Blog.Repositories
{
    public class UserRepositories
    {
        private readonly SqlConnection _connection; //Apenas leitura

        public UserRepositories(SqlConnection connection)
            => _connection = connection;
        public IEnumerable<User> Get()
            => _connection.GetAll<User>();
        public User Get(int id)
            => _connection.Get<User>(id);
        public void Get(User user)
            => _connection.Insert<User>(user);
    }
}