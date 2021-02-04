using OpenQA.Selenium;


namespace Mintos.Tests

{
    public class MenuNavigation
    {
        #region locators
        private By logo = By.CssSelector("#logo img");
        private By txtFreeonlineCalc = By.CssSelector("h1");
        public By menuBrands = By.Id("lnkTopLevelMenu_1882732");
        public By menuSale = By.Id("lnkTopLevelMenu_1882921");
        public By menuMens = By.Id("lnkTopLevelMenu_1883126");
        public By menuLadies = By.Id("lnkTopLevelMenu_1883248");
        public By menuKids = By.Id("lnkTopLevelMenu_1883356");
        public By menuAccessories = By.Id("lnkTopLevelMenu_1883482");
        public By menuSports = By.Id("lnkTopLevelMenu_1883610");
        public By menuFootball = By.Id("lnkTopLevelMenu_1883704");
        public By menuRunning = By.Id("lnkTopLevelMenu_1883831");
        public By menuTraining = By.Id("lnkTopLevelMenu_1883924");
        public By menuOutdoor = By.Id("lnkTopLevelMenu_1884031");
        public By menuUsc = By.Id("lnkTopLevelMenu_1884112");
        public By subMenuHockey = By.XPath("//li[@id='liTopLevelMenu_1883610']//li[5]//li[3]/a");

        #endregion
        public MenuNavigation(IWebDriver driver)
        { pageDriver = driver; }

        public IWebDriver pageDriver { get; }
        public MenuNavigation ClickMenu(string name)
        {

            switch (name)
            {
                case "BRAND":
                    UI.ClickElement(pageDriver, menuBrands);
                    break;
                case "SALE":
                    UI.ClickElement(pageDriver, menuSale);
                    break;
                case "MENS":
                    UI.ClickElement(pageDriver, menuMens);
                    break;
                case "LADIES":
                    UI.ClickElement(pageDriver, menuLadies);
                    break;
                case "KIDS":
                    UI.ClickElement(pageDriver, menuKids);
                    break;
                case "ACCESSORIES":
                    UI.ClickElement(pageDriver, menuAccessories);
                    break;
                case "SPORTS":
                    UI.ClickElement(pageDriver, menuSports);
                    break;
                case "FOOTBALL":
                    UI.ClickElement(pageDriver, menuFootball);
                    break;
                case "RUNNINS":
                    UI.ClickElement(pageDriver, menuRunning);
                    break;
                case "TRAINING":
                    UI.ClickElement(pageDriver, menuTraining);
                    break;
                case "OUTDOOR":
                    UI.ClickElement(pageDriver, menuOutdoor);
                    break;
                case "USC":
                    UI.ClickElement(pageDriver, menuUsc);
                    break;
                case "ICE_HOCKEY":
                    UI.ClickElement(pageDriver, subMenuHockey);
                    break;

            };
            return this;

        }

        public MenuNavigation FocusMenu(string name)
        {
            switch (name)
            {
                case "BRAND":
                    UI.FocusElement(pageDriver, menuBrands);
                    break;
                case "SALE":
                    UI.FocusElement(pageDriver, menuSale);
                    break;
                case "MENS":
                    UI.FocusElement(pageDriver, menuMens);
                    break;
                case "LADIES":
                    UI.FocusElement(pageDriver, menuLadies);
                    break;
                case "KIDS":
                    UI.FocusElement(pageDriver, menuKids);
                    break;
                case "ACCESSORIES":
                    UI.FocusElement(pageDriver, menuAccessories);
                    break;
                case "SPORTS":
                    UI.FocusElement(pageDriver, menuSports);
                    break;
                case "FOOTBALL":
                    UI.FocusElement(pageDriver, menuFootball);
                    break;
                case "RUNNINS":
                    UI.FocusElement(pageDriver, menuRunning);
                    break;
                case "TRAINING":
                    UI.FocusElement(pageDriver, menuTraining);
                    break;
                case "OUTDOOR":
                    UI.FocusElement(pageDriver, menuOutdoor);
                    break;
                case "USC":
                    UI.FocusElement(pageDriver, menuUsc);
                    break;

            };

            return this;
        }

    }
}