using System;

namespace Names
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] messages = {
                "Hi, i'm Carter",
                "mi name is Rod Stiwart",
                "Hice to meet you, im dixon",
            };
            string[] key = { "name is", "im", "i'm"   };
            string k = null;
            foreach (var message in messages)
            {
                for (int l = 0; l < key.Length; l++)
                {
                    if (message.Contains(key[l]))
                    {
                        k = key[l];
                        break;
                    }
                }
                //key существуют
                if (k != null)
                {
                    string[] m = message.Split(k);
                    Console.WriteLine(m[1]);
                }
                //reset key
                k = null;

            }


        }
        
    }
}
