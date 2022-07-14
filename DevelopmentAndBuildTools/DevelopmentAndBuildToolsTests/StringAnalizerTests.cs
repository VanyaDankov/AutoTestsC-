using NUnit.Framework;

namespace DevelopmentAndBuildTools.tests
{
    public class StringAnalizerTest
    {


        [Test]
        public void MaxCountInSeriesDifferentSimbolsZeroTest()
        {
            string str = "";
            int expected = 0;

            int actual = StringAnalizer.MaxCountInSeriesDifferentSimbols(str);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MaxCountInSeriesDifferentSimbolsOneTest()
        {
            string str = "aaaaaaa";
            int expected = 1;

            int actual = StringAnalizer.MaxCountInSeriesDifferentSimbols(str);

            Assert.AreEqual(expected, actual); 
        }

        [Test]
        public void MaxCountInSeriesDifferentSimbolsOneMoreTest()
        {
            string str = "avvvcfsda";
            int expected = 6;

            int actual = StringAnalizer.MaxCountInSeriesDifferentSimbols(str);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MaxCountInSeriesDifferentSimbolsAgainTest()
        {
            string str = "aavasddasdfgh";
            int expected = 7;

            int actual = StringAnalizer.MaxCountInSeriesDifferentSimbols(str);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MaxCountInSeriesNumbersNoOneTest()
        {
            string str = "avvvcfsda";
            int expected = 0;

            int actual = StringAnalizer.MaxCountInSeriesNumbers(str);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MaxCountInSeriesNumbersOneTest()
        {
            string str = "avvvcf1";
            int expected = 1;

            int actual = StringAnalizer.MaxCountInSeriesNumbers(str);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MaxCountInSeriesNumbersOneMoreTest()
        {
            string str = "av11vvc111fsda";
            int expected = 3;

            int actual = StringAnalizer.MaxCountInSeriesNumbers(str);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MaxCountInSeriesLatinSymbolsZeroTest()
        {
            string str = "";
            int expected = 0;

            int actual = StringAnalizer.MaxCountInSeriesLatinSymbols(str);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MaxCountInSeriesLatinSymbolsOneTest()
        {
            string str = "a111111";
            int expected = 1;

            int actual = StringAnalizer.MaxCountInSeriesLatinSymbols(str);

            Assert.AreEqual(expected, actual);
        }

        public void MaxCountInSeriesLatinSymbolsOneMoreTest()
        {
            string str = "aabbb1111111111cccc";
            int expected = 0;

            int actual = StringAnalizer.MaxCountInSeriesLatinSymbols(str);

            Assert.AreEqual(expected, actual);
        }
    }
}