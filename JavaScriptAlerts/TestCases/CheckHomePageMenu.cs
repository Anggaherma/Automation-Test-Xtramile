using NUnit.Framework;

namespace JavaScriptAlerts
{
    internal class CheckHomePageMenu
    {
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void HomePageDisplay()
        {
            Actions.CheckMenu();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
