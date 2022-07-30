using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TideWebsite_NUnit.Driver;
using TideWebsite_NUnit.Utility;

namespace TideWebsite_NUnit.POM
{
    public class ContactUSSectionMethod
    {
        public static IJavaScriptExecutor js;

        public static void NavigateURL()
        {
            DriverMethod.driver.Manage().Window.Maximize();
            DriverMethod.driver.Navigate().GoToUrl(ExcelSheet.excelRead(1, 1));
            LogFourNet.log.Info("URL open in Browser");
        }

        public static void ClickOnButton()
        {
            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            LogFourNet.log.Info("CLose the pop window");

            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//a[contains(text(),'Contact Us')]")).Click();
            LogFourNet.log.Info("Click on ContactUs button");
        }

        public static void TakeScreenShot()
        {
            ScreenShot.TakeScreenshot("ContactUs");
            LogFourNet.log.Info("Takes Screenshot on screen");
        }
    }
}
