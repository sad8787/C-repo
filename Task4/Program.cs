using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "";
            if (args.Length != 1)
                Console.WriteLine("Error");
            else
            {
                text1 = args[0];
                
            }
            TextReader leer1 = new StreamReader(text1);
            List<double> vs = new List<double>();
            string l;
            while ((l = leer1.ReadLine()) != null)
            {
                vs.Add( double.Parse(l)); 
            }            
            int averge = Convert.ToInt32(vs.Average());
            int Steps = 0;
            foreach (var item in vs)
            {
                int a = Convert.ToInt32(item);
                if (a < averge)
                {
                    Steps += averge - a;
                }
                else
                {
                    Steps += a - averge;
                }
            }
            Console.WriteLine(Steps);
            Console.ReadKey();
        }
    }
}
