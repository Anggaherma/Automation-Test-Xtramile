using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace ComputerDatabase
{
    public class Menu
    {

        public Menu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "add")]
        public IWebElement AddNewButton { get; set; }

        [FindsBy(How = How.Id, Using = "searchsubmit")]
        public IWebElement searchButton { get; set; }

        [FindsBy(How = How.Id, Using = "searchbox")]
        public IWebElement searchbox { get; set; }

    }

}
