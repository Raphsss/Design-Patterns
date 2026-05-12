using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodEx
{
    public abstract class DocumentoFactory
    {
        public abstract IDocumento CriarDocumento();

        public void gerarRelatorio()
        {
            IDocumento documento = CriarDocumento();
            documento.ExportarDocumento();
        }
    } 
}
