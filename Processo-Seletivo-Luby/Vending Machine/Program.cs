namespace Desafio.Main;

using Desafio.Estoque;
using Desafio.Menu;

class VendingMachine
{
    private static void Main()
    {
        Estoque estoque = new Estoque();
            Menu menu = new Menu(estoque);

            menu.Interface();
    }
}