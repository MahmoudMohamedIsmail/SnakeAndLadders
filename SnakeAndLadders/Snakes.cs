using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Speech.Synthesis;

namespace SnakeAndLadders
{
    public partial class Snakes : Form
    {
        Table table = new Table();
        int CurentPlayer= 0,InxPlayer=-1,rate=1;
       public Game game { get; set; }
        public Snakes()
        {
            InitializeComponent();

            //10 Snakes And 10 Ladders
            table.SetSnakesAndLadders(10);
            Grid.Invalidate();

         
        }

        private void Grid_Paint(object sender, PaintEventArgs e)
        {
            table.DrwaTable(e,game.Players);
            
            //The Player is Win if equal 99
            if (game.Players[CurentPlayer].cell == 99)
            {
                game.Players[CurentPlayer].Win = true;
                game.Players[CurentPlayer].Rate = rate;
                game.CurPlayers.Remove(CurentPlayer);
                InxPlayer--;
                rate++;
            }

            //Get next player
            InxPlayer=game.NextPlayer(InxPlayer);
          

            //All Win
            if (InxPlayer == -1)
            {
                MessageBox.Show("Congratulation");

            }
            else
            {
                CurentPlayer = game.CurPlayers[InxPlayer];
                //Update Name of player
                PlayerName.Text = game.Players[CurentPlayer].Name;
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RollBut_Click(object sender, EventArgs e)
        {


			/*
            
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult); // to change VoiceGender and VoiceAge check out those links below
            synthesizer.Volume = 100;  // (0 - 100)
            synthesizer.Rate = 0;     // (-10 - 10)

            synthesizer.SpeakAsync(game.Players[CurentPlayer].Name); // here args = pran
*/
            

         
            Random random = new Random();
            int Number=random.Next(1, 7);// 1 to 6 
            // Draw Dice
            DicePic.Image = Image.FromFile(Number.ToString() + ".png");
            DicePic.Image =  (Image)(new Bitmap(DicePic.Image, new Size(DicePic.Width, DicePic.Height))); 
         
             
            
            
            //  RandomDice.Text =Number.ToString();
            game.Players[CurentPlayer].cell += Number;
           
            //check if is out of range
            if (game.Players[CurentPlayer].cell > 99)
            {
                game.Players[CurentPlayer].cell -= Number;
            }
            // Check if there is a snakes or Ladders
            if (table.cells[game.Players[CurentPlayer].cell].Snake || table.cells[game.Players[CurentPlayer].cell].Ladder)
            {
                game.Players[CurentPlayer].cell = table.cells[game.Players[CurentPlayer].cell].Destination;
            }

              Grid.Invalidate();

             // synthesizer.SpeakAsync("Next Player Is  Mahmoud"); // here args = pran
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.DrawPlayersInScreen(this);
            game.SetPlayers();
           
            Grid.Invalidate();
        }

    }
}
