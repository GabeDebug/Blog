using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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

            //ReadUsers(connection);
            CreateUsers(connection);
            //ReadRoles(connection);
            //ReadTag(connection);

            connection.Close(); // vai fecha a conexão
        }

        static void ReadUsers(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine($"{item.Name}");
        }
        public static void CreateUsers(SqlConnection connection)
        {
            var user = new User()
            {
                Email = "email@balta.io",
                Bio = "bio",
                Image = "Imagem",
                Name = "Name",
                PasswordHash = "Hash",
                Slug = "slug"
            };
            var repository = new Repository<User>(connection);
            repository.Get(user);
        }

        public static void ReadRoles(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine($"{item.Name}");
        }

        public static void ReadTag(SqlConnection connection)
        {
            var repository = new Repository<Tag>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine($"{item.Name}");
        }
    }
}
