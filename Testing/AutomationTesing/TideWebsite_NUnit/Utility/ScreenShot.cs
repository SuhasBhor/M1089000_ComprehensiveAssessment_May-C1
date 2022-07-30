using OpenQA.Selenium;
using TideWebsite_NUnit.Driver;

namespace TideWebsite_NUnit.Utility
{
    public class ScreenShot
    {
        public static void TakeScreenshot(string screenShotName)
        {
            ((ITakesScreenshot)DriverMethod.driver).GetScreenshot()
                .SaveAsFile(@"C:\Users\mindc1may35\Desktop\ComprehensiveAssessment\Testing\AutomationTesing\TideWebsite_NUnit\Screenshot\" + screenShotName + ".Png");
        }
    }
}
