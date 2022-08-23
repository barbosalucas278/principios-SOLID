namespace OpenClosed.Models
{
    class NotaDebito : DocumentoContable
    {
        public NotaDebito(int numero) : base(numero)
        {
        }
        protected override string Descripcion()
        {
            return $"Nota de debito - {Numero}";
        }
    }
}