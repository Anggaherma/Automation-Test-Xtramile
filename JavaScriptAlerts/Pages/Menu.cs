using JavaScriptAlerts;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace JavaScriptAlert
{
    public class Menu
    {

        public Menu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#content > div > ul > li:nth-child(1) > button")]
        public IWebElement JsAlertBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content > div > ul > li:nth-child(2) > button")]
        public IWebElement JsConfirmtBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content > div > ul > li:nth-child(3) > button")]
        public IWebElement JsPromptBtn { get; set; }

    }

    public class Alert
    {
        public Alert()
        {
        }

        [FindsBy(How = How.CssSelector, Using = "#main > div.alert-message.warning")]
        public IWebElement AlertCreated { get; set; }
    }

}
