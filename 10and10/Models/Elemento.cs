using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10and10.Models
{
    public class Elemento
    {
        public Elemento(int id)
        {
            
            Name = "Elemento Name "+(id+1);
            Id = id;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
