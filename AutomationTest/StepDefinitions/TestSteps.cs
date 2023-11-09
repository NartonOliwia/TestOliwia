using OpenQA.Selenium;
using AutomationTest.Hooks;

namespace AutomationTest.StepDefinitions
{
    [Binding]
    public sealed class TestSteps
    {
        [Given(@"Go to sport\.pl page")]
        public void GivenGoToSport_PlPage()
        {
            AutomationTest.Hooks.Hook.Driver!.Navigate().GoToUrl("https://stackoverflow.com/questions/12211781/how-to-maximize-window-in-chrome-using-webdriver-python");
        }

    }
}