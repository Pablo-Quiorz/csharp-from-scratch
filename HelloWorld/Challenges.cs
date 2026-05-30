public class Fraction
{
    public int Numerador { get; set; }
    public int Denominador { get; set; }

    public Fraction(int num, int den)
    {
        Numerador = num;
        Denominador = den;
    }

    public static string Sumar(Fraction f1, Fraction f2)
    {
        int num = (f1.Numerador * f2.Denominador) + (f2.Numerador * f1.Denominador);
        int den = f1.Denominador * f2.Denominador;
        return $"{num}/{den}";
    }
}

public class Challenges
{
    // Challenge 1: Determinar si un número es positivo, negativo o cero [4, 5]
    public void Challenge1()
    {
        Console.WriteLine("Ingrese un número:");
        int num = int.Parse(Console.ReadLine());
        if (num > 0) Console.WriteLine("Es positivo");
        else if (num < 0) Console.WriteLine("Es negativo");
        else Console.WriteLine("Es cero");
    }

    // Challenge 2: El mayor de dos números [5]
    public void Challenge2()
    {
        Console.WriteLine("Ingrese primer número:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese segundo número:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"El mayor es: {(a > b ? a : b)}");
    }

    // Challenge 3: Cuadrado de un número [5]
    public void Challenge3()
    {
        Console.WriteLine("Ingrese un número:");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine($"El cuadrado es: {n * n}");
    }

    // Challenge 4: Área de un círculo [5, 6]
    public void Challenge4()
    {
        Console.WriteLine("Ingrese el radio:");
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * Math.Pow(r, 2);
        Console.WriteLine($"El área es: {area}");
    }

    // Challenge 5: Día de la semana (1-7) [5, 7]
    public void Challenge5()
    {
        Console.WriteLine("Ingrese un número del 1 al 7:");
        int dia = int.Parse(Console.ReadLine());
        switch (dia)
        {
            case 1: Console.WriteLine("Lunes"); break;
            case 2: Console.WriteLine("Martes"); break;
            case 3: Console.WriteLine("Miércoles"); break;
            case 4: Console.WriteLine("Jueves"); break;
            case 5: Console.WriteLine("Viernes"); break;
            case 6: Console.WriteLine("Sábado"); break;
            case 7: Console.WriteLine("Domingo"); break;
            default: Console.WriteLine("Número no válido"); break;
        }
    }

    // Challenge 6: Cálculo de impuestos (10% si > 1000) [7]
    public void Challenge6()
    {
        Console.WriteLine("Ingrese salario mensual:");
        double salario = double.Parse(Console.ReadLine());
        if (salario > 1000) Console.WriteLine($"Impuesto (10%): {salario * 0.10}");
        else Console.WriteLine("No aplica impuesto.");
    }

    // Challenge 7: División con Try-Catch [7, 8]
    public void Challenge7()
    {
        try
        {
            Console.WriteLine("Ingrese dividendo:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese divisor:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado: {a / b}");
        }
        catch (DivideByZeroException) { Console.WriteLine("Error: No se puede dividir por cero."); }
        catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }
    }

    // Challenge 8: Suma de números impares (1-100) [3, 7]
    public void Challenge8()
    {
        int suma = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0) suma += i;
        }
        Console.WriteLine($"La suma de impares del 1 al 100 es: {suma}");
    }

    // Challenge 9: Suma de fracciones [3]
    public void Challenge9()
    {
        Console.WriteLine("Fracción 1 - Numerador:");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Fracción 1 - Denominador:");
        int d1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Fracción 2 - Numerador:");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Fracción 2 - Denominador:");
        int d2 = int.Parse(Console.ReadLine());

        Fraction f1 = new Fraction(n1, d1);
        Fraction f2 = new Fraction(n2, d2);
        Console.WriteLine($"La suma es: {Fraction.Sumar(f1, f2)}");
    }

    // Challenge 10: Invertir una palabra [3]
    public void Challenge10()
    {
        Console.WriteLine("Ingrese una palabra:");
        string palabra = Console.ReadLine();
        char[] caracteres = palabra.ToCharArray();
        Array.Reverse(caracteres);
        Console.WriteLine($"Invertida: {new string(caracteres)}");
    }

    // Challenge 11: Promedio de tres números [9]
    public void Challenge11()
    {
        Console.WriteLine("Ingrese tres números:");
        double n1 = double.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine());
        double n3 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Promedio: {(n1 + n2 + n3) / 3}");
    }

    // Challenge 12: El más grande de cinco números (Uso de listas y .Max()) [9]
    public void Challenge12()
    {
        List<int> numeros = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Ingrese número {i + 1}:");
            numeros.Add(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine($"El número más grande es: {numeros.Max()}");
    }

    // Challenge 13: Palíndromo [9]
    public void Challenge13()
    {
        Console.WriteLine("Ingrese una palabra:");
        string original = Console.ReadLine().ToLower();
        string invertida = new string(original.ToCharArray().Reverse().ToArray());
        if (original == invertida) Console.WriteLine("Es un palíndromo.");
        else Console.WriteLine("No es un palíndromo.");
    }

    // Challenge 14: Par o impar [10]
    public void Challenge14()
    {
        Console.WriteLine("Ingrese un número:");
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0) Console.WriteLine("Es par");
        else Console.WriteLine("Es impar");
    }

    // Challenge 15: Rango 0-10 [10]
    public void Challenge15()
    {
        Console.WriteLine("Ingrese un número:");
        int n = int.Parse(Console.ReadLine());
        if (n >= 0 && n <= 10) Console.WriteLine("Está dentro del rango 0-10");
        else Console.WriteLine("Fuera de rango");
    }
}
