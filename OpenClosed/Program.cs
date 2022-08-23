using OpenClosed.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        DocumentoContable factura = new Factura(1);
        DocumentoContable notaCredito = new NotaCredito(2);
        DocumentoContable notaDebito = new NotaDebito(3);

        System.Console.WriteLine(factura.Imprimir());
        System.Console.WriteLine(notaCredito.Imprimir());
        System.Console.WriteLine(notaDebito.Imprimir());
    }
}