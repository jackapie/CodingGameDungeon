using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGameDungeon
{
    public class DungeonPlanGenerator
    {
        int W { get; set; }
        int H { get; set; }

        BlumBlumShubNumberGenerator RandomGenerator { get; set; }

        public DungeonPlanGenerator(int w, int h, BlumBlumShubNumberGenerator rndmNumberGenerator)
        {
            W = w;
            H = h;
            RandomGenerator = rndmNumberGenerator;
        }                

        public List<List<Cell>> GetCells()
        {
            var plan = new List<List<Cell>>();
            for (int y = 0; y < H; y++)
            {
                var cells = new List<Cell>();
                for (int x = 0; x < W; x++)
                {
                    var cell = new Cell(x, y, W, H, RandomGenerator);
                    cells.Add(cell);
                }
                plan.Add(cells);
            }
            return plan;
        }


    }
}
