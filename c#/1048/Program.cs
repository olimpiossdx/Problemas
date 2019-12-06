using System;

namespace olamundo
{
    class Program
    {
        static int percentual(double salario)
        {
            if (salario >= 0.0 && salario <= 400.00)
            {
                return (15);
            }
            if (salario >= 400.01 && salario <= 800.00)
            {
                return (12);
            }
            if (salario >= 800.01 && salario <= 1200.00)
            {
                return (10);
            }
            if (salario >= 1200.01 && salario <= 2000.00)
            {
                return (7);
            }
            return (4);
        }
        static void Main(string[] args)
        {
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine($"Novo salario: {(((percentual(salario) * salario) / 100) + salario).ToString(".00") }");
            Console.WriteLine($"Reajuste ganho: {((percentual(salario) * salario) / 100).ToString(".00")}");
            Console.WriteLine($"Em percentual: {percentual(salario)} %");
        }
    }
}
