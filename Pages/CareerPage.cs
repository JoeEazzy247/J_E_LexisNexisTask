namespace J_E_LexisNexisTask.Pages;

public class CareerPage
{
    IWebDriver _driver;
    WaitMethods _waitMethods;
    public CareerPage(IWebDriver driver)
    {
        _driver = driver;
        _waitMethods = new WaitMethods();
    }

    private IWebElement searchAllJobs_btn => _waitMethods.waitForElementBy(_driver, By.LinkText("Search all jobs"));
    private IWebElement searchInputField => _waitMethods.waitForElementBy(_driver, By.CssSelector("[placeholder='Search']"));
    private IList<IWebElement> searchResult => _waitMethods.waitForElementsBy(_driver, By.CssSelector("[class='search-results-item']"));


    public void ClickSearchAllJobsButton()
    {
        _driver.SwitchTo().Window(_driver.WindowHandles[1]);
        searchAllJobs_btn.ClickWithJs(_driver);
    }

    public void SearchByKeyWord(string value)
    {
        searchInputField.ScrollToELement(_driver);
        searchInputField.SendKeys(value);
    }

    public bool VerifySearchResult() => searchResult.Count > 0 ? true : false;
}
