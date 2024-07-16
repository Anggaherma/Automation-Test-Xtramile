using JavaScriptAlerts;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace JavaScriptAlert
{
    public class JsAlert
    {
        public JsAlert()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#content > div > ul > li:nth-child(1) > button")]
        public IWebElement JsAlertBtn { get; set; }

    }

    public class JsConfirm
    {
        public JsConfirm()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#content > div > ul > li:nth-child(2) > button")]
        public IWebElement JsConfirmBtn { get; set; }

    }

    public class JsPrompt
    {
        public JsPrompt()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#content > div > ul > li:nth-child(3) > button")]
        public IWebElement JsPromptBtn { get; set; }

    }

}
