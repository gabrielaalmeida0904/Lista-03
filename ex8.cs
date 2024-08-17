using System;

class Program
{
    static void Main()
    {
        // Inicializa a variável para armazenar a soma
        int soma = 0;
        
        // Laço que percorre todos os números de 1 a 100
        for (int i = 1; i <= 100; i++)
        {
            // Adiciona o número atual à soma
            soma += i;
        }
        
        // Exibe a soma final
        Console.WriteLine("A soma dos números de 1 a 100 é: " + soma);
    }
}