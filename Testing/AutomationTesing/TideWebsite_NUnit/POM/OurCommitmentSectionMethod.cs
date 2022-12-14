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
    public class OurCommitmentSectionMethod
    {
        public static IJavaScriptExecutor js;
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
            LogFourNet.log.Info("Popup window closed");
            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//a[contains(text(),'Our Commitment')]")).Click();
            LogFourNet.log.Info("Click on Our Commitment");
        }

        public static void ScrollToElement()
        {
            js = (IJavaScriptExecutor)DriverMethod.driver;
            Thread.Sleep(2000);
            int locationY_OfElement = DriverMethod.driver.FindElement(By.XPath("//p[contains(text(),'Our Ambition')]")).Location.Y;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0, " + locationY_OfElement + ")");
            LogFourNet.log.Info("Scroll to the Our Ambition");
        }

        public static void ClickOnElement()
        {
            DriverMethod.driver.FindElement(By.XPath("//p[contains(text(),'Our Ambition')]")).Click();
            LogFourNet.log.Info("Click on Our Ambition");
        }

        public static void TakeScreenShot()
        {
            ScreenShot.TakeScreenshot("OurAmbition");
            LogFourNet.log.Info("Takes the screenshot of screen");
        }

    }
}
