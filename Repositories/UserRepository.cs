using Blog.Model;
using Microsoft.Data.SqlClient;
namespace Blog.Repositories
{
    public class UserRepository : Repository<User>
    {
        private readonly SqlConnection _connection;

        public UserRepository(SqlConnection connection) : base (connection) // chamando o contrutor da classe base
            => _connection = connection;
    }
}