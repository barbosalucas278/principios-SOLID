namespace LiskovSubtitution.Models
{
    public class NotaDebito : DocumentoContable
    {
        public NotaDebito(int numero, DateTime fecha, double importe) : base(numero, fecha, importe)
        {
            _sigla = "ND";
        }
    }
}