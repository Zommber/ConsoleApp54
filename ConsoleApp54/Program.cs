using System.Security.Cryptography;

Console.Write("Introduce el primer número: ");
if (!double.TryParse(Console.ReadLine(), out var a))
{
    Console.WriteLine("Entrada inválida.");
    return;
}

Console.Write("Introduce el segundo número: ");
if (!double.TryParse(Console.ReadLine(), out var b))
{
    Console.WriteLine("Entrada inválida.");
    return;
}

var suma = new Suma();
var resta = new Resta();
var multiplicacion = new Multiplicacion();

Console.WriteLine($"Suma: {suma.Calcular(a, b)}");
Console.WriteLine($"Resta: {resta.Calcular(a, b)}");
Console.WriteLine($"Multiplicación: {multiplicacion.Calcular(a, b)}");