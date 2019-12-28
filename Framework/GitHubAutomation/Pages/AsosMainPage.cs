using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GitHubAutomation.Pages
{
    public class AsosMainPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='chrome-search']")]
        private IWebElement searchLabel { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='chrome-sticky-header']/div[1]/div/div/form/div/button")]
        private IWebElement searchButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='search-term-banner']/p[2]")]
        private IWebElement sneackersLabel { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='chrome-footer']/footer/div[1]/div[1]/div[1]/a[3]")]
        private IWebElement vkButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='chrome-header']/header/div[2]/div/ul/li[3]/div/button")]
        private IWebElement countryButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='country-title']")]
        private IWebElement countryTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='chrome-header']/header/div[2]/div/ul/li[1]/a")]
        private IWebElement marketPlace { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='myAccountDropdown']/button")]
        private IWebElement userButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='myaccount-dropdown']/div/div/div[1]/div/span/a[2]")]
        private IWebElement registrationButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='globalBannerComponent']/div/div/div[1]/a[1]")]
        private IWebElement womenButton { get; set; }

        public AsosMainPage(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public void SearchInput(string str) => searchLabel.SendKeys(str);
        public void SearchButtonClick() => searchButton.Click();
        public string GetSneackerstitle() => sneackersLabel.Text;
        public void VkAdress() => vkButton.Click();
        public void CountryDelivery() => countryButton.Click();
        public string GetTitleCountry() => countryTitle.Text;
        public void MarketPlaceClick() => marketPlace.Click();
        public void UserButtonClick() => userButton.Click();
        public void RegistrationButtonClick() => registrationButton.Click();
        public void WomenButtonClick() => womenButton.Click();

    }
}
