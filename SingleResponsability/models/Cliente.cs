public class Cliente
{
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public Cliente(string nombre, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
    }
}