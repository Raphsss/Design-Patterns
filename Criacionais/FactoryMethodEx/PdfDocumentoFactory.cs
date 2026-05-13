using System;

namespace FactoryMethodEx
{
    // Fábrica concreta que cria DocumentoPDF
    public class PdfDocumentoFactory : DocumentoFactory
    {
        public override IDocumento CriarDocumento()
        {
            return new DocumentoPDF();
        }
    }
}