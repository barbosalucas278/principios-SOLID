using InterfaceSegregation;
using InterfaceSegregation.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Factura factura = new Factura(DateTime.Now, 1, 123);
        FacturaElectronica facturaElectornica = new FacturaElectronica(DateTime.Now, 2, 321);

        factura.Imprimir();
        //factura.EnviarPorEmail(); no me estaria apareciendo ya que no implementa ese comportamiento
        facturaElectornica.Imprimir();
        facturaElectornica.EnviarPorEmail();
    }
}