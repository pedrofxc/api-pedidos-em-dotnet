namespace ApiPedidos.Models;

public class Pedido
{
    public int Id { get; set; }

    public string Cliente { get; set; } = string.Empty;

    public decimal ValorTotal { get; set; }

    public string Status { get; set; } = "Aberto";

    public DateTime DataCriacao { get; set; } = DateTime.Now;
}
