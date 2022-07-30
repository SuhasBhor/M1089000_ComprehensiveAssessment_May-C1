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
    public class SearchBarMethod
    {
        public static void NavigateURL()
        {
            DriverMethod.driver.Manage().Window.Maximize();
            DriverMethod.driver.Navigate().GoToUrl(ExcelSheet.excelRead(1, 1));
            LogFourNet.log.Info("URL gets open in browser");
        }

        public static void ClickOnSearchBar()
        {
            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            LogFourNet.log.Info("Popup closed");

            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//input[@type='search']")).Click();
            LogFourNet.log.Info("Click on the search bar");
        }

        public static void EnterDataInSearchBar()
        {
            IWebElement searchBarElement = DriverMethod.driver.FindElement(By.XPath("//input[@type='search']"));
            searchBarElement.SendKeys("Powder");
            searchBarElement.SendKeys(Keys.Enter);
            LogFourNet.log.Info("Enter data into search bar");
        }

        public static void TakeScreenShot()
        {
            Thread.Sleep(2000);
            ScreenShot.TakeScreenshot("Search Result");
            LogFourNet.log.Info("Takes the screenshot of the screen");
        }
    }
}