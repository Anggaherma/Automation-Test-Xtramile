using AutoFramework.Pages;
using ComputerDatabase.Pages;

namespace ComputerDatabase
{
    public static class NavigateTo
    {
        public static void AddNewComputerMenu()
        {
            Menu menu = new Menu();
            TestScenarioPage tsPage = new TestScenarioPage();

            menu.AddNewButton.Click();

            Thread.Sleep(1000);
        }
    }
}
