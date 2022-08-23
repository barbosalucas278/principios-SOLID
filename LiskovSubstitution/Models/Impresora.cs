using LiskovSubtitution.Models;

namespace LiskovSubstitution.Models
{
    public static class Impresora
    {
        public static void Imprimir(IPrintable documento)
        {
            System.Console.WriteLine(documento.Imprimir());
        }
    }
}