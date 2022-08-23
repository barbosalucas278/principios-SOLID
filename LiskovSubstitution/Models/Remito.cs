using LiskovSubtitution.Models;

namespace LiskovSubstitution.Models
{
    public class Remito : IPrintable
    {
        public Remito(DateTime fecha, int numero, int cantidadBultos)
        {
            Fecha = fecha;
            Numero = numero;
            CantidadBultos = cantidadBultos;
        }

        public DateTime Fecha { get; private set; }
        public int Numero { get; private set; }
        public int CantidadBultos { get; private set; }
        public string Descripcion()
        {
            return $"Remito {Numero} con fecha {Fecha.ToShortDateString()} y {CantidadBultos} bultos.";
        }
        public string Imprimir()
        {
            return Descripcion();
        }
    }
}