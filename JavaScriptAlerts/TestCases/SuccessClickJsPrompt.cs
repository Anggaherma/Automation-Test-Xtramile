using JavaScriptAlert;
using JavaScriptAlerts;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace JavaScriptAlerts
{
    public class SuccessPromptTests
    {
        private IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseURL);
        }

        [Test]
        public void TestPrompt()
        {
            // Click the button to trigger the prompt
            driver.FindElement(By.CssSelector("button[onclick='jsPrompt()']")).Click();

            // Switch to the prompt
            IAlert prompt = driver.SwitchTo().Alert();

            // Enter text into the prompt
            prompt.SendKeys("Test input");

            // Accept the prompt
            prompt.Accept();

            // Verify the result text
            string resultText = driver.FindElement(By.Id("result")).Text;
            ClassicAssert.AreEqual("You entered: Test input", resultText);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
