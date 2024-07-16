using JavaScriptAlert;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;

namespace JavaScriptAlerts
{
    public class SuccessClickJsConfirm
    {
        IAlert alert;

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void ClickJsConfirm()
        {
            // Click the button to trigger the prompt
            Actions.ForJsConfirm();

            Thread.Sleep(2000);

            // Verify the alert result
            alert = Driver.driver.SwitchTo().Alert();
            ClassicAssert.AreEqual(Config.AlertMessages.JSConfirm, alert.Text);
            alert.Accept();


        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
