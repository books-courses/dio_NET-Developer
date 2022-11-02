using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Context;

/// <summary>
/// Estamos herando o DbContext
/// https://www.youtube.com/watch?v=_jdsAOGiiC8
/// </summary>
public class AgendaContext : DbContext
{
    /// <summary>
    /// Pega configuração e passa para a classe pai.
    /// </summary>
    /// <param name="options"></param>
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
    {
    }

    /// <summary>
    /// Uma classe no programa que vincula a uma tabela no banco de dados.
    /// </summary>
    public DbSet<Contato> Contatos { get; set; }
}