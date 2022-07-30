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
    public class HowToWashClothesSectionMethod
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
            LogFourNet.log.Info("Pop up window close");

            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//a[contains(text(),'How to Wash Clothes')]")).Click();
            LogFourNet.log.Info("Click on the How to wash clothes");
        }

        public static void ScrollToHowToRemoveStains()
        {
            js = (IJavaScriptExecutor)DriverMethod.driver;
            Thread.Sleep(2000);
            int locationY_OfElement = DriverMethod.driver.FindElement(By.XPath("//p[contains(text(),'How to remove stains')]")).Location.Y;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0, " + locationY_OfElement + ")");
            LogFourNet.log.Info("Scroll to the How to remove Stains");
        }

        public static void ClickOnHowToRemoveStains()
        {
            DriverMethod.driver.FindElement(By.XPath("//p[contains(text(),'How to remove stains')]")).Click();
            LogFourNet.log.Info("Click on the How to remove Stains");
        }

        public static void TakeScreenShot()
        {
            ScreenShot.TakeScreenshot("HowTORemoveStains");
            LogFourNet.log.Info("Takes the screenshot of screen");
        }
    }
}
