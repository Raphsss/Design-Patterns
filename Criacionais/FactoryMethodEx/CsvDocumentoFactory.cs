using System;

namespace FactoryMethodEx
{
    // Fábrica concreta que cria DocumentoCSV
    public class CsvDocumentoFactory : DocumentoFactory
    {
        public override IDocumento CriarDocumento()
        {
            return new DocumentoCSV();
        }
    }
}