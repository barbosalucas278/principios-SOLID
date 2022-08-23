namespace OpenClosed.Models
{
    class NotaCredito : DocumentoContable
    {
        public NotaCredito(int numero) : base(numero)
        {
        }

        protected override string Descripcion()
        {
            return $"Nota de credito - {Numero}";
        }
    }
}