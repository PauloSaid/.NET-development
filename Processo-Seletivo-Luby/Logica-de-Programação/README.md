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


---

## Questão08:


---

## Questão09:


---

## Questão10:


