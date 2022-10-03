
namespace Models.Pessoa;

public class Curso
{
    public string Nome { get; set; }
    public List<Pessoa> Alunos { get; set; }

    /// <summary>
    /// Adicionar alunos em um curso. VOID não precisa de retorno!
    /// </summary>
    /// <param name="aluno"></param>
    public void AdicionarAlunos(Pessoa aluno)
    {
        Alunos.Add(aluno);
    }

    public bool RemoverAlunos(Pessoa aluno)
    {
        Alunos.Remove(aluno);
        return true;
    }

   public void ListarAlunos(){
    foreach(Pessoa aluno in Alunos)
    {
        Console.WriteLine($"Aluno {aluno.NomeCompleto}");
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