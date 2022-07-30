Feature: TideWebsite
As a user I want to check Tide Website functionality 

@ContactUS
Scenario: Verify ContactUs Section
	Given Load the website for ContactUs
	When website load click on the contact us 
	Then Take screenshot of screen

@CouponAndRewards
Scenario: Verify Coupon And Rewards Section
	Given Load the website for CouponAndRewards
	When website load click on the Coupon and Rewards 
	Then Coupon and Rewards section display
	And Take Screenshot of Coupon and Rewards screen

@HomeScreenLanguage
Scenario: Verify Home Screen Language Section
	Given Load the website for HomeScreenLanguage
	When website load click on the Language 
	Then Popup should open and choose Language
	And Take screenshot of Changed home language screen

@HowToWashClothes
Scenario: Verify How to wash clothes section
	Given Load the website for HowToWashClothes
	When website load Click on How to wash clothes 
	Then scroll to how to remove stains
	And click on the how to remove stains
	And Take screenshot of how to remove statins screen

@LiveChat
Scenario: Verify Live Chat Section
	Given Load the website for LiveChat
	When website load click on live chat 
	Then scroll to live chat
	And Take Screenshot of Live Chat screen 

@OurCommitment
Scenario: Verify Our Commitment Section
	Given Load the website for OurCommitment
	When website load click on Our Commitment
	Then Scroll to Our Ambition
	And Click on Our Ambition
	And Take screenshot of our ambition screen

@Register
Scenario: Verify Register section
	Given Load the website for Register
	When website load click on Register
	Then Click on Sign Up Now 
	And Take screenshot of Sign up screen

@SearchBar
Scenario: Verify Search Bar 
	Given Load the website for SearchBar
	When website load click on Search bar
	Then enter data in search bar
	And Take screenshot of Displayed Result screen

@ShopProducts
Scenario: Verify Shop products Section	
	Given Load the website for ShopProducts
	When website load click on shop products
	Then Select any product
	And click on find retailers 
	And Take screenshot of Retailers screen

@WhatsNew
Scenario: Verify Whats New Section
	Given Load the website for WhatsNew
	When website load click on the whats new 
	Then click on latest articles
	And Take screenshot of latest articles screen