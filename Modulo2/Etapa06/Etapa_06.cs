// Etapa 6: Tipos Especiais no C#


using System.Collections.Concurrent;

namespace Modulo2.Etapa06;

public class Etapa_06
{
    public static void SubCap01()
    {
        Console.WriteLine("// Etapa 6: Tipos Especiais no C#");
        // Tipo Nulo: precisa ter o ? na definição da variável
        // (bool desejaReceberEmail = null) não funcionaria!;
        bool? desejaReceberEmail = true;
        Console.WriteLine($"{desejaReceberEmail}");

        if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
        {
            Console.WriteLine($"O usuário optou por receber");
            Console.WriteLine($"{desejaReceberEmail.Value}");
        }
        else
        {
            Console.WriteLine($"O usuário não respondeu, ou optou por não receber");
        }
    }

    public static void SubCap02()
    {
        Console.WriteLine("Estudando tipo 'Anônimo'");
        var tipoAnonimo = new { Nome = "Michel", Sobrenome = "Metran", Altura = 1.80 };
        Console.WriteLine($"{tipoAnonimo.Nome}");
        Console.WriteLine($"{tipoAnonimo.Sobrenome}");
        Console.WriteLine($"{tipoAnonimo.Altura}");
    }

    public static void SubCap03()
    {
        Console.WriteLine("Estudando tipo 'Dynamic'");

        dynamic variavelDinamica = 4;
        Console.WriteLine($"Tipo: {variavelDinamica.GetType()} e Valor: {variavelDinamica}");

        variavelDinamica = "teste";
        Console.WriteLine($"Tipo: {variavelDinamica.GetType()} e Valor: {variavelDinamica}");
    }

    public static void SubCap04()
    {
        Console.WriteLine("Estudando 'Classes Genéricas'");
        // Ver Models.MeuArray
    }

    public static void SubCap05()
    {
        Console.WriteLine("Estudando 'Métodos de Extensão'");
        int numero = 20;
        bool par = false;

        // IF Ternário
        par = numero % 2 == 0;
        string mensagem = $"O número {numero} é {(par ? "par" : "impar")}";
        Console.WriteLine(mensagem);
        // Ver Model.IntExtension
    }
}