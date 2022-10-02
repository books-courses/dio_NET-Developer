//
//
//

using Commons.Model_Pessoa;

namespace dioCourse.Capitulo_03;

public class Cap03
{
    public static void SubCap01()
    {
        // Cria a variável p com objeto "Pessoa"
        // Model_Pessoa.Pessoa p = new Model_Pessoa.Pessoa();
        var p = new Pessoa
        {
            // Atribuí variáveis
            Nome = "Michel",
            Idade = 38
        };

        // Usa o método
        p.Apresentar();

        // Usa o método Aniversário
        p.Aniversario();
    }

    public static void SubCap02()
    {
        // Calculadora
        double valor = 1.50;
        Console.WriteLine(valor);
    }
}
