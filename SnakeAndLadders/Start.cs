using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace SnakeAndLadders
{
    public partial class Start : Form
    {
        Game game;
        List<string> PlayersName = new List<string>();
        PictureBox StartPic = new PictureBox();
        int number = 0,Addplayer=1;
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            //Hide All Compponent
            label1.Hide();
            NumOfPlayers.Hide();
            PlayersNames.Hide();
            Startbt.Hide();
            Player.Hide();
            AddPlayers.Hide();

            //Show Pic Start Of Game And Music
          
             Image Pic =Image.FromFile("MainPicSnakes.jpg");
             Pic = (Image)(new Bitmap(Pic, this.Size));
             StartPic.Image = Pic;
             StartPic.Height = Pic.Height;
             StartPic.Width = Pic.Width;
            this.Controls.Add(StartPic);
            
            /*
            //Sleep 
            Thread.Sleep(2000);

            StartPic.Hide();
            // Resize form and show all
            this.Size = new Size(210, 335);
            label1.Show();
            NumOfPlayers.Show();
            PlayersNames.Show();
            Startbt.Show();
            */
        }

        private void Startbt_Click(object sender, EventArgs e)
        {
            if (NumOfPlayers.Text != ""||number!=0)
            {
               
                game = new Game(number, PlayersName);
                Snakes form = new Snakes();
                form.game = game;
                form.Show();
               // this.Close();
                

            }
            else
            {
                MessageBox.Show("Please Enter Number Of Players");
            }

        }

        private void Gobt_Click(object sender, EventArgs e)
        {
            StartPic.Hide();
            // Resize form and show all
            this.Size = new Size(210, 335);
            label1.Show();
            NumOfPlayers.Show();
            PlayersNames.Show();
            Startbt.Show();
            Player.Show();
            AddPlayers.Show();
        }

        private void AddPlayers_Click(object sender, EventArgs e)
        {
            if (NumOfPlayers.Text != "")
            {

                number = int.Parse(NumOfPlayers.Text); 
              
                if (Addplayer <= number)
                {
                    PlayersName.Add(PlayersNames.Text);
                    Addplayer++;

                    if (Addplayer <= number)
                    {
                        Player.Text = "Player" + Addplayer.ToString();
                        PlayersNames.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("You Enter exactly players numbers press Start button");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Number Of Players");
            }
        }
    }
}
