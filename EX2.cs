using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário para entrar com o primeiro valor positivo
        Console.Write("Digite o primeiro valor (deve ser positivo): ");
        double primeiroValor = ObterValorPositivo();

        // Solicita ao usuário para entrar com o segundo valor maior que o primeiro
        Console.Write("Digite o segundo valor (deve ser maior que o primeiro): ");
        double segundoValor = ObterSegundoValor(primeiroValor);

        // Exibe os valores válidos inseridos
        Console.WriteLine($"Primeiro valor: {primeiroValor}");
        Console.WriteLine($"Segundo valor: {segundoValor}");
    }

    // Função para obter um valor positivo digitado pelo usuário
    static double ObterValorPositivo()
    {
        double valor;
        do
        {
            // Lê a entrada do usuário e tenta converter para double
            string input = Console.ReadLine();
            bool conversaoSucesso = double.TryParse(input, out valor);

            // Verifica se a conversão foi bem-sucedida e se o valor é positivo
            if (!conversaoSucesso || valor <= 0)
            {
                Console.WriteLine("Valor inválido. Por favor, digite um valor positivo.");
                Console.Write("Digite novamente: ");
            }
        } while (valor <= 0);

        return valor;
    }

    // Função para obter o segundo valor maior que o primeiro digitado pelo usuário
    static double ObterSegundoValor(double primeiroValor)
    {
        double segundoValor;
        do
        {
            // Lê a entrada do usuário e tenta converter para double
            string input = Console.ReadLine();
            bool conversaoSucesso = double.TryParse(input, out segundoValor);

            // Verifica se a conversão foi bem-sucedida e se o segundo valor é maior que o primeiro
            if (!conversaoSucesso || segundoValor <= primeiroValor)
            {
                Console.WriteLine("Valor inválido. O segundo valor deve ser maior que o primeiro.");
                Console.Write("Digite novamente: ");
            }
        } while (segundoValor <= primeiroValor);

        return segundoValor;
    }
}
