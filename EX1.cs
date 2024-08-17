using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aplicacao
{
    static void Main()
    {
        double nota1 = -1;

        // Solicita ao usuário que informe a nota da primeira prova e garante que seja um valor positivo
        while (nota1 < 0)
        {
            Console.Write("Por gentileza, informe a nota da primeira prova (apenas valores positivos): ");
            if (!double.TryParse(Console.ReadLine(), out nota1) || nota1 < 0)
            {
                Console.WriteLine("Valor inválido. Por favor, insira um número positivo.");
            }
        }

        // Define a média mínima exigida para aprovação
        double mediaMinima = 5.0;

        // Calcula qual será a nota necessária na segunda prova para atingir a média mínima
        double nota2Necessaria = (3 * mediaMinima - nota1) / 2;

        // Informa ao usuário qual é a nota mínima que ele precisa obter na segunda prova para ser aprovado
        Console.WriteLine($"Para ser aprovado, será necessário obter pelo menos {nota2Necessaria:F2} na segunda prova.");
    }
}