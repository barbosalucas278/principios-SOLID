using System.ComponentModel.Design.Serialization;

Cliente cliente = new Cliente("Lucas", "Barbosa");
Producto arroz = new Producto("Arroz Gallo", 20.30);
Producto fideos = new Producto("Fideos Marolio", 50.25);

Factura factura = new Factura(1, DateTime.Now, cliente);
factura.AgregarItem(arroz, 10);
factura.AgregarItem(fideos, 20);

System.Console.WriteLine(factura.Total());
