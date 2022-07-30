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
    public class RegisterSectionMethod
    {
        public static IJavaScriptExecutor js;
        public static void NavigateURL()
        {
            DriverMethod.driver.Manage().Window.Maximize();
            DriverMethod.driver.Navigate().GoToUrl(ExcelSheet.excelRead(1, 1));
            LogFourNet.log.Info("URL gets open in browser");
        }

        public static void ClickOnRegister()
        {
            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            LogFourNet.log.Info("PopUp closed");

            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//a[contains(text(),'Register')]")).Click();
            LogFourNet.log.Info("Click on the Register button");
        }

        public static void ClickOnSignUpNow()
        {
            DriverMethod.driver.FindElement(By.XPath("//a[contains(text(),'Sign up now')]")).Click();
            LogFourNet.log.Info("Click on Sign up now button");
        }

        internal static void TakeScreenShot()
        {
            ScreenShot.TakeScreenshot("RegisterPage");
            LogFourNet.log.Info("Takes the screenshot of screen");
        }
    }
}