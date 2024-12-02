using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

//using Range = Microsoft.Office.Interop.Excel.Range;

namespace Monedas.Data
{

    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;        
        public Excel(string path, int Cheet) //direccion , pagina
        {
           
            try
            {
                this.path = path;
                if (!File.Exists(path))
                {
                    
                    try
                    {
                        wb= excel.Workbooks.Add(Type.Missing);
                        wb.SaveAs(path);
                    }
                    catch (Exception ex){ Console.WriteLine(ex.Message); }                    
                }                
                wb = excel.Workbooks.Open(path);
                ws = wb.Worksheets[Cheet];
            }
            catch (Exception)
            {

                throw;
            }

        }

        
        public string ReadCell(int i, int j)//row , colum
        {
            try
            {
                if (ws.Cells[i, j].Value2 != null)
                {
                    return ws.Cells[i, j].Value2;
                }
                else
                    return "";
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public void WriteNewRow( string[] cadena ) 
        {
            try
            {
                ws.Rows["1"].Insert();
                for (int i = 0; i < cadena.Length; i++)
                {
                    ws.Cells[1, i+1].value2 = cadena[i];
                }
                Save();
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }
            
            
        }     
       
        public void WriteCell(int i, int j,string sData)
        {
            ws.Cells[i, j].Value2 = sData;
        }
        public void Save()
        {
            wb.Save();
           
        }
        public void Close()
        {
            wb.Close(true,Type.Missing,Type.Missing); 
        }
        public void Quit() 
        { 
            excel.Quit();
            
        }

        public void SaveAs(string path) 
        {
            wb.SaveAs(path);
        }
    }
}
