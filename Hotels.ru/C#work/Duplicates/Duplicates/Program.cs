using System;
using System.Collections.Generic;

namespace Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Стажер / Джуниор-программист blockchain смарт-контрактов (solidity, nodeJs) в компанию Hotels.ru");
            Console.WriteLine("sadielgodales@gmail.com");
            int[] numbers1 =new int [] { 7, 17, 1, 9, 1, 17, 56, 56, 23 };
            int[] numbers2 = new int[] { 56, 17, 17, 1, 23, 34, 23, 1, 8, 1 };
            List<int> result = Duplicate(numbers1, numbers2);
            Console.Write("[");
            foreach (var item in result)
            {
                Console.Write(" "+item+",");
            }
            Console.Write("]");
        }
        public static int[] DuplicateInOne(int[] number)
        {
            List<int> a = new List<int>();            
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = i+1; j < number.Length; j++)
                {
                    if (number[i]== number[j])
                    {                        
                        if (!a.Contains(number[i]))
                        { 
                            a.Add(number[i]);
                            break;
                        }
                        
                    }
                }
            }
            return a.ToArray();
        }
        public static List<int> Duplicate(int[] number1, int[] number2)
        {
            int[] duplicate1= DuplicateInOne(number1);
            int[] duplicate2 = DuplicateInOne(number2);
            List<int> result = new List<int>();
            for (int i = 0; i < duplicate1.Length; i++)
            {
                for (int j =i+1; j < duplicate2.Length; j++)
                {
                    if (duplicate1[i] == duplicate2[i] && !result.Contains(duplicate1[i]))
                    {
                        result.Add(duplicate1[i]);
                        break;
                    }
                }
            }
            return result;
        }
       


    }
}
