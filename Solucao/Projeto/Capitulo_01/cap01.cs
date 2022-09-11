using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Projeto.Capitulo_01;

public class Cap01
{
    public static void SubCap01()
    {
        // Printa com variáveis
        string variavel = "ABC";
        Console.WriteLine($"Hello, World! {variavel}");

        // Variáveis
        int quantidade = 1;
        Console.WriteLine($"Valor da variável: {quantidade}");

        string textos = "texto";
        Console.WriteLine(textos);

        double valor = 1.50;
        Console.WriteLine(valor);

        decimal salario = 2.00M;
        Console.WriteLine(salario);

        bool verdade = true;
        Console.WriteLine(verdade);

        // Ajusta formatos
        Console.WriteLine(valor.ToString("0.00"));

        // Operações Básicas
        double valorSoma = valor + quantidade;
        Console.WriteLine(valorSoma);

        valorSoma = valorSoma += 50;
        Console.WriteLine(valorSoma);

        valorSoma = valorSoma -= 20;
        Console.WriteLine(valorSoma);

        valorSoma = valorSoma *= 20;
        Console.WriteLine(valorSoma);

        double valorMultiplica = valor * quantidade + 2;
        Console.WriteLine(valorMultiplica);
    }

    public static void SubCap02()
    {
        // Trabalhando com datas
        DateTime dataAtual = DateTime.Now;
        Console.WriteLine(dataAtual);

        dataAtual = dataAtual.AddDays(5);
        Console.WriteLine(dataAtual);
        Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
    }

    public static void SubCap03()
    {
        // Convertendo Formatos

        // String para Número
        string texto_numerico = "5";
        int a = Convert.ToInt32(texto_numerico);
        Console.WriteLine(a);

        // Convert não dá erro!
        int a1 = Convert.ToInt32(null);
        Console.WriteLine(a1);

        // Parse dá erro com nulo
        // int a2 = Int32.Parse(null);
        // Console.WriteLine(a2);

        int b = Int32.Parse(texto_numerico);
        Console.WriteLine(b);

        // Conversão Condicional
        Int32.TryParse(texto_numerico, out int b1);
        Console.WriteLine($"Foiiiii {b1}");
        
        // Número para String 
        // Ajusta formatos
        string a3 = a.ToString();
        Console.WriteLine(a3);
    }
}



