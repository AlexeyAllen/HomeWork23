using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork23
{
    // Разработать асинхронный метод для вычисления факториала числа.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение натурального числа для вычисления факториала числа");
            int factInput = Convert.ToInt32(Console.ReadLine());

            if (factInput == 0 || factInput == 1)
            {
                Console.WriteLine("Факториал {0} = 1", factInput);
            }
            else
            {
                Console.WriteLine("Факториал {0} = {1}", factInput, FactorialAsync(factInput).Result);
            }
            Console.ReadKey();
        }
        static BigInteger Factorial(int n)
        {
            BigInteger resultFactorial = 1;
            for (int i = 1; i < n + 1; i++)
            {
                resultFactorial *= i;
            }
            return resultFactorial;
        }
        static async Task<BigInteger> FactorialAsync(int n)
        {
            BigInteger result = await Task.Run(() => Factorial(n));
            return result;
        }
    }
}
