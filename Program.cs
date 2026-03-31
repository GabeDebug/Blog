using System;
using System.Data;
using Blog.Model;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=Sua@Debug@12345;TrustServerCertificate=True";
        static void Main()
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open(); // vai abrir a conexão
            ReadUsers(connection);
            ReadRoles(connection);
            connection.Close(); // vai fecha a conexão
        }

        static void ReadUsers(SqlConnection connection)
        {
            var repository = new UserRepositories(connection);
            var users = repository.Get();

            foreach (var user in users)
                Console.WriteLine($"{user.Name}");
        }

        static void ReadRoles(SqlConnection connection)
        {
            var repository = new RoleRepository(connection);
            var roles = repository.Get(); // return Enumerable Role -> No User

            foreach (var role in roles)
                Console.WriteLine($"{role.Id}");
        }
    }
}
