using NUnit.Framework;
using WebDriverProekt;
using OpenQA.Selenium;
using WebDriverProekt.steps;
using WebDriverProekt.Utils;
using WebDriverProekt.driverSingleTon;
using NUnit.Framework.Interfaces;

namespace WebDriverProjectTest
{
    public class Tests
    {
        private Steps steps = new Steps();
        [SetUp]
        public void Setup()
        {
            steps.initBrowser();

        }
        [TearDown]
        public void Cleanup()
        {
            if ((TestContext.CurrentContext.Result.Outcome == ResultState.Failure) || (TestContext.CurrentContext.Result.Outcome == ResultState.Error))
            {
                DriverSingleTon.createScreenshot();
            }
            steps.CloseBrowser();
        }

        [Test]
        public void LoginTestTrueValue()
        {


            bool result = steps.loginYandex();

            Assert.AreEqual(true, result);
        }
        [Test]
        public void LoginTestFalseValue()
        {
            bool result = steps.LoginYandexFalseValue();

            Assert.AreEqual(false, result);
        }
        [Test]
        public void TestMessege()
        {
            steps.loginYandex();
            string letter = StringUtils.GetRandomString(6);
            steps.WriteLetter("yanusya.tori@yandex.by", letter);
            string result = steps.CheckLetter("yanusya.tori@yandex.by");

            Assert.AreEqual(letter, result);
        }

        [Test]
        public void TestNickname()
        {
            steps.loginYandex();
            steps.openMailPage();
            string switchName = steps.CheckLetter("yanusya.tori@yandex.by");
            string newName = steps.switchNickName(switchName);

            Assert.AreEqual(switchName, newName);
        }
    }
}