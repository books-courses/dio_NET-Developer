namespace Desafios.Desafio1;

public class DIO
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
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
