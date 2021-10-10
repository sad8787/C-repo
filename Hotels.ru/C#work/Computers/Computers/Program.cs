using System;

namespace Computers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Стажер / Джуниор-программист blockchain смарт-контрактов (solidity, nodeJs) в компанию Hotels.ru");
            Console.WriteLine("sadielgodales@gmail.com");
            Console.WriteLine("\n Enter number");
            Console.WriteLine(FuntionNumer(int.Parse( Console.ReadLine())));
        }
        public static string FuntionNumer(int number)
        
        {            
            int r = (int)number % 10;            
            if (r > 4)            
                return number + " компьютеров"; 
            if (r >1 && r<5)
                return number + " компьютера";
            if (r == 1)
                return number + " компьютер";
            else
                return number + " компьютеров";
        }
    }

}
