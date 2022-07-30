using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TideWebsite_NUnit.Utility
{
    public class ExtentReport
    {
        public static ExtentReports extent;
        public static ExtentTest test;

        public static void generateReport()
        {
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\mindc1may35\Desktop\ComprehensiveAssessment\Testing\AutomationTesing\TideWebsite_NUnit\Index.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        public static void flushReport()
        {
            extent.Flush();
            LogFourNet.log.Info("Extent report stop");
        }
    }
}
