using System;

class Program
{
    static void Main()
    {
        string sexo;

        // Loop para garantir que o usuário insira um sexo válido ("F" ou "M")
        while (true)
        {
            // Solicita ao usuário para inserir o sexo
            Console.Write("Digite o sexo (F para feminino, M para masculino): ");

            // Lê a entrada do usuário e converte para maiúsculo para facilitar a comparação
            sexo = Console.ReadLine().ToUpper();

            // Verifica se o sexo inserido é válido
            if (sexo == "F" || sexo == "M")
            {
                // Se for válido, sai do loop
                break;
            }
            else
            {
                // Se não for válido, exibe mensagem de erro e continua no loop
                Console.WriteLine("Entrada inválida. Por favor, digite 'F' para feminino ou 'M' para masculino.");
            }
        }

        // Exibe o sexo válido inserido
        Console.WriteLine($"Sexo inserido: {sexo}");
    }
}
