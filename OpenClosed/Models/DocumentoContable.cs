namespace OpenClosed.Models
{
    public abstract class DocumentoContable
    {
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int Numero { get; set; }
        public string? Sigla { get; set; }
        public DocumentoContable(int numero)
        {
            Numero = numero;
        }
        protected abstract string Descripcion();
        public string Imprimir()
        {
            return this.Descripcion();
        }
    }
}