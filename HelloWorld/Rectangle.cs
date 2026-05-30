public class Rectangle 
{
    public double Base { get; set; }
    public double Altura { get; set; }

    // Método abreviado con expresión lambda [21]
    public double CalcularArea() => Base * Altura;
    public double CalcularPerimetro() => 2 * (Base + Altura);
}
