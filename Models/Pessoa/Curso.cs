// 
//

namespace Models.Pessoa;

public class Curso
{
    /// <summary>
    /// Propriedade: Nome do Curso
    /// </summary>
    public string Nome { get; set; }
    
    
    /// <summary>
    /// Propriedade: Lista de Alunos
    /// </summary>
    public List<Pessoa> Alunos { get; set; }

    
    /// <summary>
    /// Adicionar alunos em um curso. VOID não precisa de retorno!
    /// </summary>
    /// <param name="aluno"></param>
    public void AdicionarAlunos(Pessoa aluno)
    {
        Alunos.Add(aluno);
    }

    
    /// <summary>
    /// Remove um aluno da Lista de Alunos do Curso
    /// </summary>
    /// <param name="aluno"></param>
    /// <returns></returns>
    public bool RemoverAlunos(Pessoa aluno)
    {
        Alunos.Remove(aluno);
        Console.WriteLine($"Aluno {aluno.NomeCompleto} removido");
        return true;
    }

    
    /// <summary>
    /// Lista dos Alunos matrículados no Curso 
    /// </summary>
    public void ListarAlunos()
    {
        Console.WriteLine($"Alunos do Curso {Nome}:");
        for (int count = 0; count < Alunos.Count; count++)
        {
            var texto = $"Nº {count + 1} {Alunos[count].NomeCompleto}";
            Console.WriteLine(texto);
        }
    }


    /// <summary>
    /// Pega um número! Como o método retorna valor, é preciso usar um "return"
    /// </summary>
    /// <returns></returns>
    public int ObterQuantidadeDeAlunosMatriculados()
    {
        int quantidade = Alunos.Count;
        return quantidade;
    }
}