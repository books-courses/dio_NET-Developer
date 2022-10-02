namespace Desafio1;

public class DIO
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var n = 0;
        var resultado = int.TryParse(Console.ReadLine(), out n);
        Console.WriteLine($"O valor de n é {n} e {resultado}");

        var p = 1;
        var s = 0;
        while (n > 0)
        {
            var l = n % 10;
            // TODO: Crie as outras condições necessárias para a resolução do desafio:
            p *= l;
            s += l;
            n /= 10;
        }
        Console.WriteLine(p - s);
    }
}
