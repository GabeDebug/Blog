using System;
using System.Data;
using Blog.Model;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=Sua@Debug@12345;TrustServerCertificate=True";
        static void Main()
        {
            
        }

        static void ReadUsers()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var users = connection.GetAll<User>(); // metodo GetAll vai escrever a sintaxe e busca 
                // todos os campos do usuario 

                foreach (var user in users)
                {
                    Console.WriteLine($"{user.Bio}");
                }
            }
        }

         public  static void ReadUser()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(1);
                Console.WriteLine($"{user.Name}");
            }
        }
    }
}