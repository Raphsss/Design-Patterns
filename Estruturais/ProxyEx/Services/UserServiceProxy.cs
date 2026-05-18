using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyEx.Services
{
    public class UserServiceProxy : IUserService
    {
        private readonly UserService _userService;

        public UserServiceProxy()
        {
            _userService = new UserService();
        }

        public void CreateUser(string username, int idade)
        {
            if(username.Length < 3)
            {
                Console.WriteLine("O nome de usuário deve ter pelo menos 3 caracteres.");
                return;
            }

            if(idade < 18)
            {
                Console.WriteLine("O usuário deve ser maior de idade.");
                return;
            }

            _userService.CreateUser(username, idade);
        }
    }
}
