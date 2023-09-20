//crea un programa para calcular datos de un arreglo
int suma = 0;
int rest = 0;
double sumaDiv = 0;
int[] Arreglo = {100, 123, 456, 222, 999, 895, 325, 234, 322, 988};

for (int i = 0; i < Arreglo.Length; i++) {
    Console.WriteLine($"numero {i + 1}: {Arreglo[i]}");
}
for (int i = 0; i < Arreglo.Length; i++) {
    suma = suma + Arreglo[i];
}
Console.WriteLine($"La suma es: {suma}");
for (int i = 0; i < Arreglo.Length; i++) {
    rest = Arreglo[i] / 2;
    sumaDiv = sumaDiv + rest;
}
Console.WriteLine($"La suma con division es: {sumaDiv}");
for (int i = Arreglo.Length - 1; i >= 0; i--) {
    Console.WriteLine($"numero {i}: {Arreglo[i]}");
}