using System;

public class Factura
{
    public int Numero { get; private set; }
    public DateTime Fecha { get; private set; }
    public Cliente Cliente { get; private set; }
    public Factura(int numero, DateTime fecha, Cliente cliente)
    {
        Numero = numero;
        Fecha = fecha;
        Cliente = cliente;
    }
    public double Total()
    {
        throw new NotImplementedException();
    }
}