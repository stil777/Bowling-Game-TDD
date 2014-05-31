using System;
using BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testGutterGame()
        {
            Bowling game = new Bowling();
            for (int i = 0; i < 20; i++)
                game.roll(0);
            Assert.AreEqual(0, game.score());
        }
        [TestMethod]
        public void testAllOnes()
        {
            Bowling game = new Bowling();
            for (int i = 0; i < 20; i++)
                game.roll(1);
            Assert.AreEqual(20, game.score());
        }
    }
}
