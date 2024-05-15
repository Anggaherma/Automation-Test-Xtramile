using JavaScriptAlert;
using JavaScriptAlerts;
using OpenQA.Selenium.Chrome;

namespace JavaScriptAlerts
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
        }


        public static void CheckMenu()
        {
            Menu ckMenu = new Menu();
            bool isJsAlertDisplayed = ckMenu.JsAlertBtn.Displayed;
            bool isJsConfirmDisplayed = ckMenu.JsConfirmtBtn.Displayed;
            bool isJsPromptDisplayed = ckMenu.JsPromptBtn.Displayed;
        }

        public static void CheckAlert()
        {
            Alert ckAlert = new Alert();
            bool isCreatedAlertDisplayed = ckAlert.AlertCreated.Displayed;
        }


        public static void ForJSAlert()
        {
            JsAlert alrtBtn = new JsAlert();
            alrtBtn.JsAlertBtn.Click();
        }

        public static void ForJsConfirm()
        {
            JsConfirm cfrBtn = new JsConfirm();
            cfrBtn.JsConfirmBtn.Click();
        }


        public static void ForJsPrompt()
        {
            JsPrompt prpmBtn = new JsPrompt();
            prpmBtn.JsPromptBtn.Click();

        }
        public static void FillForJsPrompt(string text)
        {
            JsPrompt prpmBtn = new JsPrompt();
            prpmBtn.JsPromptBtn.SendKeys(text);

        }
    }
}
