using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Mintos.Tests
{
    class SportDirect
    {
        [TestFixture]
        [Parallelizable]
        public class Fixture_1 : TestBase
        {
            [TestCase]
            [Category("Regression"), Category("Functional")]
            public void Test001_Add_Product_To_Card()
            {
                UI.NavigateTo(DRIVER, Settings.BaseURL);
                var main = new MainPage(DRIVER);
                var currentURL = main.VerifyOnCorrectSite();
                var menu = new MenuNavigation(DRIVER);
                menu.FocusMenu("SPORTS")
                    .ClickMenu("ICE_HOCKEY");
                var ice = new IceHockeyPage(DRIVER);
                ice.ClickHockeyBauer();
                Random random = new Random();
                var products = DRIVER.FindElements(By.XPath("//ul[@id='navlist']//a/div/img"));
                int randomNumber = random.Next(0, products.Count);
                products[randomNumber].Click();
                var productName = ice.GetProductName();
                ice.ClickAddToBag();
                ice.ClickBag();
                var bag = new BagPage(DRIVER);
                var productNameInBag = bag.GetProductName();
                Assert.Multiple(() =>
                {
                    StringAssert.AreEqualIgnoringCase("https://lv.sportsdirect.com/", currentURL);
                    StringAssert.AreEqualIgnoringCase("Bauer "+productName, productNameInBag);
                });
            }
        }

    }
}
