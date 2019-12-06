using System;

namespace _1051
{
    class Program
    {
        public static void impostoDeRenda(float salario)
        {
            if (salario > 0.00 && salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            if (salario >= 2000.01 && salario <= 3000.00)
            {
                Console.WriteLine($"R$ {((salario - 2000.00) * 0.08).ToString(".00")}");
            }
            if (salario >= 3000.01 && salario <= 4500.00)
            {
                Console.WriteLine($"R$ {((1000.00 * 0.08) + ((salario - 3000.00) * 0.18)).ToString(".00")}");
            }
            if (salario > 4500.00)
            {
                Console.WriteLine($"R$ {((1000.00 * 0.08) + (1500 * 0.18) + ((salario - 4500.00) * 0.28)).ToString(".00")}");
            }
        }
        static void Main(string[] args)
        {
            float salario = float.Parse(Console.ReadLine());
            impostoDeRenda(salario);
        }
    }
}
