using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TideWebsite_BDD.Drivers;
using TideWebsite_BDD.Utility;

namespace TideWebsite_BDD.POM
{
    public class HomeScreenLanguageMethod
    {

        public static void NavigateURL()
        {
            DriverMethod.driver.Manage().Window.Maximize();
            DriverMethod.driver.Navigate().GoToUrl(ExcelSheet.excelRead(1, 1));
            LogFourNet.log.Info("URL gets open in browser");
        }

        public static void ClickOnButton()
        {
            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            LogFourNet.log.Info("Pop up window close");

            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//button[contains(text(), 'US - English')]")).Click();
            LogFourNet.log.Info("Click on the Select location button");
        }

        public static void SelectLanguage()
        {
            DriverMethod.driver.FindElement(By.XPath("//a[contains(text(),'US - Spanish')]")).Click();
            LogFourNet.log.Info("Choose the language");
        }

        public static void TakeScreenShot()
        {
            ScreenShot.TakeScreenshot("HomeScreenChangedLanguage");
            LogFourNet.log.Info("Takes the screenshot of screen");
        }
    }
}
