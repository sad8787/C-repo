using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {

        static async Task Main(string[] args)
        {
            
            string addresspath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            addresspath = addresspath.Remove(0, 6);
            string fileNameReport = addresspath + "\\report.json";
            /*
            string fileNameTests = addresspath+"\\tests.json";
            string fileNameValues = addresspath + "\\values.json";            
            #endregion Defaul Values*/
            string fileNameTests = ""; 
            string fileNameValues="";
            if (args.Length != 2)
            {
                Console.WriteLine("Error");
            }                
            else
            {
                fileNameTests = args[0];
                fileNameValues = args[1];
            }            

            //read Json
            var stringTestsFronFile = GetJsonfromFile(fileNameValues);
            Values listValues = DesearilizarValuesFronJsonFail(stringTestsFronFile);
            stringTestsFronFile = GetJsonfromFile(fileNameTests);
            Tests listTests = DesearilizarFronJsonFail(stringTestsFronFile);

            //logic generate report
            for (int i = 0; i < listTests.tests.Length; i++)
            {
                listTests.tests[i] = ReportLogic(listTests.tests[i], listValues);
            }
            SerializeReportJsonFail(listTests, fileNameReport);
            Console.Write(GetJsonfromFile(fileNameReport));
            Console.ReadKey();



        }
       
        public static string GetJsonfromFile(string adresFile)
        {
            string JsonFromFile;
            using (var reder = new StreamReader(adresFile))
            {
                JsonFromFile = reder.ReadToEnd();
            }
            return JsonFromFile;
        }
        public static Tests DesearilizarFronJsonFail(string JsonFromFail)
        {
            var list = JsonConvert.DeserializeObject<Tests>(JsonFromFail);
            return list;
        }

        public static Values DesearilizarValuesFronJsonFail(string JsonFromFail)
        {
            var list = JsonConvert.DeserializeObject<Values>(JsonFromFail);
            return list;
        }
             
      
       
        //ok
        public static void SerializeReportJsonFail(Tests listTests, string fileName)
        {
            string listTestsJsonString = JsonConvert.SerializeObject(listTests, Formatting.Indented);
            File.WriteAllText(fileName, listTestsJsonString);
        }
       
        public static Test ReportLogic(Test test, Values values)
        {
            if (test.values != null)
            {
                for (int i = 0; i < test.values.Length; i++)
                {
                    test.values[i]=  ReportLogic(test.values[i], values);
                }

                
            }
            foreach (var v in values.values)
            {
                if (v.id == test.id)
                {
                    test.value = v.value;
                    break;
                }
            }
            return test;
        }



    }
}
