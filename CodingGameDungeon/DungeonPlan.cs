using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGameDungeon
{
    public class DungeonPlan
    {
        int W { get; set; }
        int H { get; set; }

        BlumBlumShubNumberGenerator RandomGenerator { get; set; }

        public DungeonPlan(int w, int h, BlumBlumShubNumberGenerator random)
        {
            W = w;
            H = h;
            RandomGenerator = random;
        }

        List<Cell> Cells { get; set; }        

        public List<Cell> GetCells()
        {
            for (int y = 0; y < H; y++)
            {
                for (int x = 0; x < W; x++)
                {
                    var cell = new Cell(x, y, W, H, RandomGenerator);
                    Cells.Add(cell);
                }
            }
            return Cells;
        }


    }
}
