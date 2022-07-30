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
    public class WhatsNewSectionMethod
    {
        public static void NavigateURL()
        {
            DriverMethod.driver.Manage().Window.Maximize();
            DriverMethod.driver.Navigate().GoToUrl(ExcelSheet.excelRead(1, 1));
            LogFourNet.log.Info("URL open in the browser");
        }

        public static void ClickOnWhatsNewButton()
        {
            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            LogFourNet.log.Info("Popup closed");

            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[3]/div/div/div/div[4]/a")).Click();
            LogFourNet.log.Info("Click on the What's new ");
        }

        public static void ClickOnLatestArticles()
        {
            DriverMethod.driver.FindElement(By.XPath("//span[contains(text(),'Latest Articles')]")).Click();
            LogFourNet.log.Info("Click on the Latest Articles");
        }

        public static void TakeScreenShot()
        {
            ScreenShot.TakeScreenshot("LatestArticles");
            LogFourNet.log.Info("Takes screenshot of the screen");
        }
    }
}
