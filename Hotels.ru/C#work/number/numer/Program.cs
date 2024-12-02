using System;

namespace numer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Стажер / Джуниор-программист blockchain смарт-контрактов (solidity, nodeJs) в компанию Hotels.ru");
            Console.WriteLine("sadielgodales@gmail.com");
            double[] d = { 27.9876543, 1, 11.8, 12.6, 15.1,94.6 };
            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine("Original Value " + d[i]+" new value "+ FuntionNumer(d[i]));
            }    

        }
        public static int FuntionNumer(double number)
        {
           // int i = (int)Math.Round(number);
            double r = number % 5;
            int  j = (int) number / 5;            
            if (r > 2.5)
            {
               return (int)(j * 5 + 5);
            }
            else
            {
                return (int)(j * 5);
            }           
        }
    }
}
