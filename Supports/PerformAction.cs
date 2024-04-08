namespace J_E_LexisNexisTask.Supports
{
    public static class PerformAction
    {
        public static void PerformActionOnElement(this IWebElement element, IWebDriver driver)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Perform();
            actions.Click(element).Perform();
        }
    }
}
