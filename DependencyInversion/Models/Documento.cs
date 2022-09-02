namespace DependencyInversion.Models
{
    public abstract class Documento : IImprimible
    {
        protected Documento(DateTime fecha, int numero)
        {
            Fecha = fecha;
            Numero = numero;
        }

        public DateTime Fecha { get; set; }
        public int Numero { get; set; }

        public abstract string Imprimir();
    }
}