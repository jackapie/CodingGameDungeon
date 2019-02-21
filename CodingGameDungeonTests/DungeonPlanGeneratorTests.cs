using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingGameDungeon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGameDungeon.Tests
{
    [TestClass()]
    public class DungeonPlanGeneratorTests
    {
        [TestMethod()]
        public void GetCellsTest()
        {
            var generator = new BlumBlumShubNumberGenerator(100000, 1723, 1579);
            var planGenerator = new DungeonPlanGenerator(3, 2, generator);
            var plan = planGenerator.GetCells();
            // cellxy = plan[y][x];
            var cell00 = plan[0][0];
            var cell10 = plan[0][1];
            var cell11 = plan[1][1];

            Assert.AreEqual(".#", cell00.Contents[0]);
            Assert.AreEqual(".#", cell10.Contents[0]);
            Assert.AreEqual("..", cell11.Contents[0]);

        }
    }
}