using System;

class Program
{
    static void Main()
    {
        // Inicializa a variável p1 com um valor inválido (-1) para entrar no loop
        double p1 = -1;

        // Loop para garantir que o usuário insira uma nota válida (positiva)
        while (p1 < 0)
        {
            // Solicita ao usuário para inserir a nota da P1
            Console.Write("Insira a nota da P1 (valor positivo): ");

            // Lê a entrada do usuário e converte para double
            p1 = Convert.ToDouble(Console.ReadLine());

            // Verifica se a nota inserida é válida (positiva)
            if (p1 < 0)
            {
                Console.WriteLine("Nota inválida. Por favor, insira um valor positivo.");
            }
        }

        // Define a média necessária para aprovação
        double mediaAprovacao = 5.0;

        // Calcula a nota necessária na P2 para alcançar a média de aprovação
        double p2Necessaria = (3 * mediaAprovacao - p1) / 2;

        // Exibe a mensagem com a nota necessária na P2 formatada com duas casas decimais
        Console.WriteLine($"Para ser aprovado, é necessário tirar pelo menos {p2Necessaria:F2} na P2.");
    }
}
