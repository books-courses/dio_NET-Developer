// Etapa 4: Tuplas, operadores ternários e descontrução de objeto

namespace Modulo2.Etapa04;

public class Etapa_04
{
    public static void SubCap01()
    {
        Console.WriteLine("Etapa 4: Tuplas, operadores ternários e descontrução de objeto");
        Console.WriteLine("Tuplas");
        // Primeira forma de representar tuplas
        (int, string, string, decimal) tupla = (1, "Michel", "Metran", 10.4M);
        Console.WriteLine($"{tupla.Item1}");
        Console.WriteLine($"{tupla.Item4}");
        
        // Segunda forma de representar tuplas
        ValueTuple<int, string, string, decimal> tupla2 = (1, "Michel", "Metran", 10.4M);
        Console.WriteLine($"{tupla2.Item1}");
        Console.WriteLine($"{tupla2.Item4}");
        
        // Terceira forma de representar tuplas
        var tupla3 = Tuple.Create(1, "Michel", "Metran", 10.4M);
        Console.WriteLine($"{tupla3.Item2}");
    }

    public static (bool Sucesso, string[] linhas, int QuantidadeLinhas) SubCap02(string caminho)
    {
        try
        {
            Console.WriteLine("Tuplas");
            string[] linhas = File.ReadAllLines(caminho);
            return (true, linhas, linhas.Count());
        }
        catch(Exception ex)
        {
            return (false, new string[0], 0);
        }
    }

    public static void SubCap03()
    {
        // IF Padrão
        int numero = 20;

        if (numero % 2 == 0)
        {
            Console.WriteLine($"O {numero} é par");
        }
        else
        {
            Console.WriteLine($"O {numero} é impar");
        }
        
        // IF ternário: menos verboso
        bool ehPar = false;
        ehPar = numero % 2 == 0;
        Console.WriteLine($"O {numero} é (IF Ternário) " + (ehPar ? "par" : "ímpar"));
    }
}

