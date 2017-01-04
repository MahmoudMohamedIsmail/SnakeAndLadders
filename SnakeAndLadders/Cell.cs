using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeAndLadders
{
    class Cell
    {
        public int ID,x,y,width,height,col,row;
      //public Point[] Points = new Point[4];
        public bool Snake = false, valid = true, Ladder=false;
        public int Destination = -1,Tall=0;

        public Cell(int id)
        {
            ID = id;
        }
    }
}
