using API.Context;
using API.Entities;
using Microsoft.AspNetCore.Mvc;


namespace MyAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ContatoController : ControllerBase
{
    private readonly AgendaContext _context;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    public ContatoController(AgendaContext context)
    {
        _context = context;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="contato"></param>
    /// <returns></returns>
    [HttpPost]
    public IActionResult Create(Contato contato)
    {
        _context.Add(contato);
        _context.SaveChanges();
        return CreatedAtAction(nameof(ObterPorId) , new {id=contato.Id}, contato);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public IActionResult ObterPorId(int id)
    {
        var contato = _context.Contatos.Find(id);
        if (contato == null)
            return NotFound();
        return Ok(contato);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="nome"></param>
    /// <returns></returns>
    [HttpGet("ObterPorNome")]
    public IActionResult ObterPorNome(string nome)
    {
        var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));
        return Ok(contatos);
    }

    /// <summary
    /// </summary>
    /// <param name="id"></param>
    /// <param name="contato"></param>
    /// <returns></returns>
    [HttpPut("{id}")]
    public IActionResult Atualizar(int id, Contato contato)
    {
        var contatoBanco = _context.Contatos.Find(id);
        if (contatoBanco == null)
            return NotFound();

        contatoBanco.Nome = contato.Nome;
        contatoBanco.Telefone = contato.Telefone;
        contatoBanco.Ativo = contato.Ativo;
        _context.Contatos.Update(contatoBanco);
        _context.SaveChanges();
        return Ok(contatoBanco);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    public IActionResult Deletar(int id)
    {
        var contatoBanco = _context.Contatos.Find(id);
        if (contatoBanco == null)
            return NotFound();
        _context.Contatos.Remove(contatoBanco);
        _context.SaveChanges();
        return NoContent();
    }
}


