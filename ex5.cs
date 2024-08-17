using System;

class Program
{
    static void Main()
    {
        double valor = PedeValorPositivo();

        // Mostra a tabuada do valor que o usuário digitou
        MostraTabuada(valor);
    }

    static double PedeValorPositivo()
    {
        double valor;

        while (true)
        {
            Console.Write("Me diga um valor positivo: ");
            if (double.TryParse(Console.ReadLine(), out valor) && valor > 0)
            {
                return valor;
            }
            else
            {
                Console.WriteLine("Esse valor não está certo. Tente novamente com um valor positivo.");
            }
        }
    }

    static void MostraTabuada(double valor)
    {
        Console.WriteLine($"Tabuada de {valor}:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{valor} x {i} = {valor * i}");
        }
    }
}