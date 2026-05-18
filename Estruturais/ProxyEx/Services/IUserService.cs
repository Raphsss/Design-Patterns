using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyEx.Services
{
    public interface IUserService
    {
        void CreateUser(string username, int idade);
    }
}
