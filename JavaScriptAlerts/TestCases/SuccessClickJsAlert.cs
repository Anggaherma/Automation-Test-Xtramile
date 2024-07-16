using JavaScriptAlert;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;

namespace JavaScriptAlerts
{
    public class SuccessClickJsAlert
    {
        IAlert alert;

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void ClickJsAlert()
        {
            // Click the button to trigger the prompt
            Actions.ForJSAlert();

            Thread.Sleep(2000);

            // Verify the alert result
            alert = Driver.driver.SwitchTo().Alert();
            ClassicAssert.AreEqual(Config.AlertMessages.JSAlert, alert.Text);
            alert.Accept();


        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
