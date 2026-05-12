using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodEx
{
    public class DocumentoPDF : IDocumento
    {
        public void ExportarDocumento()
        {
            Console.WriteLine("PDF exportado.");
        }
    }
}
