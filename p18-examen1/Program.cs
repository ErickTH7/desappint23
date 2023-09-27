// clase principal 

Academia miacademia = new Academia {Nombre = "Academia cumyamigos", Domicilio = "campus siglo XXI", Propietario = "Erick Alejandro Torres"};

Console.WriteLine(miacademia.ToString());
//agregar categorias a la academia

miacademia.AgregarCategoria(new Categoria {Nombre = "Junior A", Rango = "2006/2007/2008", Costo = 1250});

miacademia.AgregarCategoria(new Categoria {Nombre = "Junior B", Rango = "2009/2010/1011", Costo = 850});

miacademia.AgregarCategoria(new Categoria {Nombre = "Pony A",   Rango = "2012/2013/2014", Costo = 700});

// agregar jugadores

miacademia.Categorias[0].AgregarJugador(new Jugador {Nombre="pepe", AñoNac = 2016, Sexo = 'H', Becado = false});
miacademia.Categorias[0].AgregarJugador(new Jugador {Nombre="Alexander", AñoNac = 2017, Sexo = 'H', Becado = true});
miacademia.Categorias[0].AgregarJugador(new Jugador {Nombre="Alejandra", AñoNac = 2018, Sexo = 'M', Becado = false});

miacademia.Categorias[1].AgregarJugador(new Jugador {Nombre="Armando", AñoNac = 2009, Sexo = 'H', Becado = false});
miacademia.Categorias[1].AgregarJugador(new Jugador {Nombre="Daniel", AñoNac = 2010, Sexo = 'H', Becado = false});
miacademia.Categorias[1].AgregarJugador(new Jugador {Nombre="Antonio", AñoNac = 2011, Sexo = 'M', Becado = true});

miacademia.Categorias[2].AgregarJugador(new Jugador {Nombre="Andrea", AñoNac = 2012, Sexo = 'M', Becado = true});
miacademia.Categorias[2].AgregarJugador(new Jugador {Nombre="Marisa", AñoNac = 2013, Sexo = 'M', Becado = true});
miacademia.Categorias[2].AgregarJugador(new Jugador {Nombre="Diana", AñoNac = 2014, Sexo = 'M', Becado = false});


//reporte academia
Console.Clear();
Console.WriteLine("Reporte del club deportivo\n");
Console.WriteLine(miacademia.ToString());
Console.WriteLine($"\n Total de categorias: {miacademia.Categorias.Count()}");


Console.WriteLine($"\n Total de Jugadores: {miacademia.Categorias.Count()}");
Console.WriteLine("\n>> Datos generales de los clientes:\n");
foreach(Categoria categoria in miacademia.Categorias) {
    Console.WriteLine(categoria.ToString());
}
// jugadores
Console.WriteLine("\n>> jugadores por categoria:\n");
foreach(Categoria categoria in miacademia.Categorias) {
    Console.WriteLine($">{categoria.Nombre} - {categoria.Rango}");
    foreach (Jugador jugador in categoria.Jugadores)
        Console.WriteLine(jugador.ToString());
}