using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_List_Delete_repited
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            Console.WriteLine("Duplas");
            List<Dupla> list_duplas = new List<Dupla>();
            list_duplas.Add(new Dupla("Key1", "Value1"));
            list_duplas.Add(new Dupla("Key1", "Value2"));
            list_duplas.Add(new Dupla("Key1", "Value1"));
            list_duplas.Add(new Dupla("Key2", "Value1"));
            list_duplas.Add(new Dupla("Key2", "Value2"));
            list_duplas.Add(new Dupla("Key3", "Value1"));
            list_duplas.Add(new Dupla("Key3", "Value2"));
            list_duplas.Add(new Dupla("Key3", "Value3"));
            list_duplas.Add(new Dupla("Key3", "Value1"));
            list_duplas.Add(new Dupla("Key3", "Value2"));
            List<Dupla> distinct_Dupla_List = list_duplas.Distinct().ToList();

            foreach (var ele in distinct_Dupla_List)
            {
                Console.WriteLine("Key = {0}, Value = {1}", ele.key, ele.value);
            }
            Console.ReadKey();

        }
    }
}
