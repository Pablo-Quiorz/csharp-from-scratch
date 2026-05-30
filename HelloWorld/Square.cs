public class Square : Rectangle // Herencia [19]
{
    public double Lado 
    { 
        set { Base = value; Altura = value; } // El cuadrado tiene lados iguales [20]
    }
}
