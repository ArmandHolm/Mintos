using OpenQA.Selenium;


namespace Mintos.Tests

{
    public class BagPage
    {
        #region locators
        private By txtProductName = By.Id("dhypProductLink");


        #endregion
        public BagPage(IWebDriver driver)
        { pageDriver = driver; }

        public IWebDriver pageDriver { get; }

        public string GetProductName()
        {
            UI.WaitForElementVisible(pageDriver, txtProductName);
            return UI.GetText(pageDriver.FindElement(txtProductName));
        }
    }
}