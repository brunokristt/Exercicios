using System;
using System.Globalization;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Gerenciamento do Valor dos produtos");
            Console.Write("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de peças: ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor unitário de cada peça: ");
            double valorPeca = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double CalculaValor(double quantidade, double valor)
            {
                double resultado = quantidade * valor;
                return resultado;

            }

            double valorTotal = CalculaValor(quantidade, valorPeca);
            Console.Write("Código: " + codigo);
            Console.Write(" Valor Unitário: " + valorPeca);
            Console.Write(" Valor total: " + valorTotal, ("F2") );

           

        }
    }
}
