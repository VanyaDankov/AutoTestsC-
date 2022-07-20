using System;
using OpenQA.Selenium;
using PageObject.driver;

namespace PageObject
{
    public class StartPage
    {
        private By mailLocator = By.XPath("//a[@data-statlog='notifications.mail.login.inbox.unread']");
        private WebDriver driver;
        public StartPage(WebDriver driver)
        {
            this.driver = driver;
        }
        public StartPage()
        {
            driver = DriverSingleton.getDriver();
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
