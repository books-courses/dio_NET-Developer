namespace Modulo3.Models;

// Aluno Herdando de Pessoa
public class Aluno : Pessoa
{
    /// <summary>
    /// Construtor Vazio!
    /// </summary>
    public Aluno()
    {
        
    }
    
    // Como o construtor de Pessoa requer nome!, é necessário passar 
    // nome para o objeto pessoa!
    // Construtor por Herança!
    public Aluno(string nome) : base(nome)
    {
        
    }
    
    public decimal Nota { get; set; }


    public void FalarNota()
    {
        Console.WriteLine($"Minha nota é {Nota}");
    }
    public override void Apresentar()
    {
        Console.WriteLine($"Olá. Sou Aluno! Meu nome é {Nome} e tenho {Idade} anos");
    }
}