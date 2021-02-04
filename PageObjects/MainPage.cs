using OpenQA.Selenium;


namespace Mintos.Tests

{
    public class MainPage
    {
        #region locators
        private By logo = By.Id("dnn_dnnLogo_imgSDLogo");


        #endregion
        public MainPage(IWebDriver driver)
        { pageDriver = driver; }

        public IWebDriver pageDriver { get; }
       
        public string  VerifyOnCorrectSite()
        {
           return pageDriver.Url.ToString();
        }

    }
}