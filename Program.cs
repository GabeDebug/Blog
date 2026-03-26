using System;
using Blog.Model;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {

        private const string CONNECTION_STRING = @"";
        static void Main()
        {

        }

        static void ReadUsers()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var users = connection.GetAll<User>();

                foreach(var user in users)
                {
                    Console.WriteLine($"{user.Name}");
                }
            };

        }
    }
}