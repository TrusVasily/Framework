using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GitHubAutomation.Pages
{
    public class RegistrationPage
    {
        
        [FindsBy(How = How.XPath, Using = "//*[@id='register']")]
        private IWebElement registrationButton2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='Email-error']")]
        private IWebElement validationLabel { get; set; }

        public RegistrationPage(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }
        public void RegistrationButton2Click() => registrationButton2.Click();
        public string GetValidation() => validationLabel.Text;
    }
}
