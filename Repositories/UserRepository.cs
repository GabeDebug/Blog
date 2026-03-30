using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Blog.Model;

namespace Blog.Repositories
{
    public class UserRepositories
    {
        private SqlConnection _connection = new SqlConnection("");

        public IEnumerable<User> Get()

            => _connection.GetAll<User>();
        public User Get(int id)

            => _connection.Get<User>(id);

        public void Get(User user)

            => _connection.Insert<User>(user);

    }
}