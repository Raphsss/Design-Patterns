using FactoryMethodEx;

public class Program
{
    public static void Main(string[] args)
    {
        // Criando uma fábrica para PDF
        DocumentoFactory pdfFactory = new PdfDocumentoFactory();
        pdfFactory.gerarRelatorio(); // Saída: PDF exportado.

        // Criando uma fábrica para CSV
        DocumentoFactory csvFactory = new CsvDocumentoFactory();
        csvFactory.gerarRelatorio(); // Saída: CSV exportado.
    }
}