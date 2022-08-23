
using InterfaceSegregation.Models;

namespace InterfaceSegregation
{
    public class Factura : Documento
    {
        public int CAI { get; set; }
        public Factura(DateTime fecha, int numero, int cai) : base(fecha, numero)
        {
            CAI = cai;
        }

        public override void Imprimir()
        {
            System.Console.WriteLine($"Numero: {Numero} | Fecha: {Fecha.ToShortDateString()} CAI: {CAI}");
        }
    }
}