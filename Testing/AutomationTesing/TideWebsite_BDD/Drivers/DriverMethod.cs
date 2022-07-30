using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TideWebsite_BDD.Utility;

namespace TideWebsite_BDD.Drivers
{
    public class DriverMethod
    {
        public static IWebDriver driver;

        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
            LogFourNet.log.Info("Driver gets Initialize");
        }

        public static void CloseDriver()
        {
            driver.Close();
            LogFourNet.log.Info("Driver gets Closed");
        }
    }
}
