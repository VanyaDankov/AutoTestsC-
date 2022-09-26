using System;
using OpenQA.Selenium;
using WebDriverProekt.driverSingleTon;

namespace WebDriverProekt
{
    public class SettingsPage
    {
        private By chengePersonalinfoLocator = By.XPath("//a[@href='/personal?dialog=personal-data']");
        private By firstNameLocator = By.XPath("//div[@data-testid='personal-data-first-name']/span/input[@data-testid='text-field-input']");
        private By saveLocator = By.XPath("//button[@data-testid='personal-data-submit']");
        private By getFirstNameLocator = By.XPath("//div[@data-testid='personal-data-first-name']/span/input[@class='Textinput-Control']");
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
            return driver.FindElement(getFirstNameLocator).GetAttribute("value");
        }
    }
}
