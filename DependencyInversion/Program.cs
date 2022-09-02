using DependencyInversion.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Factura factura = new Factura(DateTime.Now, 1, 123);
        FacturaElectronica facturaElectronica = new FacturaElectronica(DateTime.Now, 2, 333);

        Impresora.ImprimirDocumento(factura);
        Impresora.ImprimirDocumento(facturaElectronica);
    }
}