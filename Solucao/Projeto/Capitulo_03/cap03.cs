namespace Projeto.Capitulo_03;

public class Cap03
{
    public static void SubCap01()
    {
        // Cria a variável p com objeto "Pessoa"
        Pessoa.Pessoa p = new Pessoa.Pessoa();

        // Atribuí variáveis
        p.Nome = "Michel";
        p.Idade = 38;

        // Usa o método
        p.Apresentar();

        // Usa o método Aniversário
        p.Aniversario();
    }
}