using Microsoft.EntityFrameworkCore;
using MyMVC.Models;


namespace MyMVC.Context;

public class AgendaContext: DbContext
{
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
    {
        
    }
    public DbSet<Contato> Contatos { get; set; }
}
