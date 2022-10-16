// Etapa 7: Stack, Heap e Garbage Collecotr


using Models.Pessoa;



namespace Modulo2.Etapa07;

public class Etapa_07
{
    public static void SubCap01()
    {
        Pessoa p1 = new Pessoa("Michel", "Metran");
        Pessoa p2 = new Pessoa("Zé", "das Couves");
        
        Console.WriteLine($"{p1.Nome}");
        Console.WriteLine($"{p2.Nome}");
        
        // Se eu tento copiar o objeto, eu estou copiando apenas a referência!!
        // Se eu altero o objeto, FODEU!! Dá merda!
        // É preciso usar um clone, alguma outra coisa...
        Pessoa p3 = p1;
        p3.Nome = "Maria";
        Console.WriteLine($"{p1.Nome}");
        Console.WriteLine($"{p3.Nome}");
    }

    public static void SubCap02()
    {
        int a = 10;
        int b = a;
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");

        b = 60;
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
    }
}