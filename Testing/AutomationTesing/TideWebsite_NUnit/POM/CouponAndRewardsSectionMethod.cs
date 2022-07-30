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
    public class CouponAndRewardsSectionMethod
    {
        public static void NavigateURL()
        {
            DriverMethod.driver.Manage().Window.Maximize();
            DriverMethod.driver.Navigate().GoToUrl(ExcelSheet.excelRead(1, 1));
            LogFourNet.log.Info("URL gets open in browser");
        }

        public static void ClickOnCouponAndReward()
        {
            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            LogFourNet.log.Info("Pop up window close");

            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//a[contains(text(),'Coupons and Rewards')]")).Click();
            LogFourNet.log.Info("Click on coupon and reward option");
        }

        public static void TakeScreenShot()
        {
            ScreenShot.TakeScreenshot("CouponsAndRewards");
            LogFourNet.log.Info("Takes screenshot of the screen");
        }
    }
}
