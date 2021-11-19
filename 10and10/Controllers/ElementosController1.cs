using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10and10.Models;

namespace _10and10.Controllers
{
    public class ElementosController1 : Controller
    {

        private List<Elemento> listelementos = new List<Elemento>();
        public ElementosController1()
        {
            for (int i = 0; i < 100; i++)
            {
                listelementos.Add(new Elemento(i));
            }
        }        
             
        public IActionResult Index(int? id)
        {
            int a = 0;
            if (id == null)
                a= 0;
            else
                a = int.Parse(id.ToString());
            if (a == -1|| a >= listelementos.Count)//final
                a = listelementos.Count-10;
            if (a < 0)
                a = 0;            

            List<Elemento> elem = new();
            for (int i = a; (i < a + 10) && (i < listelementos.Count); i++)
            {
                elem.Add(listelementos[i]);
            }
            ViewBag.NumTimes = a + 10;
            return View(elem);
        }       
        
        
        
    }
}
