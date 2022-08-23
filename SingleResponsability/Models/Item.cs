public class Item
{
    public int Cantidad { get; private set; }
    public Producto Producto { get; private set; }
    public Item(int cantidad, Producto producto)
    {
        Cantidad = cantidad;
        Producto = producto;
    }
    public double Subtotal()
    {
        return Producto.Precio * Cantidad;
    }
}