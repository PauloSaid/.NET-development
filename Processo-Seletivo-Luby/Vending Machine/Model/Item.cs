namespace Desafio.Model;

public class Item
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Estoque { get; set; }

    public Item(string nome, double preco, int estoque)
    {
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }
}