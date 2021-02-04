using OpenQA.Selenium;


namespace Mintos.Tests

{
    public class IceHockeyPage
    {
        #region locators
        private By iHAccessories = By.LinkText("Ice Hockey Accessories");
        private By iHABauer = By.LinkText("Bauer");
        private By btnAddToBag = By.Id("aAddToBag");
        private By btnBag = By.Id("bagQuantityContainer");
        private By txtProdName = By.Id("lblProductName");

        #endregion
        public IceHockeyPage(IWebDriver driver)
        { pageDriver = driver; }

        public IWebDriver pageDriver { get; }

        public void ClickHockeyAccessories()
        {
            UI.ClickElement(pageDriver, iHAccessories);
        }
        public void ClickHockeyBauer()
        {
            UI.ClickElement(pageDriver, iHABauer);
        }

        public string GetProductName()
        {
            UI.WaitForElementVisible(pageDriver, txtProdName);
            return UI.GetText(pageDriver.FindElement(txtProdName));
        }

        public void ClickAddToBag()
        {
            UI.ClickElement(pageDriver, btnAddToBag);
        }

        public void ClickBag()
        {
            UI.ClickElement(pageDriver, btnBag);
        }
    }
}