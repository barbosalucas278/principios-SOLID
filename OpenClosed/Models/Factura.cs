namespace OpenClosed.Models
{
    class Factura : DocumentoContable
    {
        public Factura(int numero) : base(numero)
        {
        }

        protected override string Descripcion()
        {
            return $"Factura - {Numero}";
        }
    }
}