using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeAndLadders
{
  public class Player
    {
        public Color[] colors = {  Color.Green,  Color.Turquoise, Color.Brown, Color.Blue, Color.Chocolate,
                                    Color.Yellow, Color.Red, Color.SkyBlue, Color.YellowGreen, Color.Tomato, Color.SeaGreen, 
                                    Color.RosyBrown, Color.Plum, Color.Orchid, Color.MistyRose, Color.BurlyWood, 
                                    Color.CornflowerBlue,
                                    Color.Cyan, Color.DarkCyan, Color.DarkGray };
        public string Name;
        public int ID,Rate,cell=0;
        public Color color;
        public bool Win;

        public Player(int id,string name)
        {
            ID = id;
            Name = name;
            color = colors[id % 20]; //to avoid out of range
            Win = false;
        }

    }
}
