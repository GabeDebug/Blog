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


            connection.Close(); // vai fecha a conexão
            Console.ReadKey();
        }

    }
}