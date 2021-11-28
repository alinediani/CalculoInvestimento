using System;

namespace CalculoInvestimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de investimentos");
            Console.WriteLine("A porcentagem de juros é por ano ou mês?");
            string anoOuMes = Console.ReadLine();
            Console.WriteLine("Digite o rendimento do seu investimento:");
            double rendimento = double.Parse(Console.ReadLine());
            if (anoOuMes == "ano")
            {
                rendimento = rendimento / 12;
            }
            double rendimentoporcem = rendimento / 100;
            Console.WriteLine("Digite o valor investido:");
            double valorInvestido = double.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                valorInvestido = valorInvestido + valorInvestido * rendimentoporcem;
                Console.WriteLine("Após " + i + "meses você terá: " + valorInvestido);
            }
        }
    }
}
