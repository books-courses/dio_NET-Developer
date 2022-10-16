// "Escopo", é a forma como eu importo as funções.


using System.Runtime.CompilerServices;

namespace Models.Pessoa;

/// <summary>
/// Cria Classe Pessoa
/// </summary>
public class Pessoa
{
    // Primeiro Construtor: possibilita instanciar objeto, sem valores 
    public Pessoa()
    {
    }

    // Segundo Construtor, precisa entrar com os dados!
    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public void Deconstruct(out string nome, out string sobrenome)
    {
        nome = Nome;
        sobrenome = Sobrenome;
    }
    


    /// <summary>
    ///     Insere atributos/propriedades "Nome" e "Idade"
    /// </summary>
    private string _nome;

    private int _idade;

    public string Nome
    {
        // Usando "Body Expressions" no Get
        get => _nome.ToUpper();

        //
        set
        {
            // O value é o valor da variável
            if (value == "")
            {
                throw new ArgumentException("O nome não pode ser vazio!");
            }

            _nome = value;
        }
    }

    /// <summary>
    /// Idade da Pessoa
    /// </summary>
    /// <exception cref="ArgumentException"></exception>
    public int Idade
    {
        get => _idade;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("A idade não pode ser menor que zero!");
            }

            _idade = value;
        }
    }

    public string NomeRepresentanteLegal { get; set; } = string.Empty;
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();


    /// <summary>
    ///     Insere um método/função
    /// </summary>
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {NomeCompleto}. Tenho {Idade} anos.");
    }


    /// <summary>
    ///     Faz a pessoa se apresentar
    /// </summary>
    public void Aniversario()
    {
        var idadeNova = _idade + 1;
        Console.WriteLine($"{NomeCompleto} tinha {_idade} anos. Agora tem {idadeNova} anos!");
        _idade = idadeNova;
    }
}