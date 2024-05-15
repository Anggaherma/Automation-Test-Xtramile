namespace JavaScriptAlert.Pages
{
    using JavaScriptAlerts;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#content > div > h3")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content > div > ul > li:nth-child(1) > button")]
        public IWebElement JsAlertBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content > div > ul > li:nth-child(2) > button")]
        public IWebElement JsAConfirmBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content > div > ul > li:nth-child(3) > button")]
        public IWebElement JsPromptBtn { get; set; }

    }
}
