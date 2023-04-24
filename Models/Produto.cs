namespace Loja.Models;
public class Produto
{
    public int Id { get; set; }
    public string? Nome { get; internal set; }
    public string? Categoria { get; set; }
    public double PrecoUnitario { get; set; }
    public string? Unidade { get; set; }
}