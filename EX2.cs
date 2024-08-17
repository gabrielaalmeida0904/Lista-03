using System;

class Program
{
    static void Main()
    {
        double primeiro = PedeValorPositivo("Me diga o primeiro valor (tem que ser positivo): ");
        double segundo = PedeValorMaiorQue(primeiro);

        // Mostra os valores válidos que foram inseridos
        Console.WriteLine($"O primeiro valor é: {primeiro}");
        Console.WriteLine($"O segundo valor é: {segundo}");
    }

    static double PedeValorPositivo(string mensagem)
    {
        double valor;

        while (true)
        {
            Console.Write(mensagem);
            if (double.TryParse(Console.ReadLine(), out valor) && valor > 0)
            {
                break;
            }
            Console.WriteLine("Esse valor não está certo. Tente novamente com um valor positivo.");
        }

        return valor;
    }

    static double PedeValorMaiorQue(double primeiroValor)
    {
        double valor;

        while (true)
        {
            Console.Write("Agora, digite o segundo valor (tem que ser maior que o primeiro): ");
            if (double.TryParse(Console.ReadLine(), out valor) && valor > primeiroValor)
            {
                break;
            }
            Console.WriteLine("Esse valor não está certo. O segundo valor precisa ser maior que o primeiro.");
        }

        return valor;
    }
}