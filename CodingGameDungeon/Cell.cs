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

        BlumBlumShubNumberGenerator RandomGenerator { get; set; }
        int W { get; set; }
        int H { get; set; }
        

        List<string> Contents { get; set; }

        public Cell(int x, int y, int w, int h, BlumBlumShubNumberGenerator generator)
        {
            X = x;
            Y = y;
            W = w;
            H = h;
            RandomGenerator = generator;
            
        }

        List<string> WallEast = new List<string>()
        {
             ".#",
             ".#"
        };

        List<string> WallSouth = new List<string>()
        {
             "..",
             "##"
        };

        public List<string> GetContents()
        {
            if (X == W - 1)
            {
                
                return WallEast;
            }
            else if (Y == H - 1)
            {
                
                return WallSouth;
            }
            else
            {
                
                var n = X + Y * W + 1;
                var randomNumber = RandomGenerator.GenerateNthTerm(n);
                if (randomNumber % 2 == 0)
                {
                   
                    return WallSouth;
                }
                else
                {
                   
                    return WallEast;
                }
            }


        }

    }
}
