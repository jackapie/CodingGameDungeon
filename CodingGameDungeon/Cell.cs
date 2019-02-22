using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGameDungeon
{
    public class Cell
    {
        int X { get; set; }
        int Y { get; set; }
        int W { get; set; }
        int H { get; set; }

        BlumBlumShubNumberGenerator RandomGenerator { get; set; }

        public CellContent CellContent { get; set; }

        public Cell(int x, int y, int w, int h, BlumBlumShubNumberGenerator generator)
        {
            X = x;
            Y = y;
            W = w;
            H = h;
            RandomGenerator = generator;
        }


        public void SetCellType()
        {
            if (X == W - 1)
            {
                CellContent = new CellContent(CellType.EastWall);
            }
            else if (Y == H - 1)
            {
                CellContent = new CellContent(CellType.SouthWall);
            }
            else
            {
                var n = X + Y * W + 1;
                var randomNumber = RandomGenerator.GenerateNthTerm(n);
                if (randomNumber % 2 == 0)
                {

                    CellContent = new CellContent(CellType.SouthWall);
                }
                else
                {

                    CellContent = new CellContent(CellType.EastWall);
                }
            }


        }

    }
}
