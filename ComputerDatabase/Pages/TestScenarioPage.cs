using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ComputerDatabase.Pages
{
    public class TestScenarioPage
    {
        public TestScenarioPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "add")]
        public IWebElement AddNewComputer { get; set; }
    }
}
