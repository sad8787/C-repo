using System;

namespace NewNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Ther!");
            long cont = 0;
            long[] a = new long[61];            
            Number numberA = new Number();          

            while (!numberA.Last())
            {
                int s = numberA.Sum();
                a[s]++;
                numberA.Increase(4);
            }
            a[60]++;//When the sum is == 60 it is a valid option too
            for (int s = 0; s < 61; s++)
            {              
                 cont += a[s] * a[s] * 13;                
            }
            Console.WriteLine("");
            Console.WriteLine("The total of beautiful numbers with a leading zero is: " + cont);
            Console.WriteLine("sadielgodales@gmail.com name-> Sadiel Godales Quinones ");
            Console.ReadKey();
        }
    }
    public class Number
    {
        int[] valueA = new int[5];
        public Number()
        {
            for (int i = 0; i < 5; i++)
            {
                valueA[i] = 0;
            }
        }        
        public int Sum()
        {
            return valueA[0] + valueA[1] + valueA[2] + valueA[3] + valueA[4] ;
        }       
        public bool Last()
        {
            return (Sum() == 60);
        }//When the sum is == 60 it is a valid option too
        public void Increase(int poss) //from 4 to 0
        {
            if (poss >= 0)
            {
                Boolean a = auxIncrease(poss);
                if (a == true)
                {
                    Increase(poss - 1);
                }
            }
        }
        public bool auxIncrease(int a)
        {
            if (valueA[a] == 12)
            {
                valueA[a] = 0;
                return true;
            }
            else
            {
                valueA[a] += 1;
                return false;
            }
        }
    }
}
