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
    public class BlumBlumShubNumberGeneratorTests
    {
        [TestMethod()]
        public void GenerateNextTermTest()
        {
            var numberGenerator = new BlumBlumShubNumberGenerator();
            var zerothTerm = numberGenerator.GenerateNextTerm(3, 11, 19);
            var firstTerm = numberGenerator.GenerateNextTerm(zerothTerm, 11, 19);
            var secondTerm = numberGenerator.GenerateNextTerm(firstTerm, 11, 19);
            var thirdTerm = numberGenerator.GenerateNextTerm(secondTerm, 11, 19);
            var fourthTerm = numberGenerator.GenerateNextTerm(thirdTerm, 11, 19);
            var fifthTerm = numberGenerator.GenerateNextTerm(fourthTerm, 11, 19);
            Assert.AreEqual(9, zerothTerm);
            Assert.AreEqual(81, firstTerm);
            Assert.AreEqual(82, secondTerm);
            Assert.AreEqual(36, thirdTerm);
            Assert.AreEqual(42, fourthTerm);
            Assert.AreEqual(92, fifthTerm);

        }

        [TestMethod()]
        public void GenerateNthTermTest()
        {
            var numberGenerator = new BlumBlumShubNumberGenerator();
            //var fourthTerm = numberGenerator.GenerateNthTerm(3, 11, 19, 5);
            var fifthTerm = numberGenerator.GenerateNthTerm(3, 11, 19, 6);
            //Assert.AreEqual(42, fourthTerm);
            Assert.AreEqual(92, fifthTerm);
        }

        [TestMethod()]
        public void LambdaMTest()
        {
            var numberGenerator = new BlumBlumShubNumberGenerator();
            var result = numberGenerator.LambdaM(11, 19);
            Assert.AreEqual(90, result);
        }

        [TestMethod()]
        public void PowerTest()
        {
            var numberGenerator = new BlumBlumShubNumberGenerator();
            var result = numberGenerator.Power(11, 19, 4);
            Assert.AreEqual(16, result);
        }
    }
}