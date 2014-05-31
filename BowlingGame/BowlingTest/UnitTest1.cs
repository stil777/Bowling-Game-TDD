using System;
using BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bowling game = new Bowling();
            for (int i = 0; i < 20; i++)
                game.roll(0);
            Assert.AreEqual(0, game.score());
        }
    }
}
