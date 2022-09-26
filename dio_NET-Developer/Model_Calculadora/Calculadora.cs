// Conhecendo a Plataforma .NET com C#
// Operadores Aritméticos em C#


namespace dio_NET_Developer.Model_Calculadora;

public class Calculadora
{
    public void Somar(int x, int y)
    {
        Console.WriteLine($"{x} + {y} = {x + y}");
    }

    public void Subtrair(int x, int y)
    {
        Console.WriteLine($"{x} - {y} = {x - y}");
    }

    public void Multiplicar(int x, int y)
    {
        Console.WriteLine($"{x} x {y} = {x * y}");
    }

    public void Dividir(int x, int y)
    {
        Console.WriteLine($"{x} / {y} = {x / y}");
    }

    public void Potencia(int x, int y)
    {
        var pow = Math.Pow(x, y);
        Console.WriteLine($"{x} elevado a {y} = {pow}");
    }

    public void Seno(double angulo)
    {
        var radiano = angulo * Math.PI / 180;
        var seno = Math.Sin(radiano);
        Console.WriteLine($"Seno de {angulo} = {seno}");
    }

    public void Coseno(double angulo)
    {
        var radiano = angulo * Math.PI / 180;
        var coseno = Math.Cos(radiano);
        Console.WriteLine($"coseno de {angulo} = {Math.Round(coseno, 3)}");
    }

    public void Tangente(double angulo)
    {
        var radiano = angulo * Math.PI / 180;
        var tangente = Math.Tan(radiano);
        Console.WriteLine($"tangente de {angulo} = {tangente}");
    }

    public void RaizQuadrada(double x)
    {
        var raiz = Math.Sqrt(x);
        Console.WriteLine($"Raiz de {x} = {raiz}");
    }
}