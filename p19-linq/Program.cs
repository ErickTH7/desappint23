﻿//consultas LINQ
// de datos

List<int> numeros = new() {5,4,1,3,9,8,6,7,2,0};

foreach (int n in numeros)
{
    Console.WriteLine(n);   
}

//consulta LINQ usando la sintaxis integrada
Console.WriteLine("\nNumeros Pares:");
var pares = from num in numeros where num%2==0 select num;
foreach (int n in pares)
{
    Console.WriteLine(n);   
}

// Consulta LINQ usando los metodos de extencion
Console.WriteLine("\nNumeros impares:");
var impares = numeros.Where(numeros=> numeros%2!=0);
foreach (int n in impares)
{
    Console.WriteLine(n);   
}

//consulta LINQ, sintaxis integrada, convertir a lista
Console.WriteLine("\nNumeros entre 5 a 9");
var rango1 = (from n in numeros where n>=5 && n<=9 select n).ToList();
rango1.ForEach(n=>Console.WriteLine(n));

//Consulta LINQ, métodos de extensión, convertir a lista
Console.WriteLine("\nNumeros entre 1 a 4");
var rango2 = numeros.Where(n => n >= 1 && n <= 4).ToList();
rango2.ForEach(n => Console.WriteLine(n));
