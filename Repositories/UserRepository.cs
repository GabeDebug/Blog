using Blog.Model;
using Microsoft.Data.SqlClient;
namespace Blog.Repositories
{
    public class UserRepository : Repository<User>
    {
        private readonly SqlConnection _connection;

        public UserRepository(SqlConnection connection) : base (connection) // Repassa a conexão para o construtor da classe pai
            => _connection = connection; // Salva a conexão no campo local da classe filha
    }
}