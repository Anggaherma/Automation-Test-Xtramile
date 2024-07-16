using ComputerDatabase;
using ComputerDatabase.Pages;
using OpenQA.Selenium.Chrome;

namespace AutoFramework
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
        }


        public static void CheckMenu()
        {
            Menu ckMenu = new Menu();
            bool isSearchButtonDisplayed = ckMenu.searchButton.Displayed;
            bool isAddNewButtonDisplayed = ckMenu.AddNewButton.Displayed;
            bool isSearchboxDisplayed = ckMenu.searchbox.Displayed;
        }

        public static void FillAddComputerText(string name, string introduced, string discountinued, string numComp)
        {
            AddNewComputer addComp = new AddNewComputer();

            addComp.NameButtonField.SendKeys(name);
            addComp.IntroducedField.SendKeys(introduced);
            addComp.DiscontinuedField.SendKeys(discountinued);
            addComp.Company.SendKeys(numComp);
            Thread.Sleep(2000);
            addComp.selComp.Click();
        }

        public static void FillSearchBox(string name)
        {
            SearchComputer srchBtn = new SearchComputer();

            srchBtn.SearchBox.SendKeys(name);
            srchBtn.SearchBox.Click();
        }

        public static void DelComp()
        {
            DeleteComputer delComp= new DeleteComputer();
            delComp.CompName.Click();
            delComp.DelBtn.Click();
        }

    }
}
