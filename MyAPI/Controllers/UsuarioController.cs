using Microsoft.AspNetCore.Mvc;


namespace MyAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet("ObterDataHoraAtual")]
    public IActionResult ObterDataHora()
    {
        var obj = new
        {
            Data = DateTime.Now.ToLongDateString(),
            Hora = DateTime.Now.ToShortTimeString(),
            Nome = "Um texto qualquer!",
        };
        return Ok(obj);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="nome"></param>
    /// <returns></returns>
    [HttpGet("Apresentar/{nome}")]
    public IActionResult Apresentar(string nome)
    {
        var mensagem = $"Olá {nome} seja bem vindo";
        return Ok(new { mensagem });
    }
}