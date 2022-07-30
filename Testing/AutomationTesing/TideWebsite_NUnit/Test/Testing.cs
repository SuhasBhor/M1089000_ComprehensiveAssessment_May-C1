using TideWebsite_NUnit.Driver;
using TideWebsite_NUnit.POM;
using TideWebsite_NUnit.Utility;

namespace TideWebsite_NUnit.Test
{
    public class Testing
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ExtentReport.generateReport();
            LogFourNet.log.Info("Initialize Extent report");
        }

        [SetUp]
        public void Setup()
        {
            DriverMethod.InitializeDriver();    
        }

        [Test]
        public void SearchBarTesting()
        {
            ExtentReport.test = ExtentReport.extent.CreateTest("SearchBarTesting");
            SearchBarMethod.NavigateURL();
            SearchBarMethod.ClickOnSearchBar();
            SearchBarMethod.EnterDataInSearchBar();
            SearchBarMethod.TakeScreenShot();
        }

        [Test]
        public void LiveChatSectionTesting()
        {
            ExtentReport.test = ExtentReport.extent.CreateTest("LiveChatSectionTesting");
            LiveChatPageMethod.NavigateURL();
            LiveChatPageMethod.ClickOnLiveChat();
            LiveChatPageMethod.ScrollToLiveChat();
            LiveChatPageMethod.TakeScreenshot();    
        }

        [Test]
        public void HomeScreenLanguageSectionTesting()
        {
            ExtentReport.test = ExtentReport.extent.CreateTest("HomeScreenLanguageSectionTesting");
            HomeScreenLanguageMethod.NavigateURL();
            HomeScreenLanguageMethod.ClickOnButton();
            HomeScreenLanguageMethod.SelectLanguage();
            HomeScreenLanguageMethod.TakeScreenShot();
        }

        [Test]
        public void ContactUsSectionTesting()
        {
            ExtentReport.test = ExtentReport.extent.CreateTest("ContactUsSectionTesting");
            ContactUSSectionMethod.NavigateURL();
            ContactUSSectionMethod.ClickOnButton();
            ContactUSSectionMethod.TakeScreenShot();
        }

        [Test]
        public void ShopProductsSectionTesting()
        {
            ExtentReport.test = ExtentReport.extent.CreateTest("ShopProductsSectionTesting");
            ShopProductsSectionMethod.NavigateURL();
            ShopProductsSectionMethod.ClickOnButton();
            ShopProductsSectionMethod.SelectProduct();
            ShopProductsSectionMethod.ClickOnFindRetailers();
            ShopProductsSectionMethod.TakeScreenShot();
        }

        [Test]
        public void OurCommitmentSectionTesting()
        {
            ExtentReport.test = ExtentReport.extent.CreateTest("OurCommitmentSectionTesting");
            OurCommitmentSectionMethod.NavigateURL();
            OurCommitmentSectionMethod.ClickOnButton();
            OurCommitmentSectionMethod.ScrollToElement();
            OurCommitmentSectionMethod.ClickOnElement();
            OurCommitmentSectionMethod.TakeScreenShot();
        }

        [Test]
        public void HowToWashClothesSectionTesting()
        {
            ExtentReport.test = ExtentReport.extent.CreateTest("HowToWashClothesSectionTesting");
            HowToWashClothesSectionMethod.NavigateURL();
            HowToWashClothesSectionMethod.ClickOnButton();
            HowToWashClothesSectionMethod.ScrollToHowToRemoveStains();
            HowToWashClothesSectionMethod.ClickOnHowToRemoveStains();
            HowToWashClothesSectionMethod.TakeScreenShot();
        }

        [Test]
        public void WhatsNewSectionTesting()
        {
            ExtentReport.test = ExtentReport.extent.CreateTest("WhatsNewSectionTesting");
            WhatsNewSectionMethod.NavigateURL();
            WhatsNewSectionMethod.ClickOnWhatsNewButton();
            WhatsNewSectionMethod.ClickOnLatestArticles();
            WhatsNewSectionMethod.TakeScreenShot();
        }

        [Test]
        public void CouponAndRewardsSectionTesting()
        {
            ExtentReport.test = ExtentReport.extent.CreateTest("CouponAndRewardsSectionTesting");
            CouponAndRewardsSectionMethod.NavigateURL();
            CouponAndRewardsSectionMethod.ClickOnCouponAndReward();
            CouponAndRewardsSectionMethod.TakeScreenShot();
        }

        [Test]
        public void RegisterSectionTesting()
        {
            ExtentReport.test = ExtentReport.extent.CreateTest("RegisterSectionTesting");
            RegisterSectionMethod.NavigateURL();
            RegisterSectionMethod.ClickOnRegister();
            RegisterSectionMethod.ClickOnSignUpNow();
            RegisterSectionMethod.TakeScreenShot();
        }

        [TearDown]
        public void TearDown()
        {
            DriverMethod.CloseDriver();
            ExtentReport.flushReport();
        }
    }
}