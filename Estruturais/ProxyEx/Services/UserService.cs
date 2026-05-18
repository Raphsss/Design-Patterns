using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyEx.Services
{
    public class UserService
    {
        public void CreateUser(string username, int idade)
        {
            Console.WriteLine($"Usuário {username} criado com idade {idade}.");
        }
    }
}
