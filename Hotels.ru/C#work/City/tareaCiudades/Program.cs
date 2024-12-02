using System;

namespace tareaCiudades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Стажер / Джуниор-программист blockchain смарт-контрактов (solidity, nodeJs) в компанию Hotels.ru");
            Console.WriteLine("sadielgodales@gmail.com");
            Console.WriteLine("Instructions.\n Enter the name of the city and then the enter key.\n Type exit for exit");
            Console.WriteLine("инструкции. \n Введите название города и затем нажмите клавишу ввода. \n Введите exit для выхода.");
            string cityName = "";
            string inputstring = "";
            while (!inputstring.Equals("exit"))
            {               
                Console.WriteLine("I hope commando");
                inputstring = Console.ReadLine() ;
                if (inputstring.Equals("exit"))
                {
                    cityName += ".";
                    break;
                }
                else 
                {
                    if (cityName == "")
                        cityName += inputstring;
                    else
                        if(!inputstring.Equals("")) 
                            cityName += ","+ inputstring;
                }
                    
            }            
            Console.WriteLine(cityName);
               
                
        

        }
    }
}
