using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeAndLadders
{
    class Table
    {
        public List<Cell> cells = new List<Cell>();
        public List<SnakesLadders> Snakes= new List<SnakesLadders>();
        public List<SnakesLadders>Ladders=new List<SnakesLadders>();
    
        public Table()
        {
            //initialize Table ID and x,y, width, height
            int cell = 0;
            bool Left = true, Right = false;// Left and Rigt To Display Number of Revers method
            for (int row = 9; row >= 0; row--)
            {

                if (Left)
                {
                    Left = false;
                    Right = true;
                    for (int col = 0; col <=9; col++)
                    {
                        Cell New = new Cell(cell);
                        cell++;
                        New.x = col * 40;
                        New.y = row * 40;
                        New.width = 40;
                        New.height = 40;
                        New.row = row;
                        New.col = col;
                        //Add Cell
                        cells.Add(New);
                    }
                }
                else if (Right)
                {
                    Left = true;
                    Right = false;
                    for (int col = 9; col >= 0; col--)
                    {
                        Cell New = new Cell(cell);
                        cell++;
                        New.x = col * 40;
                        New.y = row * 40;
                        New.width = 40;
                        New.height = 40;
                        New.row = row;
                        New.col = col;
                        //Add Cell
                        cells.Add(New);
                    }
                }

            }
        }
        public void SetSnakesAndLadders(int Number)
        {

          // For All Snakes
            while(Snakes.Count<Number)
            {
              // MessageBox.Show(i.ToString());
                Random random1 = new Random();//for start cell
                Random random2 = new Random();//for tall of snake
                int r1, r2;
                // (r1/ 10 >= r2) to avoid out of layer
                while (validation(r1 = random1.Next(99), r2 = random2.Next(1, 4)) && (r1 / 10 >= r2)) 
                {
                    
                    //Set Cells.Valid =false 
                    SetValidationOfTable(r1, r2);

                    SnakesLadders snake = new SnakesLadders(r1, r2);
                   //Add snake 
                    Snakes.Add(snake);

                    //For All Snakes In Cell
                    cells[Snakes[Snakes.Count - 1].Start].Snake = true;
                    cells[Snakes[Snakes.Count - 1].Start].Destination = Snakes[Snakes.Count - 1].End;
                    cells[Snakes[Snakes.Count - 1].Start].Tall = Snakes[Snakes.Count - 1].tall;
                    break;
                }
            }
           
            //For All Ladders
            while (Ladders.Count < Number)
            {
                Random random1 = new Random();
                Random random2 = new Random();
                int r1, r2;
                // (r1/ 10 >= r2) to avoid out of layer
                while (validation(r1 = random1.Next(100), r2 = random2.Next(1, 4)) && (r1 / 10 >= r2))
                {
                    //Set Cells.Valid =false 
                    SetValidationOfTable(r1, r2);
                    SnakesLadders ladder = new SnakesLadders(r1, r2);
                    //Add Ladders 
                    Ladders.Add(ladder);


                    //For All Ladders In Cell
                    cells[Ladders[Ladders.Count - 1].End].Ladder = true;
                    cells[Ladders[Ladders.Count - 1].End].Destination = Ladders[Ladders.Count - 1].Start;
                    cells[Ladders[Ladders.Count - 1].End].Tall = Ladders[Ladders.Count - 1].tall;
                    break;
                }
            }
           

        }
        public bool validation(int cell, int tall)
        {
            if (!cells[cell].valid)
                return false;
           
            //For all cells in Tall
            for (int range = 1; range <= tall; range++)
            {
                 int lastdigit = cell % 10;
                 int End;
                 if (range % 2 == 0)
                 {
                     End = ((cell - 10 * range)); 
                 }
                 else
                 {
                     End = ((cell - 10 * range) - lastdigit) + Math.Abs(lastdigit - 9);
                 }
                
 
                if (End < 0)
                     return false;
                 if (!cells[End].valid)
                 {
                     return false;
                 }

            }
           //MessageBox.Show("True");
            return true;

        }
        private void SetValidationOfTable(int cell,int tall)
        {
            cells[cell].valid = false;
               
            for (int range = 1; range <= tall; range++)
            {
                int lastdigit = cell % 10;
                 int End;
                 if (range % 2 == 0)
                 {
                     End = (cell - 10 * range);
                 }
                 else
                 {
                     End = ((cell - 10 * range) - lastdigit) + Math.Abs(lastdigit - 9);
                 }

                // cell = false
                cells[End].valid=false;             

            }
        }
        public void DrwaTable(PaintEventArgs e,List<Player>players)
        {

       
            //Initialize Graphics To Draw Table
            var g = e.Graphics;
            Pen pen = new Pen(Color.White);
            Font drawFontBold = new Font("Arial", 7, FontStyle.Bold);   
            Brush brush = new SolidBrush(Color.Black);
           

                //Color Panel By Blue
                g.FillRectangle(brush, 0, 0, 400, 400);


                //Set Color Of Start Position And End positon
                brush = new SolidBrush(Color.DarkGreen);
                g.FillRectangle(brush, 0, 9 * 40 , 40, 40);//Equal Cell 0 

                //Set Color Of End Position 
                brush = new SolidBrush(Color.Red);
                g.FillRectangle(brush, 0, 0, 40, 40); //Equal Cell 99

                brush = new SolidBrush(Color.White);
                //For All Cells Display It and its ID
                for (int cell = 0; cell < 100; cell++)
                {
                    // Drae Rectangle 
                    g.DrawRectangle(pen, cells[cell].x, cells[cell].y, cells[cell].width, cells[cell].height);
                    //Draw Number of cell in rectangle
                    g.DrawString(cells[cell].ID.ToString(), drawFontBold, brush, cells[cell].x + 2, cells[cell].y + 2);
                }



                //Draw snakes and Ladders
                for (int cell = 0; cell < 100; cell++)
                {
                    if (cells[cell].Snake)
                    {
                        Image imag = Image.FromFile(@"Snakes.png");
                        //Resize Image
                        imag = (Image)(new Bitmap(imag, new Size(15, cells[cell].Tall * 40)));
                        e.Graphics.DrawImage(imag, new Point(cells[cell].x + 15, cells[cell].y + 20));
                    }
                    if (cells[cell].Ladder)
                    {
                        Image imag = Image.FromFile(@"Ladderss.png");
                        imag = (Image)(new Bitmap(imag, new Size(15, cells[cell].Tall * 40)));
                        e.Graphics.DrawImage(imag, new Point(cells[cells[cell].Destination].x + 15, cells[cells[cell].Destination].y + 20));
                    }
                }


                //Draw Players
                foreach (var player in players)
                {
                    
                        brush = new SolidBrush(player.color);
                        g.FillEllipse(brush, cells[player.cell].x, cells[player.cell].y, cells[player.cell].width, cells[player.cell].height);
                    
                }
        }
      
    }
}
