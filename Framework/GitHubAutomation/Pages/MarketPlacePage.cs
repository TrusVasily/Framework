using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GitHubAutomation.Pages
{
    public class MarketPlacePage
    {

        [FindsBy(How = How.XPath, Using = "//*[@id='react_0HLSB8V7A95OR']/footer/div[1]/div[2]/ul/li[1]/a")]
        private IWebElement marketPlaceDeliveryButton { get; set; }

        
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/h1")]
        private IWebElement labelDeliveryItem { get; set; }

        public MarketPlacePage(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public void MarketPlaceDdeliveryClick() => marketPlaceDeliveryButton.Click();
        public string GetLabelMarketPlace() => labelDeliveryItem.Text;
    }
}
