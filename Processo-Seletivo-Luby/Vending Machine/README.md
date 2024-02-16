# Vending Machine
## OBJETIVO:
### Desenvolver programa que rode uma **Vending Machine (Máquina de venda de bebidas em lata)** utilizando orientação objetos conforme as regras abaixo.
> - Crie uma interface de usuário simples para execução da máquina. (Utilizando Console por exemplo)
> - A máquina deverá possuir um estoque de produtos com valor e quantidade de cada produto. 
>   A quantidade de produto no estoque da máquina deve ser alterado conforme realização de vendas dos produtos.
> - A máquina deverá ter opção para visualizar estoque e quantidade disponível.
> - A máquina só pode vender produtos com quantidade em estoque disponível.
> - A máquina deverá contabilizar as vendas e mostrar o valor total das vendas realizadas.
> - Uma venda só poderá ser concluída ao inserir o valor total do produto.
> - A máquina deverá contabilizar e solicitar o valor faltante para finalizar a venda, caso haja valor de troco para deverá informar o valor.
> - A máquina não necessita de lógica de contagem de notas, será apenas necessário informar os valores.
> - Caso necessário crie um documento simples com informações de como executar o programa.


---

### Sobre o aplicativo:
A Vending Machine possui uma interface gráfica simples que permite aos usuários comprar bebidas, verificar o estoque disponível e verificar a contabilidade de vendas. Para realizar essas ações, basta digitar o número da opção desejada.

**Executar o Programa**: Execute o programa para iniciar a aplicação da vending machine. Para isso basta baixar o projeto e digitar no console "dotnet run"

**Menu Principal**: Você será apresentado ao menu principal com as seguintes opções:

1 - **COMPRAR**: Para comprar uma bebida, selecione esta opção e siga as instruções para selecionar o produto e a quantidade desejada.

2 - **VERIFICAR ESTOQUE**: Para verificar o estoque disponível na máquina, selecione esta opção.

3 - **CONTABILIDADE**: Para visualizar a contabilidade das vendas realizadas, selecione esta opção.

0 - **SAIR**: Para sair do programa, selecione esta opção.

**Compra de Bebida**:

Escolha a bebida desejada digitando o número correspondente.
Digite a quantidade desejada de itens.
Confirme a compra digitando "S" para sim ou "N" para não.

#### Verificação de Estoque:
Esta opção exibirá o estoque atual da vending machine com o nome do produto, preço e quantidade disponível.

#### Contabilidade de Vendas:
Esta opção exibirá todas as vendas realizadas até o momento, incluindo o produto vendido, o preço total e a quantidade vendida, além do total de vendas.

#### Sair do Programa:
Para sair do programa, selecione a opção "0 - SAIR" no menu principal.
