namespace LiskovSubtitution.Models
{
    public abstract class DocumentoContable : IPrintable
    {
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int Numero { get; set; }
        protected string? _sigla { get; set; }
        public DocumentoContable(int numero, DateTime fecha, double importe)
        {
            Numero = numero;
            Fecha = fecha;
            Importe = importe;
        }
        protected string Descripcion()
        {
            return $"{_sigla} - {Numero} - {Fecha.ToShortDateString()} | {Importe}";
        }
        public string Imprimir()
        {
            return this.Descripcion();
        }
    }
}