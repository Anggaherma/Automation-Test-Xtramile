using JavaScriptAlerts;
using NUnit.Framework;
using OpenQA.Selenium;

namespace JavaScriptAlerts
{
    public class SuccessAccessHomePage
    {
        IAlert alert;

        [Test]
        public void HomePage()
        {
            // Access home page
            Actions.InitializeDriver();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
