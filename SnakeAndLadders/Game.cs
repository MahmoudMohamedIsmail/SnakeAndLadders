using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeAndLadders
{
   public  class Game
    {
        public List<Player> Players;
        public List<int> CurPlayers;
        int Number;

        public Game(int number, List<string> players)
        {
            Number = number;
            Players = new List<Player>();
            CurPlayers = new List<int>();
            for (int p = 0; p < number; p++)
            {
                Player NewPlayer = new Player(p,players[p]);
                Players.Add(NewPlayer);
                CurPlayers.Add(p);
            }
        }

        public void DrawPlayersInScreen(Form form)
        {

            System.Drawing.Graphics graphics = form.CreateGraphics();
            Font drawFontBold = new Font("Arial", 10, FontStyle.Bold);   

            for (int player = 0; player < Number; player++)
            {

               Brush brush = new SolidBrush(Players[player].color);
                //Draw Cycle 
               graphics.FillEllipse(brush,420,45*player+10,30, 30);


               brush = new SolidBrush(Color.Black);
                //Draw Name
               graphics.DrawString(Players[player].Name, drawFontBold, brush, 455, player * 45 + 15);
 
            }
            
        }
        public void SetPlayers()
        {
            CurPlayers = new List<int>();
            for (int p = 0; p < Number; p++)
            {
                CurPlayers.Add(p);
                Players[p].cell = 0;
                Players[p].Win = false;
                Players[p].Rate = 0;
            }
        }
        public int NextPlayer(int cur)
        {
            if (CurPlayers.Count == 0)
            {
                return -1;
            }
            else
            {
                return (cur+1)%(CurPlayers.Count); //Cycle same to queue
            }
        }

    }
}
