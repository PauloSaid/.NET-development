namespace Desafio.Estoque;

using Desafio.Menu;
using Desafio.Model;

class Estoque
{
    public List<Item> itens;

    public Estoque()
    {
        itens = new List<Item>();
        AdicionarEstoque();
    }

    public void AdicionarEstoque()
    {
        itens.Add(new Item("Agua", 2.50, 10));
        itens.Add(new Item("Pepsi", 3.00, 15));
        itens.Add(new Item("Fanta", 3.00, 12));
        itens.Add(new Item("Guarana", 4.50, 8));
        itens.Add(new Item("Guaravita", 5.00, 5));
    }

    public void MostrarEstoque()
    {
        Console.Clear();
        Console.WriteLine("+ - - - - - - - - - - - - - - - - - - - - - +");
        Console.WriteLine("|             Estoque da Loja               |");
        Console.WriteLine("+ - - - - - - - - - - - - - - - - - - - - - +");
        foreach (var item in itens)
        { 
            Console.WriteLine($"| {item.Nome.PadRight(10)} | R${item.Preco.ToString("0.00").PadRight(6)} | {item.Estoque.ToString().PadRight(6)} |");
        } 
        Console.WriteLine("+ - - - - - - - - - - - - - - - - - - - - - +");
    }

    public bool VerificarQtdEstoque(string produto, int quantidade)
    {
        var item = itens.Find(x => x.Nome.Equals(produto, StringComparison.OrdinalIgnoreCase));

        if(item != null)
        {
            if(quantidade > item.Estoque)
            {
                Console.Clear();
                Console.WriteLine("Erro. Estoque insuficiente.");
                Console.WriteLine("Digite qualquer tecla para continuar.");
                Console.ReadKey();
                return false;
            } else if(quantidade <= item.Estoque)
            {
                item.Estoque -= quantidade;
                Console.WriteLine("Compra realizada com sucesso!");
                Console.WriteLine("Digite qualquer tecla para continuar");
                return true;

            } else
            {
                Console.Clear();
                Console.WriteLine("Erro. Item nao encontrado.");
                Console.WriteLine("Digite qualquer tecla para continuar.");
                Console.ReadKey();
                return false;
            }
        }
            return false;
    }
}
