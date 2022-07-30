using System;
using TechTalk.SpecFlow;
using TideWebsite_BDD.POM;

namespace TideWebsite_BDD.StepDefinitions
{
    [Binding]
    public class TideWebsiteStepDefinitions
    {
        [Given(@"Load the website for ContactUs")]
        public void GivenLoadTheWebsiteForContactUs()
        {
            ContactUSSectionMethod.NavigateURL();
        }

        [When(@"website load click on the contact us")]
        public void WhenWebsiteLoadClickOnTheContactUs()
        {
            ContactUSSectionMethod.ClickOnButton(); 
        }

        [Then(@"Take screenshot of screen")]
        public void ThenTakeScreenshotOfScreen()
        {
            ContactUSSectionMethod.TakeScreenShot();    
        }

        [Given(@"Load the website for CouponAndRewards")]
        public void GivenLoadTheWebsiteForCouponAndRewards()
        {
            CouponAndRewardsSectionMethod.NavigateURL();
        }

        [When(@"website load click on the Coupon and Rewards")]
        public void WhenWebsiteLoadClickOnTheCouponAndRewards()
        {
            CouponAndRewardsSectionMethod.ClickOnCouponAndReward();
        }

        [Then(@"Coupon and Rewards section display")]
        public void ThenCouponAndRewardsSectionDisplay()
        {
            CouponAndRewardsSectionMethod.VerifyCouponsAndRewards();
        }

        [Then(@"Take Screenshot of Coupon and Rewards screen")]
        public void ThenTakeScreenshotOfCouponAndRewardsScreen()
        {
            CouponAndRewardsSectionMethod.TakeScreenShot();
        }

        [Given(@"Load the website for HomeScreenLanguage")]
        public void GivenLoadTheWebsiteForHomeScreenLanguage()
        {
           HomeScreenLanguageMethod.NavigateURL();
        }

        [When(@"website load click on the Language")]
        public void WhenWebsiteLoadClickOnTheLanguage()
        {
            HomeScreenLanguageMethod.ClickOnButton();
        }

        [Then(@"Popup should open and choose Language")]
        public void ThenPopupShouldOpenAndChooseLanguage()
        {
            HomeScreenLanguageMethod.SelectLanguage();
        }

        [Then(@"Take screenshot of Changed home language screen")]
        public void ThenTakeScreenshotOfChangedHomeLanguageScreen()
        {
            HomeScreenLanguageMethod.TakeScreenShot();
        }

        [Given(@"Load the website for HowToWashClothes")]
        public void GivenLoadTheWebsiteForHowToWashClothes()
        {
            HowToWashClothesSectionMethod.NavigateURL();
        }

        [When(@"website load Click on How to wash clothes")]
        public void WhenWebsiteLoadClickOnHowToWashClothes()
        {
            HowToWashClothesSectionMethod.ClickOnButton();
        }

        [Then(@"scroll to how to remove stains")]
        public void ThenScrollToHowToRemoveStains()
        {
            HowToWashClothesSectionMethod.ScrollToHowToRemoveStains();
        }

        [Then(@"click on the how to remove stains")]
        public void ThenClickOnTheHowToRemoveStains()
        {
            HowToWashClothesSectionMethod.ClickOnHowToRemoveStains();
        }

        [Then(@"Take screenshot of how to remove statins screen")]
        public void ThenTakeScreenshotOfHowToRemoveStatinsScreen()
        {
            HowToWashClothesSectionMethod.TakeScreenShot();
        }

        [Given(@"Load the website for LiveChat")]
        public void GivenLoadTheWebsiteForLiveChat()
        {
            LiveChatPageMethod.NavigateURL();
        }

        [When(@"website load click on live chat")]
        public void WhenWebsiteLoadClickOnLiveChat()
        {
            LiveChatPageMethod.ClickOnLiveChat();
        }

        [Then(@"scroll to live chat")]
        public void ThenScrollToLiveChat()
        {
            LiveChatPageMethod.ScrollToLiveChat();
        }

