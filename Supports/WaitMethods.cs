namespace J_E_LexisNexisTask.Supports;

public class WaitMethods
{
    public IWebElement waitForElementBy(IWebDriver browser, By by)
    {
        WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(60));
        return wait.Until(ExpectedConditions.ElementIsVisible(by));
    }

    public IList<IWebElement> waitForElementsBy(IWebDriver browser, By by)
    {
        WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(60));
        return wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(by));
    }

    public void WaitForElementTextBy(IWebDriver browser, By by, string text)
    {
        WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(60));
        wait.Until(ExpectedConditions.TextToBePresentInElementLocated(by, text));
    }
}