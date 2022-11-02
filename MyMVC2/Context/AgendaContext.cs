using Microsoft.EntityFrameworkCore;
using MyMVC2.Models;

namespace MyMVC2.Context;


public class AgendaContext: DbContext
{
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
    {
        
    }
    public DbSet<Contato> Contatos { get; set; }
}
