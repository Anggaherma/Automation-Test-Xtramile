using AutoFramework;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ComputerDatabase
{
    public class SuccessAccessHomePage
    {
        IAlert alert;

        [Test]
        public void HomePage()
        {
            Actions.InitializeDriver();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
