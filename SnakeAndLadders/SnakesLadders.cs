using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    class SnakesLadders
    {
        public int Start, End,tall;

        public SnakesLadders(int s,int talls)
        {
           
            Start = s;

            tall = talls;
            if(tall==1)
            {
                int lastdigit=Start%10;
                End = ((Start - 10) - lastdigit) + Math.Abs(lastdigit - 9);
            }
            else if (tall == 2)
            {
                End = Start - 20; //10*tall here tall equal two
            }
            else if (tall == 3)
            {
                int lastdigit = Start % 10;
                End = ((Start - 10 * 3) - lastdigit) + Math.Abs(lastdigit - 9);
            }
            else {
                End = Start - 40;
            }
        
        }
    }
}
