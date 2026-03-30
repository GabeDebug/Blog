using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Blog.Model;

namespace Blog.Repositories
{
    public class UserRepositories
    {
        public IEnumerable<User> Get()
        {
            using (var connection = new SqlConnection(""))
            {
                return connection.GetAll<User>(); // metodo GetAll vai escrever a sintaxe e busca 
            }
        }
    }
}