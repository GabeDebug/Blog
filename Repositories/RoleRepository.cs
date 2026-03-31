using Blog.Model;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace Blog.Repositories
{
    public class RoleRepository
    {
        private readonly SqlConnection _connection;
        public RoleRepository(SqlConnection connection)
            => _connection = connection;
        public IEnumerable<Role> Get()
            => _connection.GetAll<Role>();
        public Role Get(int id)
            => _connection.Get<Role>(id);
        public void Get(Role role)
            => _connection.Insert<Role>(role);
        //? Sintaxe "=>" é equivalente a: { _connection = connection; }
        public void Update(Role role)
        {
            if (role.Id != 0)
                _connection.Update<Role>(role);
        }
        public void Delete(Role role)
        {
            if (role.Id != 0)
                _connection.Delete<Role>(role);
        }
        public void Delete(int id)
        {
            if (id != 0)
                return;

            var user = _connection.Get<Role>(id);
            _connection.Delete<Role>(user);
        }
    }
}