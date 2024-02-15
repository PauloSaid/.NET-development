# Logica de Programação
 1 - 10

---

## Abaixo estão as respostas, como solicitado em cada questão:
• [Questão 01](#questão01)   

• [Questão 02](#questão02)  

• [Questão 03](#questão03) 

• [Questão 04](#questão04)  

• [Questão 05](#questão05) 

• [Questão 06](#questão06)

• [Questão 07](#questão07)

• [Questão 08](#questão08)

• [Questão 09](#questão09)

• [Questão 10](#questão10)

---

## Questão01:
1.1 Implemente a função abaixo para calcular fatorial de um número.
```c#
public int CalcularFatorial(int numero)
    {
        if(numero == 0) // Fatorial de 0 = 1
            return 1;
        return numero * CalcularFatorial(numero - 1); // Chamada recursiva
    }
```
---

## Questão02:
1.2 Implemente a função abaixo que calcula o valor total do prêmio.
```c#
public decimal CalcularPremio(decimal valor, string tipo, decimal? multProprio = null)
    {
        decimal multiplicacao;

        if (multProprio.HasValue && multProprio > 0)
        {
            multiplicacao = multProprio.Value;
        }
        else
        {
            multiplicacao = tipo switch
            {
                "basic" => 1,
                "vip" => 1.2m,
                "premium" => 1.5m,
                "deluxe" => 1.8m,
                "special" => 2,
                _ => throw new ArgumentException("Tipo inválido de prêmio."),
            };
        }

        valor *= multiplicacao;

        if (valor <= 0)
            throw new ArgumentException("Valor do prêmio inválido.");

        return valor;
    }
```

---

## Questão03:
1.3 Implemente a função para contar quantos números primos existe até o número informado.
```c#
public int ContarNumerosPrimos(int numero)
    {
        int totalPrimo = 0;
        bool primo = true;
        for(int i = 2; i < numero; i++) // math.sqrt para otimizar o for
        {
            primo = true;
            for(int j = 2; j <= Math.Sqrt(i); j++)
            {
                if(i % j == 0)
                {
                    primo = false;
                    break;
                }
            }
            if(primo)
                totalPrimo++;
        }
        return totalPrimo;
    }
```
---

## Questão04:
1.4 Implemente a função abaixo que conta e calcula a quantidade de vogais dentro de uma string.
```c#
public int CalcularVogais(string texto)
    {
        int totalVogais = 0;
        foreach (char letter in texto)
        {
            if ("aeiou".Contains(letter))
                totalVogais++;
        }

        return totalVogais;
    }
```

---

## Questão05:
1.5 Implemente a função abaixo que aplica uma porcentagem de desconto a um valor e retorna o resultado.
```c#
public string CalcularValorComDescontoFormatado(string valor, string porcentagem)
    {
        double desconto;
        double valorFormatado;

        try
        {
            valorFormatado = double.Parse(valor.Replace("R$", "").Replace(".", "").Replace(",", "."));
            desconto = double.Parse(porcentagem.Replace("%", "")) / 100;
        }
        catch (FormatException)
        {
            throw new ArgumentException("Valor ou porcentagem inválidos.");
        }

        if (valorFormatado < 0 || desconto < 0)
        {
            throw new ArgumentException("Valor ou porcentagem inválidos.");
        }

        double resultado = valorFormatado - (valorFormatado * desconto);

        return resultado.ToString("C2");
    }
```
---

## Questão06:
1.6 Implemente a função abaixo que obtém duas string de datas e calcula a diferença de dias entre elas.
```c#
public int CalcularDiferencaData(string data1, string data2)
    {
        DateTime data1Formatada = DateTime.ParseExact(data1, "ddMMyyyy", null);
        DateTime data2Formatada = DateTime.ParseExact(data2, "ddMMyyyy", null);
        
        int diferenca;
        if(data1Formatada.DayOfYear > data2Formatada.DayOfYear)
            diferenca = data1Formatada.DayOfYear - data2Formatada.DayOfYear;
        else
            diferenca = data2Formatada.DayOfYear - data1Formatada.DayOfYear;
        
        return diferenca;
    }
```

---

## Questão07:
1.7 Implemente a função abaixo que retorna um novo vetor com todos elementos pares do vetor informado.
```c#
public int[] ObterElementosPares(Array array)
    {
        List<int> newArray = new();
        foreach (int element in array)
        {
            if (element % 2 == 0)
                newArray.Add(element);
        }

        return newArray.ToArray();
    }
```

---

## Questão08:
1.8 Implemente a função abaixo que deve buscar um ou mais elementos no vetor que contém o valor ou parte do valor informado na busca.
```c#
public static string[] BuscarPessoa(Array array, string nome)
    {
        List<string> newArray = new();
        foreach (string pessoa in array)
        {
            if (pessoa.ToLower().Contains(nome.ToLower()))
            {
                newArray.Add(pessoa);
            }
        }
        return newArray.ToArray();
    } 
```

---

## Questão09:
1.9 Implemente a função abaixo que obtém uma string com números separados por vírgula e transforma em um array de array de inteiros com no máximo dois elementos.
```c#
public static int[][] TransformarEmMatriz(string lista) //funcao deve retornar uma matriz para armazenar todos arrays
    {
        string[] numeros = lista.Split(','); // Separa a string de numeros
        List<int[]> matriz = new(); //Lista de arrays

        for (int i = 0; i < numeros.Length; i += 2)
        {
            int[] arrayNumero = new int[2];
            arrayNumero[0] = int.Parse(numeros[i]);
            arrayNumero[1] = i + 1 < numeros.Length ? int.Parse(numeros[i + 1]) : 0;
            // Por partes. Primeiramente, verificamos se i + 1 e menor que o tamanho do array, garantindo que estamos mexendo com um indice valido
            // apos isso, vemos se o proximo valor nao e nulo, se for, atribuimos i + 1 como 0.
            matriz.Add(arrayNumero);
        }

        return matriz.ToArray();
    }
```

---

## Questão10:
1.10 Implemente a função abaixo que compara dois vetores e cria um novo vetor com os elementos faltantes de ambos.
```c#
public int[] ObterElementosFaltantes(int[] array1, int[] array2)
    {
        List<int> lista = new();
        foreach (var element in array1)
        {
            bool encontrado = false;
            foreach (var element2 in array2)
            {
                if (element == element2)
                {
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                lista.Add(element);
            }
        }

        foreach (var element in array2)
        {
            bool encontrado = false;
            foreach (var element1 in array1)
            {
                if (element == element1)
                {
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                lista.Add(element);
            }
        }
        return lista.ToArray();
    }
```




