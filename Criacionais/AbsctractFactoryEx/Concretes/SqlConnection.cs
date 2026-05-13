using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbsctractFactoryEx.Interfaces

namespace AbsctractFactoryEx.Concretes
{
    public class SqlConnection : IDbConnection
    {
        public void Conectar()
        {
            Console.WriteLine("Implementação de conexão SQL.");
        }
    }
}
