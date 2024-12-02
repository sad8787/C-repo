using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Стажер / Джуниор-программист blockchain смарт-контрактов (solidity, nodeJs) в компанию Hotels.ru");
            Console.WriteLine("sadielgodales@gmail.com");
            Console.WriteLine("\n Enter number");
            Console.WriteLine(IsPrime(int.Parse(Console.ReadLine())));
        }
        static bool IsPrime(int number)//Is a prime ?
        {
            for (int i = 2; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    // :(
                    return false;
                }
            }
            //  :)
            return true;
        }
    }
}
