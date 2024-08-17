using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            int numero = 0;
            bool entradaValida = false;

            // Pede o número para o usuário
            while (!entradaValida)
            {
                Console.Write("Digite um número não negativo para calcular o fatorial: ");
                string input = Console.ReadLine();

                // Verifica se a entrada é um número e não é negativa
                if (int.TryParse(input, out numero) && numero >= 0)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Por favor, digite um número não negativo.");
                }
            }

            // Calcula o fatorial
            long resultado = CalcularFatorial(numero);
            Console.WriteLine($"O fatorial de {numero} é {resultado}.");

            // Pergunta se quer fazer outro cálculo
            Console.Write("Quer calcular o fatorial de outro número? (S/N): ");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta != "S")
            {
                continuar = false;
            }
        }
    }

    static long CalcularFatorial(int n)
    {
        if (n == 0) return 1;
        long resultado = 1;
        for (int i = 1; i <= n; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
}