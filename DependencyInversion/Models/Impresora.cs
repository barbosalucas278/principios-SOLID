namespace DependencyInversion.Models
{
    public static class Impresora
    {
        public static void ImprimirDocumento(IImprimible documento)
        {
            System.Console.WriteLine(documento.Imprimir());
        }
    }
}