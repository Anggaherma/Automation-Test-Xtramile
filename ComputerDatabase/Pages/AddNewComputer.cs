using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ComputerDatabase
{
    public class AddNewComputer
    {
        public AddNewComputer()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement NameButtonField { get; set; }

        [FindsBy(How = How.Id, Using = "introduced")]
        public IWebElement IntroducedField { get; set; }

        [FindsBy(How = How.Id, Using = "discontinued")]
        public IWebElement DiscontinuedField { get; set; }

        [FindsBy(How = How.Id, Using = "company")]
        public IWebElement Company { get; set; }

        [FindsBy(How = How.CssSelector, Using = "option[value='1']")]
        public IWebElement selComp { get; set; }

    }

    public class SearchComputer
    {
        public SearchComputer()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "searchbox")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.Id, Using = "searchsubmit")]
        public IWebElement SearchBtn { get; set; }
    }

    public class DeleteComputer
    {
        public DeleteComputer()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#main > table > tbody > tr:nth-child(1) > td:nth-child(1) > a")]
        public IWebElement CompName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main > form.topRight > input")]
        public IWebElement DelBtn { get; set; }
    }

}
