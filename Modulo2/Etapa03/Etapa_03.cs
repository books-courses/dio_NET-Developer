// Etapa 3: Excessões e Coleções


using System.Reflection;

namespace Modulo2.Etapa03;

public class Etapa_03
{
    public static void SubCap01()
    {
        // var asm = System.Reflection.Assembly.GetExecutingAssembly();
        // var path = System.IO.Path.GetDirectoryName(asm.Location);
        // var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        // var path = Path.Combine(Directory.GetCurrentDirectory(), "fileName.txt");
        string path = Directory.GetCurrentDirectory();
        Console.WriteLine($"{path}");
        try
        {
            string[] linhas = File.ReadAllLines("data/exemplo9.txt");
            foreach (var linha in linhas)
            {
                Console.WriteLine($"{linha}");
            }
        }
        catch (FileLoadException ex)
        {
            Console.WriteLine($"Ocorreu uma exceção FileLoadException {ex.Message}");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Ocorreu uma exceção FileNotFoundException {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu uma exceção genérica {ex.Message}");
        }
        finally
        {
            Console.WriteLine($"Vai executar de qualqer jeito");
        }
    }


    /// <summary>
    /// Usado para Chamar o throw. Thorw: joga pra cima até chegar num catch ou no call da função
    /// </summary>
    public static void SubCap02_In()
    {
        try
        {
            SubCap02_Out();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu uma exceção do throw {ex.StackTrace}");
        }
    }


    /// <summary>
    /// 
    /// </summary>
    public static void SubCap02_Out()
    {
        SubCap02_Throw();
    }


    /// <summary>
    /// 
    /// </summary>
    /// <exception cref="Exception"></exception>
    public static void SubCap02_Throw()
    {
        throw new Exception("Ocorreu uma Exeção!");
    }


    /// <summary>
    /// Introdução às Filas: (FIFO First In, First Out)
    /// </summary>
    public static void SubCap03()
    {
        Queue<int> fila = new Queue<int>();
        fila.Enqueue(2);
        fila.Enqueue(4);
        fila.Enqueue(6);
        fila.Enqueue(8);
        foreach (var item in fila)
        {
            Console.WriteLine($"{item}");
        }

        Console.WriteLine($"Removendo o item # {fila.Dequeue()}");
        fila.Enqueue(10); // Add Outros
        fila.Enqueue(13); // Add Outros

        foreach (var item in fila)
        {
            Console.WriteLine($"{item}");
        }
    }

    /// <summary>
    /// Pilha (LIFO Last In, First Out) 
    /// </summary>
    public static void SubCap04()
    {
        Stack<int> pilha = new Stack<int>();
        pilha.Push(1);
        pilha.Push(3);
        pilha.Push(5);
        foreach (var item in pilha)
        {
            Console.WriteLine($"{item}");
        }

        Console.WriteLine($"Removendo o item # {pilha.Pop()}");
        pilha.Push(7);
        pilha.Push(9);
        foreach (var item in pilha)
        {
            Console.WriteLine($"{item}");
        }
    }

    
    /// <summary>
    /// Dicionários Chave Valor
    /// </summary>
    public static void SubCap05()
    {
        Dictionary<string, string> dictEstados = new Dictionary<string, string>();
        dictEstados.Add("MG", "Minas Gerais");
        dictEstados.Add("SP", "São Paulo");
        dictEstados.Add("BA", "Bahia");
        
        dictEstados.Remove("MG");
        
        foreach (var item in dictEstados)
        {
            Console.WriteLine($"{item.Key} e {item.Value}");
        }
        
        dictEstados["BA"] = "Baêa"; // Dá pra atualizar o valor, não a chave apenas deletando)
        foreach (var item in dictEstados)
        {
            Console.WriteLine($"{item.Key} e {item.Value}");
        }
        
        
        // Check
        string chave = "BA";
        Console.WriteLine($"Verificando o elemento {chave}");
        if (dictEstados.ContainsKey(chave))
        {
            Console.WriteLine($"Chave existente {chave}");
        }
        else
        {
            Console.WriteLine($"Chave inexistente {chave}");
            
        }
    }
}