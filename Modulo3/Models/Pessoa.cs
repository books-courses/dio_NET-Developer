

namespace Modulo3.Models;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    // "virtual" serve para permitir que classes filhas, na herança, criem seu proprio método "Apresentar"
    public virtual void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
    }
}




