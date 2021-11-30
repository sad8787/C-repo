using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberBeautiful
{
    public class Number
    {
        int[] valueA = new int[6];
        public Number()
        {
            for (int i = 0; i < 6; i++)
            {
                valueA[i] = 0;
            }
        }
        
        public int Sum()
        {
            return valueA[0] + valueA[1] + valueA[2] + valueA[3] + valueA[4] + valueA[5];
        }
        public bool FirstCero()
        {
            return (valueA[0] == 0 && valueA[1] == 0);
        }
        public bool Last()//CCCC01
        {
            return (valueA[0] == 12 && valueA[1] == 12 && valueA[2] == 12 && valueA[3] == 12 && valueA[5] == 1);//CCCC01
        }
        public void Increase(int poss) //desde 6 a 0
        {
            if (poss >= 0)
            {
                Boolean a = auxIncrease(poss);
                if (a == true)
                {
                    Increase(poss - 1);
                }
            }
        }
        public bool auxIncrease(int a)
        {
            if (valueA[a] == 12)
            {
                valueA[a] = 0;
                return true;
            }
            else
            {
                valueA[a] += 1;
                return false;
            }
        }
    }
}
    
