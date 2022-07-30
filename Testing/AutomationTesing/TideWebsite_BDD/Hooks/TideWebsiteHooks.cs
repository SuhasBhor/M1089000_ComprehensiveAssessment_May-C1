using TechTalk.SpecFlow;
using TideWebsite_BDD.Utility;
using TideWebsite_BDD.Drivers;

namespace TideWebsite_BDD.Hooks
{
    [Binding]
    public sealed class TideWebsiteHooks
    {

        [BeforeTestRun]
        public static void beforeTestRun()
        {
            ExtentReport.generateReport();
            LogFourNet.log.Info("Initialize extent report");
        }

        [AfterTestRun]
        public static void afterTestRun()
        {
            ExtentReport.closeReport();
            LogFourNet.log.Info("Close Extent report");
        }

        [BeforeFeature]
        public static void featureBrowser()
        {
            ExtentReport.featureReport();
        }

        [BeforeScenario]
        public static void beforeScenario()
        {
            DriverMethod.InitializeDriver();    
            ExtentReport.scenarioReport();
        }

        [AfterStep]
        public static void afterScenarioSteps()
        {
            ExtentReport.scenarioStepReport();
        }

        [AfterScenario]
        public static void CloseDriver()
        {
            DriverMethod.CloseDriver();
        }
    }
}