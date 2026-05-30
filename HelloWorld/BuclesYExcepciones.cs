// Bucle Fibonacci [22, 25]
int a = 0, b = 1, temp;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(a);
    temp = a;
    a = b;
    b = temp + b;
}

// Manejo de Excepciones [23, 24]
try 
{
    Console.WriteLine("Ingrese divisor:");
    int divisor = int.Parse(Console.ReadLine());
    int resultado = 10 / divisor;
}
catch (DivideByZeroException) 
{
    Console.WriteLine("Error: No se puede dividir por cero.");
}
catch (Exception ex) 
{
    Console.WriteLine($"Error desconocido: {ex.Message}");
}
