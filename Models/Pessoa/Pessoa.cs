// "Escopo", é a forma como eu importo as funções.


namespace Models.Pessoa;

public class Pessoa // Cria Classe Pessoa
{
    /// <summary>
    ///     Insere atributos/propriedades "Nome" e "Idade"
    /// </summary>
    public string Nome { get; set; } = string.Empty;

    public string NomeRepresentanteLegal { get; set; } = string.Empty;
    public int Idade { get; set; }


    /// <summary>
    ///     Insere um método/função
    /// </summary>
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}. Tenho {Idade} anos.");
    }


    /// <summary>
    ///     Faz a pessoa se apresentar
    /// </summary>
    public void Aniversario()
    {
        var idadeNova = Idade + 1;
        Console.WriteLine($"{Nome} tinha {Idade} anos\nagora tem {idadeNova} anos");
        Idade = idadeNova;
    }
}