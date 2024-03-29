﻿using System;
using OpenQA.Selenium;
using PageObject.driver;

namespace PageObject
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
            driver = DriverSingleton.getDriver();
        }
        public void setFirstName(string firstName)
        {
            driver.FindElement(chengePersonalinfoLocator).Click();
            driver.FindElement(firstNameLocator).SendKeys(firstName);
            driver.FindElement(saveLocator).Click();
        }
        public string getFirstName()
        {
            return driver.FindElement(getFirstNameLocator).Text;
        }
    }
}
