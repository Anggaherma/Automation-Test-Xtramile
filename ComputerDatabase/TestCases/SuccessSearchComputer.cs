using AutoFramework;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;

namespace ComputerDatabase
{
    public class SuccessSearchComputer
    {
        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void SearchComputer()
        {
            string computerName = "ACE";
            Actions.FillSearchBox(computerName);

            Thread.Sleep(2000);

            // Verify search result
            IWebElement searchResult = Driver.driver.FindElement(By.XPath($"//a[text()='{computerName}']"));
            ClassicAssert.IsNotNull(searchResult, "Computer not found in search results.");

        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
