namespace Desafio.Menu
{
    using Desafio.Compra;
    using Desafio.Estoque;
    using Desafio.Model;
    using Desafio.Main;
    class Menu
    {
        Compra compra;
        Estoque estoque;
        List<Venda> vendas;


        public Menu(Estoque estoque)
        {
            compra = new Compra();
            this.estoque = estoque;
            vendas = new List<Venda>();
        }
        public void Interface()
        {
            int escolha = -1;

            while (escolha < 0 || escolha > 5)
            {
                Console.Clear();
                Console.WriteLine("🇱‌🇺‌🇧‌🇾‌ 🇲‌🇦‌🇨‌🇭‌🇮‌🇳‌🇪‌ - ʙʏ ᴘᴀᴜʟᴏ sᴀɪᴅ");

                Console.WriteLine("+------------------- M E N U -------------------+");
                Console.WriteLine("|                                                |");
                Console.WriteLine("|                  1 - COMPRAR                   |");
                Console.WriteLine("|                                                |");
                Console.WriteLine("|                  2 - VERIFICAR ESTOQUE         |");
                Console.WriteLine("|                                                |");
                Console.WriteLine("|                  3 - CONTABILIDADE             |");
                Console.WriteLine("|                                                |");
                Console.WriteLine("|                  0 - SAIR                      |");
                Console.WriteLine("|                                                |");
                Console.WriteLine("+------------------------------------------------+");

                Console.Write("Escolha uma opção: ");
                if (!int.TryParse(Console.ReadLine(), out escolha))
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                    Console.ReadKey();
                }

            }
            switch (escolha)
            {
                case 1:
                    MenuCompra(estoque);
                    break;
                case 2:
                    Console.Clear();
                    estoque.MostrarEstoque();
                    Console.WriteLine("Digite qualquer tecla para continuar");
                    Console.ReadKey();
                    Interface();
                    break;
                case 3:
                    Console.Clear();
                    VerVendas();
                    break;
                case 0:
                    Console.Clear();
                    Environment.Exit(0);
                    break;

            }
        }

        public void MenuCompra(Estoque estoque)
        {
            int escolha = -1;
            while (escolha < 0 || escolha > 5)
            {
                Console.Clear();
                Console.WriteLine("+ - - - Escolha sua bebida! - - - +");
                Console.WriteLine("+ - - - 1 - Agua      + R$2,50 - - - +");
                Console.WriteLine("+ - - - 2 - Pepsi     + R$3,00 - - - +");
                Console.WriteLine("+ - - - 3 - Fanta     + R$3,00 - - - +");
                Console.WriteLine("+ - - - 4 - Guarana   + R$4,50 - - - +");
                Console.WriteLine("+ - - - 5 - Guaravita + R$5,00 - - - +");
                Console.WriteLine("+ - - - - - - - - - - - - - - - - +");
                Console.WriteLine();

                Console.Write("Escolha o produto que deseja comprar (ou 0 para voltar): ");
                if (!int.TryParse(Console.ReadLine(), out escolha))
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                    Console.ReadKey();
                }
            }

            if (escolha != 0)
            {
                Console.Write("Quantos itens deseja comprar? ");
                int quantidade = 0;
                while (quantidade <= 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0)
                    {
                        Console.WriteLine("Por favor, digite um número válido maior que zero.");
                    }
                }

                double precoTotal = 0;
                string produto = "";
                switch (escolha)
                {
                    case 1:
                        produto = "Agua";
                        precoTotal = 2.50 * quantidade;
                        break;
                    case 2:
                        produto = "Pepsi";
                        precoTotal = 3.00 * quantidade;
                        break;
                    case 3:
                        produto = "Fanta";
                        precoTotal = 3.00 * quantidade;
                        break;
                    case 4:
                        produto = "Guarana";
                        precoTotal = 4.50 * quantidade;
                        break;
                    case 5:
                        produto = "Guaravita";
                        precoTotal = 5.00 * quantidade;
                        break;
                }

                compra.ConfirmarCompra(estoque, produto, precoTotal, quantidade, this, vendas);
            }
            else
            {
                Interface();
            }
        }

        public void VerVendas()
        {
            Console.Clear();
            Console.WriteLine("+ - - - - - - - - - - - - - - - - - - - - - +");
            Console.WriteLine("|           Vendas Realizadas                |");
            Console.WriteLine("+ - - - - - - - - - - - - - - - - - - - - - +");

            double totalVendas = 0;
            foreach (var venda in vendas)
            {
                Console.WriteLine($"| {venda.Produto.PadRight(10)} | {venda.PrecoTotal.ToString("0.00").PadRight(6)} | {venda.Quantidade.ToString().PadRight(6)} |");
                totalVendas += venda.PrecoTotal;
            }

            Console.WriteLine("+ - - - - - - - - - - - - - - - - - - - - - +");
            Console.WriteLine($"Total de vendas: R${totalVendas.ToString("0.00")}");
            Console.WriteLine("Digite qualquer tecla para continuar.");
            Console.ReadKey();

            Interface();
        }
    }
}
