using BoDi;

namespace J_E_LexisNexisTask.Hooks
{
    [Binding]
    public sealed class BaseHooks : DriverContext
    {
        IObjectContainer _container;
        public BaseHooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario("@lexisnexis")]
        public void BeforeScenarioWithTag()
        {
            StartDriver();
            _container.RegisterInstanceAs(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseBrowser();
        }
    }
}