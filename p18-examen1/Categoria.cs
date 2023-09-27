//una categoria puede tener varios jugadores
public class Categoria {
    
    public string Nombre {get; set;}
    
    public string Rango {get; set;}

    public double Costo {get; set;}
    
    public List <Jugador> Jugadores {get; set;}

    public Categoria() => Jugadores = new List<Jugador>();
    
    public Categoria(string nombre, string rango, double costo) : this() => (Nombre, Rango, Costo) = (nombre, rango, costo);
    
    public void AgregarJugador(Jugador jugador) => Jugadores.Add(jugador);
    public override string ToString() => $"Nombre: {Nombre, -10} Rango: {Rango, -15} Costo: {Costo}";
}