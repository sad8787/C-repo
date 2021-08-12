using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int m = 0;
            if (args.Length != 2)
                Console.WriteLine("Error");
            else
            {
                n = int.Parse(args[0]);
                m = int.Parse(args[1]);
            }


            //Create массив
            int[] listvalues = new int[n];
            for (int i = 0; i < n; i++)
            {
                listvalues[i] = i + 1;
            }
            //тур массовый
            int index = 0;
            string resultat = "";
            string a = "";

            do
            {
                a = listvalues[index].ToString();
                for (int i = 0; i < m; i++)
                {
                    if (index == n - 1)
                    {
                        index = 0;
                    }
                    else
                        index += 1;
                }

                if (index > 0)
                {
                    index -= 1;
                }
                else
                {
                    index = n - 1;
                }
                resultat += a;

            } while (listvalues[index] != 1);
            Console.WriteLine(resultat + "\r\n");
            
        }
    }
}
