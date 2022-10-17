namespace Modulo3.Models;



// Se eu selar a classe professor (public sealed class Professor : Pessoa)
// Eu fico impedido de herdar de professor!

// Dá pra selar método tb!
public class Diretor : Professor
{
    public Diretor(string nome) : base(nome)
    {
    }
    
    // Polimorfismo!
    // Método Selado! Se, na classe professor, eu defino que (public sealed override void Apresentar())
    // Dai não posso fazer mais o polimorfismo do método "Apresentar"!
    public override void Apresentar()
    {
        Console.WriteLine($"Olá. Sou Diretor!! Meu nome é {Nome} e tenho {Idade} anos");
    }    
}