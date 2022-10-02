// "Escopo", é a forma como eu importo as funções.


namespace Commons.Model_Pessoa;

public class Pessoa // Cria Classe Pessoa
{
    // Insere o atributo "Nome" e "Idade"
    public string Nome { get; set; } = string.Empty;
    public int Idade { get; set; }
    public string NomeRepresentanteLegal { get; set; } = string.Empty;

    // Insere um método/função
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}. Tenho {Idade} anos.");
    }

    /// <summary>
    /// Faz a pessoa se apresentar
    /// </summary>
    public void Aniversario()
    {
        var idadeNova = Idade + 1;
        Console.WriteLine($"{Nome} tinha {Idade} anos\nagora tem {idadeNova} anos");
        Idade = idadeNova;
    }
}