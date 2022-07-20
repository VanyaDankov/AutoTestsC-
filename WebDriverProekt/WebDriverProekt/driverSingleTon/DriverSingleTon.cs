using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriverProekt.driverSingleTon
{
    public static class DriverSingleTon
    {
        private static WebDriver driver;
        public static WebDriver getDriver()
        {
            if(driver == null)
            {
                driver = new ChromeDriver();
                TimeSpan timeSpan = new TimeSpan(300000000);
                driver.Manage().Timeouts().ImplicitWait = timeSpan;
                driver.Manage().Window.Maximize();
            }
            return driver;
        }
        public static void closeDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
        public static void createScreenshot()
        {
            if (driver != null)
            {
                driver.GetScreenshot().SaveAsFile(DateTime.Now.ToString() + ".jpeg", ScreenshotImageFormat.Jpeg);
            }
        }
    }
}
