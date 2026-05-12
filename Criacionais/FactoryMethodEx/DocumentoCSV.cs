using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodEx
{
    public class DocumentoCSV : IDocumento
    {
        public void ExportarDocumento()
        {
            Console.WriteLine("CSV exportado.");
        }
    }
}