        [Then(@"Take Screenshot of Live Chat screen")]
        public void ThenTakeScreenshotOfLiveChatScreen()
        {
            LiveChatPageMethod.TakeScreenshot();
        }

        [Given(@"Load the website for OurCommitment")]
        public void GivenLoadTheWebsiteForOurCommitment()
        {
            OurCommitmentSectionMethod.NavigateURL();
        }

        [When(@"website load click on Our Commitment")]
        public void WhenWebsiteLoadClickOnOurCommitment()
        {
            OurCommitmentSectionMethod.ClickOnButton();
        }

        [Then(@"Scroll to Our Ambition")]
        public void ThenScrollToOurAmbition()
        {
            OurCommitmentSectionMethod.ScrollToElement();
        }

        [Then(@"Click on Our Ambition")]
        public void ThenClickOnOurAmbition()
        {
            OurCommitmentSectionMethod.ClickOnElement();
        }

        [Then(@"Take screenshot of our ambition screen")]
        public void ThenTakeScreenshotOfOurAmbitionScreen()
        {
            OurCommitmentSectionMethod.TakeScreenShot();
        }

        [Given(@"Load the website for Register")]
        public void GivenLoadTheWebsiteForRegister()
        {
            RegisterSectionMethod.NavigateURL();
        }

        [When(@"website load click on Register")]
        public void WhenWebsiteLoadClickOnRegister()
        {
            RegisterSectionMethod.ClickOnRegister();
        }

        [Then(@"Click on Sign Up Now")]
        public void ThenClickOnSignUpNow()
        {
            RegisterSectionMethod.ClickOnSignUpNow();
        }

        [Then(@"Take screenshot of Sign up screen")]
        public void ThenTakeScreenshotOfSignUpScreen()
        {
            RegisterSectionMethod.TakeScreenShot();
        }

        [Given(@"Load the website for SearchBar")]
        public void GivenLoadTheWebsiteForSearchBar()
        {
            SearchBarMethod.NavigateURL();
        }

        [When(@"website load click on Search bar")]
        public void WhenWebsiteLoadClickOnSearchBar()
        {
            SearchBarMethod.ClickOnSearchBar();
        }

        [Then(@"enter data in search bar")]
        public void ThenEnterDataInSearchBar()
        {
            SearchBarMethod.EnterDataInSearchBar();
        }

        [Then(@"Take screenshot of Displayed Result screen")]
        public void ThenTakeScreenshotOfDisplayedResultScreen()
        {
            SearchBarMethod.TakeScreenShot();
        }

        [Given(@"Load the website for ShopProducts")]
        public void GivenLoadTheWebsiteForShopProducts()
        {
            ShopProductsSectionMethod.NavigateURL();    
        }

        [When(@"website load click on shop products")]
        public void WhenWebsiteLoadClickOnShopProducts()
        {
            ShopProductsSectionMethod.ClickOnButton();
        }

        [Then(@"Select any product")]
        public void ThenSelectAnyProduct()
        {
           ShopProductsSectionMethod.SelectProduct();
        }

        [Then(@"click on find retailers")]
        public void ThenClickOnFindRetailers()
        {
            ShopProductsSectionMethod.ClickOnFindRetailers();
        }

        [Then(@"Take screenshot of Retailers screen")]
        public void ThenTakeScreenshotOfRetailersScreen()
        {
            ShopProductsSectionMethod.TakeScreenShot();
        }

        [Given(@"Load the website for WhatsNew")]
        public void GivenLoadTheWebsiteForWhatsNew()
        {
            WhatsNewSectionMethod.NavigateURL();
        }

        [When(@"website load click on the whats new")]
        public void WhenWebsiteLoadClickOnTheWhatsNew()
        {
            WhatsNewSectionMethod.ClickOnWhatsNewButton();
        }

        [Then(@"click on latest articles")]
        public void ThenClickOnLatestArticles()
        {
            WhatsNewSectionMethod.ClickOnLatestArticles();
        }

        [Then(@"Take screenshot of latest articles screen")]
        public void ThenTakeScreenshotOfLatestArticlesScreen()
        {
            WhatsNewSectionMethod.TakeScreenShot();
        }
    }
}
