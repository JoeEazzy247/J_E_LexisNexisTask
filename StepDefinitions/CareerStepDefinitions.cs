namespace J_E_LexisNexisTask.StepDefinitions;

[Binding]
public class CareerStepDefinitions
{
    private IWebDriver _driver;
    private CareerPage _careerPage;
    public CareerStepDefinitions(IObjectContainer container)
    {
        _driver = container.Resolve<IWebDriver>();
        _careerPage = container.Resolve<CareerPage>();
    }

    [When(@"user clicks on Search all jobs button")]
    public void WhenUserClicksOnSearchAllJobsButton()
    {
        Thread.Sleep(3000);
        _careerPage.ClickSearchAllJobsButton();
        Thread.Sleep(3000);
    }

    [When(@"search for '(.*)' in the search box")]
    public void WhenSearchForAutomationTesterInTheSearchBox(string value)
    {
        _careerPage.SearchByKeyWord(value);
    }

    [Then(@"user verify there is at least one or more search result")]
    public void ThenUserVerifyThereIsAtLeastOneOrMoreSearchResult()
    {
        var count = _careerPage.VerifySearchResult();
        Assert.That(count, Is.EqualTo(true));
    }
}
