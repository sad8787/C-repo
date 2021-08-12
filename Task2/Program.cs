using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1="", text2="";
            if (args.Length != 2)
                Console.WriteLine("Error");
            else
            {
                text1 = args[0];
                text2 = args[1];
            }
            TextReader leer1 = new StreamReader(text1);
            TextReader leer2 = new StreamReader(text2);
            string[] words = leer1.ReadLine().Split(" ");
            Point center = new Point(int.Parse(words[0]), int.Parse(words[1]));                   
            int radio = int.Parse(leer1.ReadLine());
            
            string l;
            while ((l = leer2.ReadLine()) != null)
            {
                
                words = l.Split(" ");
                Point a2= new Point(int.Parse(words[0]), int.Parse(words[1]));
               

                int distancei = 0;
               
                distancei = Convert.ToInt32( Math.Sqrt((Math.Pow(center.x - a2.x, 2) + Math.Pow(center.y - a2.y, 2))));
                
                if (distancei == radio)
                {
                    Console.WriteLine(0);
                }
                if (distancei < radio)
                {
                    Console.WriteLine(1);
                }
                if (distancei > radio)
                {
                    Console.WriteLine(2);
                }

            }

            Console.ReadKey();
            

        }
    }
}
