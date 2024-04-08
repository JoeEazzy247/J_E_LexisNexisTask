namespace J_E_LexisNexisTask.StepDefinitions;

[Binding]
public sealed class SearchStepDefinitions
{
    private IWebDriver _driver;
    private HomePage _homePage;
    public SearchStepDefinitions(IObjectContainer container)
    {
        _driver = container.Resolve<IWebDriver>();
        _homePage = container.Resolve<HomePage>();
    }

    [Given(@"user is on lexisnexis page")]
    public void GivenUserIsOnLexisnexisPage()
    {
        _homePage.NavigateToLexisNexisPage(readConfig.GetRemoteAddress);
        _homePage.AcceptCookies();
    }

    [When(@"user navigate to “(.*)” page")]
    public void WhenUserNavigateToAboutUsPage(string page)
    {
        if (page == "About Us")
            _homePage.NavigateAboutUsPage();
        else
            _homePage.NavigateCareersPage();
    }
}