public class Producto
{
    public string Descripcion { get; private set; }
    public double Precio { get; private set; }
    public Producto(string descripcion, double precio)
    {
        Descripcion = descripcion;
        Precio = precio;
    }
}