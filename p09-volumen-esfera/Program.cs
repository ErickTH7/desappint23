// Dado el radio de un círculo, calcula el volumen de la esfera

double PI = 3.14159;
double radio = 0;
double volumen = 0;

Console.Write("Dame el radio de el circulo: "); radio = double.Parse(Console.ReadLine());

volumen = (4.0/3.0)*(Math.Pow(radio,3))*(PI);

Console.WriteLine($"El volumen es: {volumen}");