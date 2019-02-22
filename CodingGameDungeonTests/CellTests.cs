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
    public class CellTests
    {
        [TestMethod()]
        public void GetContentsTest()
        {
            var generator = new BlumBlumShubNumberGenerator(100000, 1723, 1579);
            var cell = new Cell(0, 0, 3, 2, generator);
            cell.SetCellType();
            var cellType = cell.CellContent.Type;

            Assert.AreEqual(CellType.EastWall, cellType);
        }
        [TestMethod()]
        public void GetContentsTest2()
        {
            var generator = new BlumBlumShubNumberGenerator(100000, 1723, 1579);
            var cell = new Cell(1, 0, 3, 2, generator);
            cell.SetCellType();
            var cellType = cell.CellContent.Type;

            Assert.AreEqual(CellType.EastWall, cellType);
        }
        [TestMethod()]
        public void GetContentsTest3()
        {
            var generator = new BlumBlumShubNumberGenerator(100000, 1723, 1579);
            var cell = new Cell(0, 1, 3, 2, generator);
            cell.SetCellType();
            var cellType = cell.CellContent.Type;

            Assert.AreEqual(CellType.SouthWall, cellType);
            
        }

        [TestMethod()]
        public void GetContentsTest4()
        {
            var generator = new BlumBlumShubNumberGenerator(100000, 1723, 1579);
            var cell = new Cell(2, 1, 3, 2, generator);
            cell.SetCellType();
            var cellType = cell.CellContent.Type;

            Assert.AreEqual(CellType.EastWall, cellType);
            
        }
    }
}