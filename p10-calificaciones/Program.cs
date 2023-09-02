// Emitir una calificación con letra y un mensaje de acuerdo al promedio, según la tabla

double calificacion = 0;

Console.Write("Escribe tu nombre: \n"); string nombre = Console.ReadLine();

do {
    Console.WriteLine ("Escribe una calificacion entre 0 y 10\n");
    Console.Write("Digita tu calificación: "); calificacion = Convert.ToDouble(Console.ReadLine());
} while (calificacion < 0 || calificacion > 10);
Console.Clear();
if (calificacion <= 5.9) {
    tabla(nombre);
    Console.WriteLine($"{calificacion}\t\tD\tAndas mal");
} else {
    if (calificacion >= 6 && calificacion <= 7.5){
        tabla(nombre);
        Console.WriteLine($"{calificacion}\t\tC\tMucho mejor");
    }else {
       if (calificacion >= 7.6 && calificacion <= 8.5){
        tabla(nombre);
        Console.WriteLine($"{calificacion}\t\tB\tMuy bien");
        }
        else{
            tabla(nombre);
            Console.WriteLine($"{calificacion}\t\tA\tExelente"); 
        }
    }
}
static void tabla(string nombre) {
        Console.WriteLine($"Hola {nombre}");
        Console.WriteLine("Promedio\tLetra\tMensaje");
}