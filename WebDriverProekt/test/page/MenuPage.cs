using System;
using OpenQA.Selenium;
using PageObject.driver;

namespace PageObject
{
    public class MenuPage
    {
        private By userImageLocator = By.XPath("//a[@data-statlog='notifications.mail.login.usermenu.toggle-icon']");
        private By settingsLocator = By.XPath("//a[@data-statlog='mail.login.usermenu.passport']");
        private By exitLocator = By.XPath("//a[@data-statlog='mail.login.usermenu.exit']");

        WebDriver driver;
        public MenuPage(WebDriver driver)
        {
            this.driver = driver;
        }

        public MenuPage()
        {
            driver = DriverSingleton.getDriver();
        }
        public LoginPage ExitAccount()
        {
            driver.FindElement(exitLocator).Click();
            return new LoginPage(driver);
        }
        public SettingsPage OpenSettings()
        {
            driver.FindElement(settingsLocator).Click();
            return new SettingsPage(driver);
        }
    }
}
