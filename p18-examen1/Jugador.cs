public class Jugador {
    public string Nombre {get; set;}
    public int AñoNac {get; set;}
    public char Sexo {get; set;}
    public bool Becado {get; set;}

    public Jugador() {}
    public Jugador(string nombre, int añonac, char sexo, bool becado) => (Nombre, AñoNac, Sexo, Becado) = (nombre, añonac, sexo, becado);

    public override string ToString() => $"Nombre: {Nombre, -10} AñoNac: {AñoNac, -10} Sexo:{Sexo, -5} Becado:{Becado, 5}";
}