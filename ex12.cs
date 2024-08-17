using System;
using System.Linq;  

class Program
{
    static void Main()
    {
        while (true)  // Loop para permitir a repetição do programa
        {
            int n;
            int[] valores;

            // Solicita e valida a quantidade de valores
            do
            {
                Console.Write("Digite a quantidade de valores (entre 1 e 19): ");
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n >= 20)
                {
                    Console.WriteLine("Quantidade inválida! Deve ser um número positivo menor que 20.");
                }
            } while (n <= 0 || n >= 20);

            valores = new int[n];

            // Entrada dos valores
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o valor {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out valores[i]))
                {
                    Console.WriteLine("Valor inválido! Por favor, digite um número inteiro.");
                    Console.Write($"Digite o valor {i + 1}: ");
                }
            }

            // Calcula o maior, menor, soma, média, e porcentagens
            int maior = valores.Max();
            int menor = valores.Min();
            int soma = valores.Sum();
            double media = valores.Average();
            double percentPositivos = valores.Count(v => v > 0) / (double)n * 100;
            double percentNegativos = valores.Count(v => v < 0) / (double)n * 100;

            // Exibe os resultados
            Console.WriteLine($"\nMaior valor: {maior}");
            Console.WriteLine($"Menor valor: {menor}");
            Console.WriteLine($"Soma dos valores: {soma}");
            Console.WriteLine($"Média aritmética: {media:F2}");
            Console.WriteLine($"Porcentagem de valores positivos: {percentPositivos:F2}%");
            Console.WriteLine($"Porcentagem de valores negativos: {percentNegativos:F2}%");

            // Pergunta se o usuário quer repetir o programa
            Console.Write("\nDeseja fazer uma nova execução? (S/N): ");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta != "S")
            {
                break;  // Encerra o loop e o programa se a resposta não for 'S'
            }
        }
    }
}