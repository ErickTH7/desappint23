
Tienda mitienda = new Tienda {Nombre = "Ferreteria las lomas", Domicilio = "Av. Luis Moya 345", Propietario = "Erick Torres"};

//Agregar clientes a la tienda
//este no
//mitienda.Clientes.Add(new Cliente {Nombre = "Felipe Calderon", RFC = "APOCOSITILIN", Domicilio = "Las lomas de bracho", Correo = "Calderon@gmail.com"});

mitienda.AgregarCliente (new Cliente {Nombre = "Felipe Calderon", RFC = "APOCOSITILIN", Domicilio = "Las lomas de bracho", Correo = "Calderon@gmail.com"});

mitienda.AgregarCliente (new Cliente {Nombre = "Enrique peña", RFC = "elpepe23434", Domicilio = "5 de mayo 3221", Correo = "elpeña@gmail.com"});

mitienda.AgregarCliente (new Cliente {Nombre = "andres lopez", RFC = "AMLO23434", Domicilio = "6 de mayo 3221", Correo = "elkiki@gmail.com"});

mitienda.AgregarCliente (new Cliente {Nombre = "xochitl gelatinas", RFC = "GELA666", Domicilio = "danone 123", Correo = "xochitl@gmail.com"});

//agregar ventas a los clientes
mitienda.Clientes[0].AgregarVenta(new Venta {Articulo="Martillo", Cantidad = 10, Precio = 60.5});
mitienda.Clientes[0].AgregarVenta(new Venta {Articulo="pala", Cantidad = 2, Precio = 170.5});
mitienda.Clientes[1].AgregarVenta(new Venta {Articulo="clavo", Cantidad = 2.5, Precio = 7.5});
mitienda.Clientes[1].AgregarVenta(new Venta {Articulo="cinta de aislar", Cantidad = 5, Precio = 7.53});
mitienda.Clientes[1].AgregarVenta(new Venta {Articulo="pinzas", Cantidad = 5, Precio = 60.53});



//reporte
Console.Clear();
Console.WriteLine("Reporte de Ventas en Tienda\n");
Console.WriteLine(mitienda.ToString());
Console.WriteLine($"\n Total de Clientes: {mitienda.Clientes.Count()}");

Console.WriteLine("\n>> Datos generales de los clientes:\n");
foreach(Cliente cliente in mitienda.Clientes) {
    Console.WriteLine(cliente.ToString());
}

Console.WriteLine("\n>> ventas de clientes:\n");
foreach(Cliente cliente in mitienda.Clientes) {
    Console.WriteLine($">{cliente.Nombre} - {Cliente.RFC}");
    foreach (Venta venta in cliente.Ventas)
        Console.WriteLine(venta.ToString());
}