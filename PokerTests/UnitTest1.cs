using NUnit.Framework;
using PokerHandClassifier;

namespace PokerTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AmountTest1()
        {
            var checkCards = new CardsChecker();
            string testCards = "AS, 10C, 10C, 3D, 3S";
            string[] testCardArray = testCards.ToUpper().Split(',');

            try
            {
                checkCards.VerifyAmount(testCardArray);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [Test]
        public void AmountTest2()
        {
            var checkCards = new CardsChecker();
            string testCards = "AS, 10C, 3D, 3S";
            string[] testCardArray = testCards.ToUpper().Split(',');

            try
            {
                checkCards.VerifyAmount(testCardArray);
            }
            catch
            {
                Assert.Pass();
            }
        }

        [Test]
        public void SuitTest1()
        {
            var checkCards = new CardsChecker();
            string testCards = "AS, 10C, 10C, 3D, 3S";
            string[] testCardArray = testCards.ToUpper().Split(',');

            try
            {
                checkCards.VerifySuit(testCardArray);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [Test]
        public void SuitTest2()
        {
            var checkCards = new CardsChecker();
            string testCards = "AS, 10C, 10C, 3X, 3S";
            string[] testCardArray = testCards.ToUpper().Split(',');

            try
            {
                checkCards.VerifySuit(testCardArray);
            }
            catch
            {
                Assert.Pass();
            }
        }

        [Test]
        public void ValueTest1()
        {
            var checkCards = new CardsChecker();
            string testCards = "AS, 10C, 10C, KD, 3S";
            string[] testCardArray = testCards.ToUpper().Split(',');

            try
            {
                checkCards.VerifySuit(testCardArray);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [Test]
        public void ValueTest2()
        {
            var checkCards = new CardsChecker();
            string testCards = "AS, 12C, 10C, 3X, 3S";
            string[] testCardArray = testCards.ToUpper().Split(',');

            try
            {
                checkCards.VerifySuit(testCardArray);
            }
            catch
            {
                Assert.Pass();
            }
        }
        [Test]
        public void ValueTest3()
        {
            var checkCards = new CardsChecker();
            string testCards = "AS, 10C, BC, 3X, 3S";
            string[] testCardArray = testCards.ToUpper().Split(',');

            try
            {
                checkCards.VerifySuit(testCardArray);
            }
            catch
            {
                Assert.Pass();
            }
        }

        [Test]
        public void DuplicateTest1()
        {
            var checkCards = new CardsChecker();
            string testCards = "AS, 10C, 10C, KD, 3S";
            string[] testCardArray = testCards.ToUpper().Split(',');

            try
            {
                checkCards.VerifySuit(testCardArray);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [Test]
        public void DuplicateTest2()
        {
            var checkCards = new CardsChecker();
            string testCards = "AS, AS, 10C, KD, 3S";
            string[] testCardArray = testCards.ToUpper().Split(',');

            try
            {
                checkCards.VerifySuit(testCardArray);
            }
            catch
            {
                Assert.Pass();
            }
        }
    }
}