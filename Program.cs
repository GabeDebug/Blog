using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Blog.Model;
using Blog.Repositories;
using Blog.Screens.TagScreens;
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

            Load();

            Console.ReadKey(); // Digitou uma tecla vai fecha 
            connection.Close(); // vai fecha a conexão
        }

        private static void Load()
        {
            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de Categoria");
            Console.WriteLine("4 - Gestão de Tag");
            Console.WriteLine("5 - Vincular perfil/Usuario");
            Console.WriteLine("6 - Vincular post/Tag");
            Console.WriteLine("7 - Relatórios");
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    MenuTagsScreen.Load();
                    break;
                default: Load(); break;
            }
        }

    }
}