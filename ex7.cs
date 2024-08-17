using System;

class Program
{
    static void Main()
    {
        // Loop para cada número de 1 a 20
        for (int i = 1; i <= 20; i++)
        {
            // Exibindo a tabuada para o número atual
            Console.WriteLine($"Tabuada do {i}:");
            
            // Loop para multiplicar o número atual de 1 a 10
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            
            // Solicita que o usuário pressione uma tecla para continuar
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine(); // Linha em branco para separar as tabuadas
        }
    }
}