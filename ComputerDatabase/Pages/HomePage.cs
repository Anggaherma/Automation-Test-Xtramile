namespace AutoFramework.Pages
{
    using ComputerDatabase;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "body > header > h1 > a")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.Id, Using = "searchsubmit")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".computers.zebra-striped")]
        public IWebElement ComputersTable { get; set; }

    }
}
