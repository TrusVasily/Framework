using AngleSharp.Text;
using NUnit.Framework;
using GitHubAutomation.Pages;
using GitHubAutomation.Services;


namespace GitHubAutomation.Tests
{
    [TestFixture]
    public class WebTests : GeneralConfig
    {
        [Test]
        public void Search_Sneackers_ByName_Test()
        {
            const string NAME = "Зеленые Кроссовки New Balance 452";
            var mainPage = new AsosMainPage(Driver);

            mainPage.SearchInput(TestDataReader.GetTestData("sneackerName"));
            mainPage.SearchButtonClick();

            Assert.AreEqual(NAME, mainPage.GetSneackerstitle());
        }

        [Test]
        public void VK_Adress_Test()
        {
            const string URL = "https://vk.com/asos";
            var mainPage = new AsosMainPage(Driver);

            mainPage.VkAdress();

            Assert.AreNotEqual(URL, Driver.PageSource);
        }

        [Test]
        public void Country_Delivery_Test()
        {
            const string LABEL = "УСТАНОВИ СВОИ НАСТРОЙКИ";
            var mainPage = new AsosMainPage(Driver);

            mainPage.CountryDelivery();

            Assert.AreEqual(LABEL, mainPage.GetTitleCountry());
        }

        [Test]
        public void Label_Market_Place_Test()
        {
            const string LABEL = "Help with shopping";
            var mainPage = new AsosMainPage(Driver);
            var marketPlacePage = new MarketPlacePage(Driver);

            mainPage.MarketPlaceClick();
            marketPlacePage.MarketPlaceDdeliveryClick();
            
            Assert.AreNotEqual(LABEL, marketPlacePage.GetLabelMarketPlace());
        }

        [Test]
        public void Registration_Validation_Test()
        {
            const string LABEL = "Ой! Здесь вам надо указать адрес электронной почты";
            var mainPage = new AsosMainPage(Driver);
            var registrationPage = new RegistrationPage(Driver);

            mainPage.UserButtonClick();
            mainPage.RegistrationButtonClick();
            registrationPage.RegistrationButton2Click();
            Assert.AreEqual(LABEL,registrationPage.GetValidation());
        }

        [Test]
        public void Women_Label_Test()
        {
            const string LABEL = "Осень-зима 2019-2020";
            var mainPage = new AsosMainPage(Driver);


            mainPage.WomenButtonClick();

            Assert.AreNotEqual(LABEL, Driver.Title);
        }
    }
}