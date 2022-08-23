using System;

public class Factura
{
    public int Numero { get; private set; }
    public DateTime Fecha { get; private set; }
    public Cliente Cliente { get; private set; }
    public List<Item> Items { get; private set; }
    public Factura(int numero, DateTime fecha, Cliente cliente)
    {
        Numero = numero;
        Fecha = fecha;
        Cliente = cliente;
        Items = new List<Item>();
    }
    public void AgregarItem(Producto producto, int cantidad)
    {
        Items.Add(new Item(cantidad, producto));
    }
    public double Total()
    {
        double total = 0;
        foreach (Item i in Items)
        {
            total += i.Subtotal();
        }
        return total;
    }
}