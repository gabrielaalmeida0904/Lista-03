using System;

class Program
{
    static void Main()
    {
        string sexo = PedeSexo();

        // Mostra o sexo que foi inserido
        Console.WriteLine($"Sexo informado: {sexo}");
    }

    static string PedeSexo()
    {
        string sexo;

        while (true)
        {
            Console.Write("Qual seu sexo? (Digite 'F' para feminino ou 'M' para masculino): ");
            sexo = Console.ReadLine().Trim().ToUpper();

            if (sexo == "F" || sexo == "M")
            {
                return sexo;
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, escolha 'F' para feminino ou 'M' para masculino.");
            }
        }
    }
}