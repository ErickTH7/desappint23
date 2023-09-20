Console.Clear();

Tienda tienda = new Tienda("Walmart","Johan manuel","Zacatecas");
Console.Write(tienda.ToString());

Cliente cliente01 = new Cliente("Mario","mario123","Zacatecas","Mariok@gmail.com",0);
tienda.AgregarCliente(cliente01);
Venta venta01 = new Venta("Sandia",8,10);
cliente01.sumaT(venta01.subT(venta01.Cantidad,venta01.Precio));
tienda.TotalD(venta01.subtotal);
Console.WriteLine(cliente01.ToString());


Cliente cliente02 = new Cliente("Julio","julio12","Zacatecas","Julio@hotmail.com",0);
tienda.AgregarCliente(cliente02);
Venta venta02 = new Venta("Pera",9,1.87);
cliente02.sumaT(venta02.subT(venta02.Cantidad,venta02.Precio));
tienda.TotalD(venta02.subtotal);
Console.WriteLine(cliente02.ToString());

Venta venta03 = new Venta("Pc gamer",1,9000);
cliente01.sumaT(venta03.subT(venta03.Cantidad,venta03.Precio));
tienda.TotalD(venta03.subtotal);
Console.WriteLine(cliente01.ToString());

Console.Write(tienda.ToString());