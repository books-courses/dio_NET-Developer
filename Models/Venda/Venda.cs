using Newtonsoft.Json;


namespace Models.Venda;

public class Venda
{
    /// <summary>
    /// dddd
    /// </summary>
    /// <param name="id"></param>
    /// <param name="produto"></param>
    /// <param name="preco"></param>
    /// <param name="dataVenda"></param>
    public Venda(int id, string produto, decimal preco, DateTime dataVenda)
    {
        Id = id;
        Produto = produto;
        Preco = preco;
        DataVenda = dataVenda;
    }
    
    public int Id { get; set; }
    
    // Eventualmente o arquivo pode conter outra chave, dai é necessário usar atributo
    [JsonProperty("Nome_Produto")]
    public string Produto { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataVenda { get; set; }
    // Aceita nullable
    public decimal? Desconto { get; set; }
}

