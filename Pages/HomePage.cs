namespace J_E_LexisNexisTask.Pages;

public class HomePage
{
    IWebDriver _driver;
    WaitMethods _waitMethods;
    public HomePage(IWebDriver driver)
    {
        _driver = driver;
        _waitMethods = new WaitMethods();
    }

    private IWebElement aboutUs_lkn => _waitMethods.waitForElementBy(_driver, By.LinkText("About Us"));
    private IWebElement cookies_btn => _waitMethods.waitForElementBy(_driver, By.CssSelector("#onetrust-accept-btn-handler"));
    private IWebElement careers_lkn => _waitMethods.waitForElementBy(_driver, By.XPath("//div[@class='caption']/h4[.='Careers']"));


    public void NavigateToLexisNexisPage(string url) => _driver.Navigate().GoToUrl(url);
    public void AcceptCookies()=> cookies_btn.Click();
    public void NavigateAboutUsPage() => aboutUs_lkn.ClickWithJs(_driver);
    public void NavigateCareersPage() => careers_lkn.PerformActionOnElement(_driver);
}
