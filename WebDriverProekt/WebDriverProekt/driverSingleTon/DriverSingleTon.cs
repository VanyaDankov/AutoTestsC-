using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverProekt.Utils;

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
                TimeSpan timeSpan = new TimeSpan(100000000);
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
            if (driver != null) //Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources")+"/"+ 
            {
                if (!Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources")))
                    Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources"));
                //driver.GetScreenshot().SaveAsFile(DateTime.Now.ToString("HH:mm:ss") + ".jpeg", ScreenshotImageFormat.Jpeg);
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources") + "/" + StringUtils.DataToFile() + ".png",
                //ss.SaveAsFile(@"D:\scr\Image.png",
                ScreenshotImageFormat.Png);
            }
            
        }
    }
}
