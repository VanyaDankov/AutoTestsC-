using System;
using OpenQA.Selenium;
using WebDriverProekt.driverSingleTon;

namespace WebDriverProekt
{
    public class SettingsPage
    {
        private By chengePersonalinfoLocator = By.ClassName("AdditionalPersonalInfo-change");
        private By firstNameLocator = By.XPath("//input[@data-t='field:input-firstname']");
        private By saveLocator = By.XPath("//button[@data-t='button:action']");
        private By getFirstNameLocator = By.XPath("//div[@class='personal-info__first']");
        private WebDriver driver;
        public SettingsPage(WebDriver driver)
        {
            this.driver = driver;
        }
        public SettingsPage()
        {
            driver = DriverSingleTon.getDriver();
        }
        public void setFirstName(string firstName)
        {
            driver.FindElement(chengePersonalinfoLocator).Click();
            driver.FindElement(firstNameLocator).SendKeys("\b\b\b\b\b\b\b\b\b\b\b\b" + firstName);
            driver.FindElement(saveLocator).Click();
        }
        public string getFirstName()
        {
            System.Threading.Thread.Sleep(1000);
            driver.Navigate().Refresh();
            return driver.FindElement(getFirstNameLocator).Text;
        }
    }
}
