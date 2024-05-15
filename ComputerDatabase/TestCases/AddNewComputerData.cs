using AutoFramework;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;


namespace ComputerDatabase
{
    public class AddNewComputerData
    {
        IAlert alert;

        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void ValidAddNewComputer()
        {

            // Fill in the computer details
            NavigateTo.AddNewComputerMenu();
            Actions.FillAddComputerText("Computer Test", "2022-01-01", "2024-01-01", "1");

            // Submit the form
            Driver.driver.FindElement(By.CssSelector("input[type='submit']")).Click();

            // Verify success message
            string successMessage = Driver.driver.FindElement(By.CssSelector(".alert-message.warning")).Text;
            ClassicAssert.IsTrue(successMessage.Contains("has been created"));
        }


        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}