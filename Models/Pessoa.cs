using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_NET_Developer.Models // "Escopo", é a forma como eu importo as funções.
{
    public class Pessoa // Cria Classe Pessoa
    {   
        // Insere o atributo "Nome" e "Idade"
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string NomeRepresentanteLegal { get; set; } 
        
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
}
