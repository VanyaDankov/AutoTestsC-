using System;
using System.Linq;
using OpenQA.Selenium;
using WebDriverProekt.driverSingleTon;

namespace WebDriverProekt
{
    public class MailPage
    { 
        private By writeLetterLocator = By.XPath("//a[@href='#compose']");
        private By receiverLocator = By.ClassName("composeYabbles");
        private By textLetterLocator = By.XPath("//*[@id='cke_1_contents']/div");
        private By userImageLocator = By.XPath("//img[@class='user-pic__image']");
        private By sendLocator = By.XPath("//button[@class='Button2 Button2_pin_circle-circle Button2_view_default Button2_size_l']");
        private By textMessegeLocator = By.CssSelector(".react-message-wrapper__body");
        private By relevantLocator = By.XPath("//a[@href='#tabs/relevant'");
        private By asdb = By.XPath("//div[contains(@class, 'ns - view - messages - item - box')]");
        private By asdbz = By.XPath("//div[contains(@class, 'js - messages - item - checkbox - controller')][1]");
        private By messengeLocator = By.XPath("//div[contains(@class, 'ns-view-messages-item-wrap')]//div[contains(@class, 'ns-view-messages-item-wrap')][1]//span");
        private By MessegeByUserEmeilLocator(string address)
        {
            By messegeByUserEmeilLocator = By.XPath("//span[@title='" + address + "']");//span[@title='yanusya.tori']
            return messegeByUserEmeilLocator;
        }

        private WebDriver driver;
        
        public MailPage(WebDriver driver)
        {
            this.driver = driver;
        }
        public MailPage()
        {
            driver = DriverSingleTon.getDriver();
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
            /* var elements = driver.FindElements(asdb);
             IWebElement messengeelement = null;
             foreach (var element in elements)
             {
               if(element.FindElement(MessegeByUserEmeilLocator(adress)).Displayed) {
                     messengelement = element;
                     break;
                 }
             }
             var messengeelement2 = elements.First(el => el.FindElement(MessegeByUserEmeilLocator(adress)).Displayed);
             var el=driver.FindElement(MessegeByUserEmeilLocator(adress));
             messengeelement2.Click();
             var sabelement = messengeelement2.FindElement(asdbz);
             sabelement.Click();*/
            System.Threading.Thread.Sleep(1000);
            driver.Navigate().Refresh();
            driver.FindElement(MessegeByUserEmeilLocator(adress)).Click();
            driver.FindElement(messengeLocator).Click();
            string messenge = driver.FindElement(textMessegeLocator).Text;
            return driver.FindElement(textMessegeLocator).Text;
        }
        public void OpenRelevant()
        {
            driver.FindElement(relevantLocator).Click();
        }
        public MenuPage OpenMenu()
        {
            driver.FindElement(userImageLocator).Click();
            return new MenuPage(driver);
        }
        public void GoToMessenges()
        {
            driver.Navigate().GoToUrl("https://mail.yandex.by/?uid=1619601330#tabs/relevant");
        }
    }
}
