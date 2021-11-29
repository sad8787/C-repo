using NumberBeautiful;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Ther!");
            long cont = 0;
            long[] a = new long[61];
            long[] b = new long[61];
            Number numberA = new Number();
            //Thread thread0=null;
            while (!numberA.Last())//
            {                
                int s = numberA.Sum();                
                if ( s<= 60)
                {
                    a[s]++;
                    if (numberA.Cero())
                    {
                        b[s]++;                       
                    }
                }
                numberA.Increase(5);           
            }
            for (int s = 0; s < 61; s++)
            {
                if (a[s]!=0 && b[s]!=0)
                {
                    cont += a[s] * b[s] * 13;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("The total of beautiful numbers with a leading zero is: " + cont);
            Console.WriteLine("sadielgodales@gmail.com name-> Sadiel Godales Quinones ");
            Console.ReadKey();
        }        
       
    }
}
