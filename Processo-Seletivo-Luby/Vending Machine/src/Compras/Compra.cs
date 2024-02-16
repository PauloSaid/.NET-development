namespace Desafio.Compra
{
    using Desafio.Estoque;
    using Desafio.Menu;
    using Desafio.Model;


    class Compra
    {
        double pagamento;
        double troco;
        public void ConfirmarCompra(Estoque estoque, string produto, double preco, int quantidade, Menu menu, List<Venda> vendas)
        {
            string sair = "";

            do
            {
                Console.Clear();
                Console.WriteLine("Você selecionou: " + produto);
                Console.WriteLine("Preço: R$" + preco.ToString("0.00"));
                Console.WriteLine("Informe o valor do pagamento: (0.00)");
                pagamento = double.Parse(Console.ReadLine());
                if (pagamento >= preco)
                {
                    troco = pagamento - preco;
                    Console.WriteLine("Troco: " + troco);
                }
                else
                {
                    Console.WriteLine("Valor insuficiente para concluir a compra. Faltam R$ " + (preco - pagamento));
                    Console.WriteLine("Gostaria de cancelar a compra? (S/N)");
                    sair = Console.ReadLine().ToUpper();

                }
            } while (pagamento < preco || sair == "S");

            if(sair == "S")
            {
                menu.MenuCompra(estoque);
            }

            Console.Write("Confirmar compra? (S/N): ");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "S")
            {
                if (estoque.VerificarQtdEstoque(produto, quantidade))
                {
                    vendas.Add(new Venda { Produto = produto, PrecoTotal = preco, Quantidade = quantidade });
                }
                Console.ReadKey();
                Console.WriteLine("Digite qualquer tecla para continuar.");
                menu.Interface();
            }
            else
            {
                menu.Interface();
            }
        }
    }
}
