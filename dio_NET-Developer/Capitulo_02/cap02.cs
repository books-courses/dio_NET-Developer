// dddd
// dddd
// dddd



namespace dio_NET_Developer.Capitulo_02;

public class Cap02
{
    public static void SubCap01()
    {
        // Operador Condicional
        int quantidadeEmEstoque = 4;
        int quandidadeCompra = 5;
        if (quantidadeEmEstoque >= quandidadeCompra)
        {
            Console.WriteLine("Venda Realizada");
        }
        else
        {
            Console.WriteLine("Desculpe. Não temos tudo isso");
        }


        bool c1 = true;
        bool c2 = false;
        bool c3 = false;
        if (c1 && c2) // And
        {
            Console.WriteLine("ssss");
        }
        else if (c2 && c3) // And
        {
            Console.WriteLine("ss34343434ss");
        }
        else if (c2 || c3) // Or
        {
            Console.WriteLine("ss34343434ss");
        }
        else if (!c2 || !c3)
        {
            Console.WriteLine("Negação tem o ponto de eclamação antes");
        }
        else
        {
            Console.WriteLine("ss343434dsdsdsd34ss");
        }
    }
    

    public static void SubCap02()
    {
        // Cria a variável p com objeto "Pessoa"
        Console.WriteLine("Digite uma letra");
        string d2 = "a";
        //string d2 = Console.ReadLine();
        Console.WriteLine(d2);

        switch (d2)
        {
            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
                Console.WriteLine("Vogal");
                break;

            default:
                Console.WriteLine("Não é Vogal");
                break;
        }
    }
}
