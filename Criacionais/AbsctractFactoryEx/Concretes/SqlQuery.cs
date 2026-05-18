using AbsctractFactoryEx.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsctractFactoryEx.Concretes
{
    public class SqlQuery : IDBQuery
    {
        public void Executar()
        {
            Console.WriteLine("Executando query sql.");
        }
    }
}
