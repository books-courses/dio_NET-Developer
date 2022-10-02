//
//
//


namespace Modulo1.Capitulo_01;

public class Cap01
{
    public static void SubCap01()
    {
        // Printa com variáveis
        var variavel = "ABC";
        Console.WriteLine($"Hello, World! {variavel}");

        // Variáveis
        var quantidade = 1;
        Console.WriteLine($"Valor da variável: {quantidade}");

        var textos = "texto";
        Console.WriteLine(textos);

        var valor = 1.50;
        Console.WriteLine(valor);

        var salario = 2.00M;
        Console.WriteLine(salario);

        var verdade = true;
        Console.WriteLine(verdade);

        // Ajusta formatos
        Console.WriteLine(valor.ToString("0.00"));

        // Operações Básicas
        var valorSoma = valor + quantidade;
        Console.WriteLine(valorSoma);

        valorSoma = valorSoma += 50;
        Console.WriteLine(valorSoma);

        valorSoma = valorSoma -= 20;
        Console.WriteLine(valorSoma);

        valorSoma = valorSoma *= 20;
        Console.WriteLine(valorSoma);

        var valorMultiplica = valor * quantidade + 2;
        Console.WriteLine(valorMultiplica);
    }

    public static void SubCap02()
    {
        // Trabalhando com datas
        var dataAtual = DateTime.Now;
        Console.WriteLine(dataAtual);

        dataAtual = dataAtual.AddDays(5);
        Console.WriteLine(dataAtual);
        Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
    }

    public static void SubCap03()
    {
        // Convertendo Formatos

        // String para Número
        var texto_numerico = "5";
        var a = Convert.ToInt32(texto_numerico);
        Console.WriteLine(a);

        // Convert não dá erro!
        var a1 = Convert.ToInt32(null);
        Console.WriteLine(a1);

        // Parse dá erro com nulo
        // int a2 = Int32.Parse(null);
        // Console.WriteLine(a2);

        var b = int.Parse(texto_numerico);
        Console.WriteLine(b);

        // Conversão Condicional
        int.TryParse(texto_numerico, out var b1);
        Console.WriteLine($"Foiiiii {b1}");

        // Número para String 
        // Ajusta formatos
        var a3 = a.ToString();
        Console.WriteLine(a3);
    }
}