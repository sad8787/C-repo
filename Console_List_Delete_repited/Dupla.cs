using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_List_Delete_repited
{
    public class Dupla
    {
        public string key { get; set; }
        public string value { get; set; }
        public Dupla(string key, string value) {
            this.key = key;
            this.value = value;
        }
        public override bool Equals(object obj)
        {
            return (((Dupla)obj).key + ((Dupla)obj).value) == key + value;
        }
        public override int GetHashCode()
        {
            return (key + value).GetHashCode();
        }
    }
}
