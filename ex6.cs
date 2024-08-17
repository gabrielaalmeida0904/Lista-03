using System;

class Program
{
    static void Main()
    {
        // Solicita um valor positivo para a tabuada
        double valor = ObterValorPositivo("Digite um valor positivo para a tabuada: ");

        // Solicita o intervalo
        (int intervaloInicio, int intervaloFim) = ObterIntervalo();

        // Exibe a tabuada no intervalo decrescente
        ExibirTabuadaDecrescente(valor, intervaloInicio, intervaloFim);
    }

    static double ObterValorPositivo(string mensagem)
    {
        double valor;

        while (true)
        {
            Console.Write(mensagem);
            if (double.TryParse(Console.ReadLine(), out valor) && valor > 0)
            {
                return valor;
            }
            else
            {
                Console.WriteLine("Valor inválido. Por favor, digite um valor positivo.");
            }
        }
    }

    static (int, int) ObterIntervalo()
    {
        int inicio, fim;

        // Solicita o intervalo com validação
        while (true)
        {
            Console.Write("Digite o início do intervalo (A): ");
            if (int.TryParse(Console.ReadLine(), out inicio))
            {
                break;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }
        }

        while (true)
        {
            Console.Write("Digite o fim do intervalo (B): ");
            if (int.TryParse(Console.ReadLine(), out fim) && fim > inicio)
            {
                return (inicio, fim);
            }
            else
            {
                Console.WriteLine("Valor inválido. O fim do intervalo deve ser maior que o início.");
            }
        }
    }

    static void ExibirTabuadaDecrescente(double valor, int inicio, int fim)
    {
        Console.WriteLine($"Tabuada de {valor} no intervalo de {fim} a {inicio}:");

        for (int i = fim; i >= inicio; i--)
        {
            Console.WriteLine($"{valor} x {i} = {valor * i}");
        }
    }
}