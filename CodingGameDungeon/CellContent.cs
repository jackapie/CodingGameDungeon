using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGameDungeon
{
    public enum CellType{
        EastWall,
        SouthWall,
        TreasureEastWall,
        TreasureSouthWall,
        OgreEastWall,
        OgreSouthWall

    }

    public class CellContent
    {
        
        public CellType Type { get; set; }

        List<string> Contents { get; set; }

        public CellContent(CellType type)
        {
            Type = type;
        }
        
        public void SetContents()
        {
            switch (Type)
            {
                case CellType.EastWall:
                    Contents = new List<string>()
                    {
                          ".#",
                          ".#"
                    };
                    break;
                case CellType.SouthWall:
                    Contents = new List<string>()
                    {
                          "..",
                          "##"
                    };
                    break;
                case CellType.TreasureEastWall:
                    Contents = new List<string>()
                    {
                          "T#",
                          ".#"
                    };
                    break;
                case CellType.TreasureSouthWall:
                    Contents = new List<string>()
                    {
                          "T.",
                          "##"
                    };
                    break;
                case CellType.OgreEastWall:
                    Contents = new List<string>()
                    {
                          "X#",
                          ".#"
                    };
                    break;
                case CellType.OgreSouthWall:
                    Contents = new List<string>()
                    {
                          "X.",
                          "##"
                    };
                    break;
                default:
                    Contents = new List<string>()
                    {
                          "xx",
                          "xx"
                    };
                    break;

            }
           
        }
    }
}
