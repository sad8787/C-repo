using NumberBeautiful;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //00xxxxXxxxx00
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Ther!");
            long cont = 0;
            long[] a = new long[49];
            //long[] b = new long[49];
            Number numberA = new Number();            
            while (!numberA.Last())//
            {                
                int s = numberA.Sum();                
                if ( s<= 48)//max Sum =0+0+12+12+12+12=48
                {
                    //b[s]++;
                    /*if (numberA.FirstCero())
                    {
                        a[s]++;
                    }*/
                    a[s]++;
                }
                numberA.Increase(3);           
            }
            a[48]++;
            for (int s = 0; s < 49; s++)
            {
                // cont += a[s] * b[s] * 13;
                 cont += a[s] * a[s] * 13;  
            }
            Console.WriteLine("");
            Console.WriteLine("The total of beautiful numbers with leading zeros is: " + cont);
            Console.WriteLine("sadielgodales@gmail.com name-> Sadiel Godales Quinones ");
            Console.ReadKey();
        }        
       
    }
}
