namespace J_E_LexisNexisTask.Supports;

public static class JsMethod
{
    public static void ClickWithJs(this IWebElement element, IWebDriver driver)
    {
        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        js.ExecuteScript("arguments[0].click();", element);
    }

    public static void ScrollToELement(this IWebElement element, IWebDriver driver)
    {
        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        js.ExecuteScript("arguments[0].scrollIntoView(true)", element);
    }
}