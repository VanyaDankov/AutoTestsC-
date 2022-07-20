using System;
using OpenQA.Selenium;
using WebDriverProekt.service;
using WebDriverProekt.driverSingleTon;

namespace WebDriverProekt.steps
{
    public class Steps
    {
        private WebDriver driver;
        public Steps(WebDriver driver)
        {
           this.driver = driver;
        }
        public Steps()
        {

        }
        public void initBrowser()
        {
            driver = DriverSingleTon.getDriver();
        }
        public void CloseBrowser()
        {
            DriverSingleTon.closeDriver();
        }

        public bool loginYandex()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.login(UserCreator.getFullUser());

            return loginPage.TestLogin();
        }
        public bool LoginYandexFalseValue()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.login(UserCreator.withEmptyUserPassword());

            return loginPage.TestLogin();
        }
        public void WriteLetter(string adress, string letter)
        {
            StartPage startPage = new StartPage(driver);
            MailPage mailPage = startPage.OpenMailPage();
            mailPage.WriteLetter(adress, letter);
        }
        public string CheckLetter(string addres)
        {
            MailPage mailPage = new MailPage(driver);
            return mailPage.CheckLetter("yanusya.tori@yandex.by");
        }
        public string switchNickName(string switchName)
        {
            MailPage mailPage = new MailPage(driver);
            MenuPage menuPage = mailPage.OpenMenu();
            SettingsPage settingsPage = menuPage.OpenSettings();
            settingsPage.setFirstName(switchName);
            return settingsPage.getFirstName();
        }
        public void openMailPage()
        {
            StartPage startPage = new StartPage(driver);
            MailPage mailPage = startPage.OpenMailPage();
        }


    }
}
