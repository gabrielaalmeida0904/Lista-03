using System;

class Program
{
    static void Main()
    {
        int N;

        // Solicita ao usuário que digite um valor N que será a quantidade de números
        // N deve ser positivo e menor que 20
        do
        {
            Console.Write("Digite a quantidade de valores (positivo e menor que 20): ");
            string input = Console.ReadLine();
            bool sucesso = int.TryParse(input, out N);

            // Verifica se a conversão foi bem-sucedida e se N está dentro do intervalo permitido
            if (!sucesso || N <= 0 || N >= 20)
            {
                Console.WriteLine("Erro: O valor deve ser positivo e menor que 20.");
            }
        } while (N <= 0 || N >= 20);

        // Cria um array para armazenar os valores digitados
        int[] valores = new int[N];

        // Variáveis para calcular maior valor, menor valor, soma, e contadores
        int maiorValor = int.MinValue;
        int menorValor = int.MaxValue;
        int soma = 0;
        int positivos = 0;
        int negativos = 0;

        // Solicita ao usuário que digite os N valores
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o valor {i + 1}: ");
            string input = Console.ReadLine();
            bool sucesso = int.TryParse(input, out int valor);

            // Verifica se a conversão foi bem-sucedida
            if (sucesso)
            {
                // Armazena o valor no array
                valores[i] = valor;

                // Atualiza a soma dos valores
                soma += valor;

                // Verifica e atualiza o maior e menor valor
                if (valor > maiorValor)
                {
                    maiorValor = valor;
                }
                if (valor < menorValor)
                {
                    menorValor = valor;
                }

                // Conta quantos valores são positivos e negativos
                if (valor > 0)
                {
                    positivos++;
                }
                else if (valor < 0)
                {
                    negativos++;
                }
            }
            else
            {
                // Se o valor não for válido, exibe uma mensagem de erro
                Console.WriteLine("Erro: Por favor, digite um número válido.");
                i--; // Decrementa o índice para permitir nova tentativa
            }
        }

        // Calcula a média dos valores
        double media = (double)soma / N;

        // Calcula as porcentagens de valores positivos e negativos
        double porcentagemPositivos = (double)positivos / N * 100;
        double porcentagemNegativos = (double)negativos / N * 100;

        // Exibe o maior valor, o menor valor, a soma, a média, e as porcentagens
        Console.WriteLine($"O maior valor digitado é: {maiorValor}");
        Console.WriteLine($"O menor valor digitado é: {menorValor}");
        Console.WriteLine($"A soma dos valores é: {soma}");
        Console.WriteLine($"A média aritmética dos valores é: {media:F2}"); // :F2 formata a média com 2 casas decimais
        Console.WriteLine($"A porcentagem de valores positivos é: {porcentagemPositivos:F2}%");
        Console.WriteLine($"A porcentagem de valores negativos é: {porcentagemNegativos:F2}%");
    }
}