using NUnit.Framework;
using TexasHoldem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem.Tests
{
    [TestFixture()]
    public class CardTests
    {
        [Test]
        public void CardTest()
        {
            var QueenOfHearts = new Card('Q', 'H');
            Assert.AreEqual(QueenOfHearts.Rank, 'q');
            Assert.AreEqual(QueenOfHearts.Suit, 'h'); 
        }
    }
}