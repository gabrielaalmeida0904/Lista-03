using System;

class Program
{
    static void Main()
    {
        // Número de elementos da série de Fibonacci que queremos exibir
        int quantidade = 30;
        
        // Verifica se a quantidade é válida para exibir
        if (quantidade <= 0)
        {
            Console.WriteLine("A quantidade deve ser maior que zero.");
            return;
        }

        // Array para armazenar os valores da série de Fibonacci
        long[] fibonacci = new long[quantidade];
        
        // Inicializa os dois primeiros valores da série
        fibonacci[0] = 1;
        if (quantidade > 1)
        {
            fibonacci[1] = 1;
        }

        // Preenche o array com os valores da série de Fibonacci
        for (int i = 2; i < quantidade; i++)
        {
            // Cada valor é a soma dos dois valores anteriores
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        // Exibe os valores da série de Fibonacci
        Console.WriteLine("Os primeiros 30 valores da série de Fibonacci são:");
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write(fibonacci[i] + " ");
        }
    }
}