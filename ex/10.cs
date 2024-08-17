using System;

class Program
{
    static void Main()
    {
        // Crio um array para armazenar os 10 valores positivos que o usuário vai digitar
        int[] valores = new int[10];
        
        // Variáveis para acompanhar o maior valor, a soma dos valores e para somar os valores válidos
        int maiorValor = int.MinValue;
        int soma = 0;
        
        // Solicito ao usuário que digite 10 valores positivos
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o valor positivo {i + 1}: ");
            string input = Console.ReadLine();
            
            // Tenta converter o texto digitado para um número inteiro
            bool sucesso = int.TryParse(input, out int valor);
            
            // Verifico se a conversão foi bem-sucedida e se o valor é positivo
            if (sucesso && valor > 0)
            {
                // Se tudo estiver certo, guardo o valor no array
                valores[i] = valor;
                
                // Adiciono o valor à soma total
                soma += valor;
                
                // Atualizo o maior valor se o valor atual for maior
                if (valor > maiorValor)
                {
                    maiorValor = valor;
                }
            }
            else
            {
                // Se algo deu errado, aviso o usuário e permito uma nova tentativa
                Console.WriteLine("Erro: Por favor, digite um valor positivo válido.");
                i--; // Volto uma posição no loop para que o usuário possa tentar novamente
            }
        }
        
        // Calculo a média dos valores
        double media = (double)soma / valores.Length;
        
        // Exibo o maior valor, a soma e a média
        Console.WriteLine($"O maior valor digitado é: {maiorValor}");
        Console.WriteLine($"A soma dos valores é: {soma}");
        Console.WriteLine($"A média aritmética dos valores é: {media:F2}"); // :F2 formata a média com 2 casas decimais
    }
}