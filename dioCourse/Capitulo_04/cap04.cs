// Estruturas de Repetição

namespace dioCourse.Capitulo_04;

public class Cap04
{
    public static void SubCap01()
    {
        // For
        Console.WriteLine("FOR");
        int numero = 5;
        for (int contador = 0; contador <= 10; contador++)
        {
            Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        }
    }

    public static void SubCap02()
    {
        // While
        Console.WriteLine($"WHI" + $"LE");
        int numero = 5;
        int contador = 0;
        while (contador <= 10)
        {
            contador++;
            Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        }
    }

    public static void SubCap03()
    {
        // While
        Console.WriteLine("While Break");
        //TODO: Erro!
        int numero = 5;
        int contador = 0;
        while (contador <= 10)
        {
            Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            contador++;
            if (contador == 5)
            {
                Console.WriteLine("break!!!");
                break;
            }
        }
    }

    public static void SubCap04()
    {
        // While
        Console.WriteLine("Do While");
        int numero = 0;
        int soma = 0;

        do
        {
            Console.WriteLine("Digite um número (0 para parar)");
            numero = Convert.ToInt32(Console.ReadLine());
            soma += numero;
            Console.WriteLine($"{soma}");
        } while (numero != 0);

        Console.WriteLine($"Total da Soma dos números é {soma}");
    }

    public static void SubCap05()
    {
        Console.WriteLine("Menu");
        string? opcao;
        bool exibirMenu = true;

        
        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Digite a sua opção");
            Console.WriteLine("1. Cadastrar cliente");
            Console.WriteLine("2. Buscar cliente");
            Console.WriteLine("3. Apagar cliente");
            Console.WriteLine("4. Encerrar");
            opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Cadastrar cliente");
                    break;
                case "2":
                    Console.WriteLine("Buscar cliente");
                    break;
                case "3":
                    Console.WriteLine("Apagar cliente");
                    break;
                case "4":
                    Console.WriteLine("Encerrar");
                    //Environment.Exit(0);
                    exibirMenu = false;
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }

    }
    
    
    
    
    
}
