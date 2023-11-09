using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTest.StepDefinitions
{
    [Binding]
    public sealed class TestSteps
    {
        WebDriver driver;

        [Given(@"Go to sport\.pl page")]
        public void GivenGoToSport_PlPage()
        {
            Hooks.Hook.GetDriver().Navigate().GoToUrl("https://bonigarcia.dev/webdrivermanager/");
        }

    }
}