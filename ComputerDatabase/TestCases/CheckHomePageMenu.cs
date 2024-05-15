using AutoFramework;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ComputerDatabase
{
    public class CheckHomePageMenu
    {

        [SetUp]
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
