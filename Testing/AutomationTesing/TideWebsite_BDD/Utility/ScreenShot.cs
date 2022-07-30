using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TideWebsite_BDD.Drivers;

namespace TideWebsite_BDD.Utility
{
    public class ScreenShot
    {
        public static void TakeScreenshot(string screenShotName)
        {
            ((ITakesScreenshot)DriverMethod.driver).GetScreenshot()
                .SaveAsFile(@"C:\Users\mindc1may35\Desktop\ComprehensiveAssessment\Testing\AutomationTesing\TideWebsite_BDD\Screenshot\" + screenShotName + ".Png");
        }
    }
}
