using System;
using OpenQA.Selenium;
using PageObject.driver;

namespace PageObject
{
    public class MailPage
    {
        private By writeLetterLocator = By.XPath("//a[@href='#compose']");
        private By receiverLocator = By.ClassName("composeYabbles");
        private By textLetterLocator = By.XPath("//*[@id='cke_1_contents']/div");
        private By userImageLocator = By.XPath("//a[@data-statlog='notifications.mail.login.usermenu.toggle-icon']");
        private By sendLocator = By.XPath("//button[@class='Button2 Button2_pin_circle-circle Button2_view_default Button2_size_l']");
        private By textMessegeLocator = By.XPath("//div[@class='react-message-wrapper__body']");
        private By relevantLocator = By.XPath("//a[@href='#tabs/relevant'");

        private By MessegeByUserEmeilLocator(string address)
        {
            By messegeByUserEmeilLocator = By.XPath("//span[@title='"+address+"']");
            return messegeByUserEmeilLocator;
        }

        private WebDriver driver;
        
        public MailPage(WebDriver driver)
        {
            this.driver = driver;
        }
        public MailPage()
        {
            driver = DriverSingleton.getDriver();
        }
        public void WriteLetter(string adressReceiver, string textLetter)
        {
            driver.FindElement(writeLetterLocator).Click();
            driver.FindElement(receiverLocator).SendKeys(adressReceiver);
            driver.FindElement(textLetterLocator).SendKeys(textLetter);
            driver.FindElement(sendLocator).Click();
        }
        public string CheckLetter(string adress)
        {
            driver.FindElement(MessegeByUserEmeilLocator(adress)).Click();
            return driver.FindElement(textMessegeLocator).Text;
        }
        public MenuPage OpenMenu()
        {
            driver.FindElement(userImageLocator).Click();
            return new MenuPage(driver);
        }

    }
}
