

namespace DependencyInversion.Models
{
    public class Factura : Documento
    {
        public int CAI { get; set; }
        public Factura(DateTime fecha, int numero, int cai) : base(fecha, numero)
        {
            CAI = cai;
        }

        public override string Imprimir()
        {
            return $"Numero: {Numero} | Fecha: {Fecha.ToShortDateString()} CAI: {CAI}";
        }
    }
}