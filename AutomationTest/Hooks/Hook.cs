using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTest.Hooks
{
    [Binding]
    public sealed class Hook
    {
        private static readonly ThreadLocal<IWebDriver> _driverLocal = new();
        public IWebDriver _driver;
        internal static IWebDriver GetDriver()
        {
            return _driverLocal.Value!;
        }

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            var options = new ChromeOptions();
            options.AddArgument("--lang=en-EN");
            _driver = new ChromeDriver(options);
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}