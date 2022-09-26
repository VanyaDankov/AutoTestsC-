using System;
using OpenQA.Selenium;
using WebDriverProekt.driverSingleTon;

namespace WebDriverProekt
{
    public class LoginPage
    {
        By loginButtonLocator = By.XPath("//button[@class='resplash-btn resplash-btn_primary resplash-btn_mailbox-big svelte-10ugt9f']");
        By userNameLocator = By.XPath("//input[@data-t='field:input-login']");
        By passwordLocator = By.XPath("//input[@id='passp-field-passwd']");
        By switchAccountLocator = By.XPath("//a[@class='CurrentAccount']");
        By addAccountButtonLocator = By.XPath("//span[@class='AddAccountButton-text']");
        By testLoginLocator = By.XPath("//div[@class='search3__input-wrapper']");

        private WebDriver driver;
        public LoginPage(WebDriver driver)
        {
            this.driver = driver;
        }
        public LoginPage()
        {
            driver = DriverSingleTon.getDriver();
            driver.Navigate().GoToUrl("https://passport.yandex.by/auth?origin=home_yandexid&retpath=https%3A%2F%2Fyandex.by&backpath=https%3A%2F%2Fyandex.by");
        }
        public void NavigateTo()
        {
            driver.Navigate().GoToUrl("https://passport.yandex.by/auth?origin=home_yandexid&retpath=https%3A%2F%2Fyandex.by&backpath=https%3A%2F%2Fyandex.by");
        }
        public void LoginButtonType()
        {
            
            driver.FindElement(loginButtonLocator).Click();
        }
        public void EnterUserName(string userName)
        {
            driver.FindElement(userNameLocator).SendKeys(userName + Keys.Enter);
        }

        public StartPage EnterPassword(string password)
        {

            driver.FindElement(passwordLocator).SendKeys(password + Keys.Enter);
            return new StartPage(driver);
        }
        public StartPage login(model.User user)
        {
            EnterUserName(user.UserName);
            return EnterPassword(user.UserPassword);
        }
        public bool TestLogin()
        {
            try
            {
                driver.FindElement(testLoginLocator);
                return true;
            }
            catch(NoSuchElementException e)
            {
                return false;
            }
        }
    }
}
