// Array e Listas


namespace Modulo1.Etapa13;

public class Etapa13
{
    public static void SubCap01()
    {
        // 
        var arrayInteiros = new[] { 3, 7, 4, 2, 1 };
        var elemento = arrayInteiros[0];
        Console.WriteLine($"{elemento}");

        // 
        var nomes = new[] { "Janeiro", "Fevereiro" };
        var elementoString = nomes[0];
        Console.WriteLine($"{elementoString}");

        //
        var arrayVazio = new int[4];
        arrayVazio[0] = 1;
        arrayVazio[3] = 10;
        var elementoInt = arrayVazio[2];
        Console.WriteLine($"{elementoInt}");

        // dddd
        for (var contador = 0; contador < arrayInteiros.Length; contador++)
            Console.WriteLine($"Índice {contador}  -  Valor:{arrayInteiros[contador]}");
    }

    public static void SubCap02()
    {
        // For Each / "equivalente" do  enumerate do python 
        var arrayInteiros = new[] { 3, 7, 4, 2, 1 };
        foreach (var valor in arrayInteiros) Console.WriteLine($"Índice {valor}");
    }

    /// <summary>
    ///     Cópia de array
    /// </summary>
    public static void SubCap03()
    {
        // Redimensionando o tamanho do array. Dobrando a capacidade!
        // Internamente, é criada uma cópia do array
        var arrayInteiros = new[] { 3, 7, 4, 2, 1 };
        Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


        // Copiando valores antidos
        var arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
        Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);
        foreach (var valor in arrayInteirosDobrado) Console.WriteLine($"Índice {valor}");
    }

    /// <summary>
    ///     Representa o trabalho com listas!
    /// </summary>
    public static void SubCap04()
    {
        Console.WriteLine("Listas!!!!");
        var listaString = new List<string>();
        listaString.Add("SP");
        listaString.Add("BA");
        listaString.Add("MG");
        listaString.Add("AM");

        for (var contador = 0; contador < listaString.Count; contador++)
            Console.WriteLine($"Posição Número {contador}: valor {listaString[contador]}");

        Console.WriteLine($"Comprimento da {listaString.Count}");
        Console.WriteLine($"Comprimento da {listaString.Capacity}");
    }
}