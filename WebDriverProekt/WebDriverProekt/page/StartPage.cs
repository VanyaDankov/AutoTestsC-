using System;
using OpenQA.Selenium;
using WebDriverProekt.driverSingleTon;

namespace WebDriverProekt
{
    public class StartPage
    {
        private By mailLocator = By.XPath("//a[@data-statlog='headline.mail']");
        private WebDriver driver;
        public StartPage(WebDriver driver)
        {
            this.driver = driver;
        }
        public StartPage()
        {
            driver = DriverSingleTon.getDriver();
        }

        public void openStartPage()
        {
            driver.Navigate().GoToUrl("https://yandex.by/");
        } 
        public MailPage OpenMailPage()
        {
            driver.FindElement(mailLocator).Click();
            foreach (var winHandle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(winHandle);
            }
            return new MailPage(driver);
        }
    }
}
