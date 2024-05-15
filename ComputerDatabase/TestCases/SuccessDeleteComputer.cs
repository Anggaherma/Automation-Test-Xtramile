using AutoFramework;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;

namespace ComputerDatabase
{
    public class SuccessDeleteComputer
    {
        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void deleteComputer()
        {
            // Enter the computer name to search for
            Actions.FillSearchBox("ACE");

            Thread.Sleep(2000);

            // Find the computer to delete by name
            Actions.DelComp();

            Thread.Sleep(2000);

            // Verify success message
            string successMessage = Driver.driver.FindElement(By.CssSelector(".alert-message.warning")).Text;
            ClassicAssert.IsTrue(successMessage.Contains("has been deleted"));
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
