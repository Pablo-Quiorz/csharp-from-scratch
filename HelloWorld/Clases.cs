public class Person 
{
    public string Name { get; set; }
    public int Age { get; set; }
    public DateOnly DateOfBirth { get; set; } // Uso de DateOnly para fechas [1, 3]
}

// Ejemplo de captura de datos con validación [4, 5]
Console.WriteLine("Escribe tu fecha de nacimiento (DD/MM/AAAA):");
string input = Console.ReadLine();
DateOnly dateConverter;
bool isValid = DateOnly.TryParse(input, out dateConverter);

if (!isValid) 
{
    Console.WriteLine($"La fecha {input} es inválida.");
}

public interface IFigura 
{
    double CalcularArea();
}

public class Circle : IFigura 
{
    public double Radio { get; set; }
    public double CalcularArea() => Math.PI * Math.Pow(Radio, 2);
}
