using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// "Escopo", é a forma como eu importo as funções.
namespace dio_NET_Developer.Model_Pessoa; 

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

    public void Aniversario()
    {
        int IdadeNova = Idade + 1;
        Console.WriteLine($"{Nome} tinha {Idade} anos\nagora tem {IdadeNova} anos");
        Idade = IdadeNova;
    }
}



