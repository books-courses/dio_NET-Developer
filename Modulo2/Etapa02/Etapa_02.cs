// Etapa 2: Manipulando Valores 

using System.Globalization;


namespace Modulo2.Etapa02;

public class Etapa_02
{
    /// <summary>
    /// Frmataçã de valores Financeiros, Porcentagens etc
    /// </summary>
    public static void SubCap01()
    {
        // CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
        var valorMonetario = 13282.40M;
        Console.WriteLine($"{valorMonetario}");
        Console.WriteLine($"{valorMonetario:C}");
        Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("es-ES")));
        Console.WriteLine(valorMonetario.ToString("C1")); // Uma Casa Decimal para Currency
        Console.WriteLine(valorMonetario.ToString("C7")); // Sete Casa Decimal para Currency
        Console.WriteLine(valorMonetario.ToString("N7")); // Sete Casa Decimal
    }

    /// <summary>
    /// Porcentagem
    /// </summary>
    public static void SubCap02()
    {
        var valorPorcentagem = 0.3452;
        Console.WriteLine($"{valorPorcentagem}");
        Console.WriteLine($"{valorPorcentagem:P}");


        var valorInteiro = 1242242;
        Console.WriteLine(valorInteiro.ToString("##-##"));
    }


    /// <summary>
    /// Datetime Pega um datetime e converte para strings variadas
    /// </summary>
    public static void SubCap03()
    {
        var data = DateTime.Now;
        Console.WriteLine($"{data}");
        Console.WriteLine($"{data.Year}");
        Console.WriteLine($"{data.Kind}");
        Console.WriteLine(data.ToString("dd.MM.yyyy HH:mm"));

        Console.WriteLine($"{data.ToShortDateString()}");
        Console.WriteLine($"{data.ToShortTimeString()}");
    }

    /// <summary>
    /// Datetime Pega um string e converte para datetime
    /// </summary>
    public static void SubCap04()
    {
        var texto = "17/04/2022 18:00";
        var data = DateTime.Parse(texto);
        Console.WriteLine($"{data}");
        Console.WriteLine($"{data.Year}");
        Console.WriteLine($"{data.Kind}");
        Console.WriteLine(data.ToString("dd.MM.yyyy HH:mm"));
        Console.WriteLine($"{data.ToShortDateString()}");
        Console.WriteLine($"{data.ToShortTimeString()}");

        var textoErrado = "2022.04.17 18:00";
        var sucesso = DateTime.TryParseExact(
            textoErrado,
            "yyyy.MM.dd HH:mm",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out var data2);

        if (sucesso)
        {
            Console.WriteLine($"Conversão com sucesso: {data2}");
        }
        else
        {
            Console.WriteLine($"Conversão zuada");
        }
    }
}