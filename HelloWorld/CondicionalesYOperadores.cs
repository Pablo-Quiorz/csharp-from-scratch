// Algoritmo de número positivo/negativo [13]
Console.WriteLine("Ingrese un número:");
int num = int.Parse(Console.ReadLine());

if (num > 0) Console.WriteLine("Es positivo");
else if (num < 0) Console.WriteLine("Es negativo");
else Console.WriteLine("Es cero");

// Calculadora básica [16, 17]
Console.WriteLine("Ingrese el primer número:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número:");
double b = double.Parse(Console.ReadLine());

Console.WriteLine($"Suma: {a + b}");
Console.WriteLine($"Multiplicación: {a * b}");
// Condicional para división [15, 17]
string division = (b != 0) ? (a / b).ToString() : "Indeterminado";
Console.WriteLine($"División: {division}");
