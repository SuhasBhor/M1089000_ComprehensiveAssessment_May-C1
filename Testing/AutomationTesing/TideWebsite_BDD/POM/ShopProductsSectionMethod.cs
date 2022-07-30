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
    public class ShopProductsSectionMethod
    {

        public static void NavigateURL()
        {
            DriverMethod.driver.Manage().Window.Maximize();
            DriverMethod.driver.Navigate().GoToUrl(ExcelSheet.excelRead(1, 1));
            LogFourNet.log.Info("URL open in the browser");
        }

        public static void ClickOnButton()
        {
            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            LogFourNet.log.Info("Popup Closed");
            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath(" //a[contains(text(),'Shop Products')]")).Click();
            LogFourNet.log.Info("Click on shop products");
        }

        public static void SelectProduct()
        {
            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//strong[contains(text(),'Clean Breeze Powder')]")).Click();
            LogFourNet.log.Info("Select the Product");
        }

        public static void ClickOnFindRetailers()
        {
            DriverMethod.driver.FindElement(By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[1]/div[1]/div[2]/div")).Click();
            LogFourNet.log.Info("Click on the find retailer button");
        }

        public static void TakeScreenShot()
        {
            ScreenShot.TakeScreenshot("Retailer");
            LogFourNet.log.Info("Takes screenshot of the screen");
        }
    }
}
