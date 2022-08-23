using InterfaceSegregation.Models;

namespace InterfaceSegregation
{
    public class FacturaElectronica : Documento, IEmaileable
    {
        public int CAE { get; set; }
        public FacturaElectronica(DateTime fecha, int numero, int cae) : base(fecha, numero)
        {
            CAE = cae;
        }

        public override void Imprimir()
        {
            System.Console.WriteLine($"Numero: {Numero} | Fecha: {Fecha.ToShortDateString()} CAE: {CAE}");
        }

        public void EnviarPorEmail()
        {
            System.Console.WriteLine($"Enviando email...");
            Imprimir();
        }
    }
}