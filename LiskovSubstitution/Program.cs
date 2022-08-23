using LiskovSubstitution.Models;
using LiskovSubtitution.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        DocumentoContable factura = new Factura(1, DateTime.Now, 10);
        DocumentoContable notaCredito = new NotaCredito(2, DateTime.Now, 20);
        DocumentoContable notaDebito = new NotaDebito(3, DateTime.Now, 30);
        Remito remito = new Remito(DateTime.Now, 4, 55);
        Impresora.Imprimir(factura);
        Impresora.Imprimir(notaCredito);
        Impresora.Imprimir(notaDebito);
        Impresora.Imprimir(remito);
    }
}