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
    public class LiveChatPageMethod
    {
        public static IJavaScriptExecutor js;
        public static void NavigateURL()
        {
            DriverMethod.driver.Manage().Window.Maximize();
            DriverMethod.driver.Navigate().GoToUrl(ExcelSheet.excelRead(1, 1));
            LogFourNet.log.Info("URL open in browser");
        }

        public static void ClickOnLiveChat()
        {
            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            LogFourNet.log.Info("PopUp closed");

            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//a[contains(text(),'Live Chat')]")).Click();
            LogFourNet.log.Info("Click on the LiveChat button");
        }

        public static void ScrollToLiveChat()
        {
            js = (IJavaScriptExecutor)DriverMethod.driver;
            Thread.Sleep(2000);
            int locationY_OfElement = DriverMethod.driver.FindElement(By.XPath("//ul[@class='breadcrumbs-list']")).Location.Y;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0, " + locationY_OfElement + ")");
            LogFourNet.log.Info("Scroll to the How to Live chat");
        }

        public static void TakeScreenshot()
        {
            ScreenShot.TakeScreenshot("LiveChatSection");
            LogFourNet.log.Info("Takes the screenshot of screen");
        }
    }
}
