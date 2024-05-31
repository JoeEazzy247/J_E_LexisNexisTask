using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace J_E_LexisNexisTask.Drivers;

public class DriverContext
{
    public IWebDriver driver;

    public IWebDriver StartDriver()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArguments("--start-maximized", "--incognito", "--headless");
        driver = new ChromeDriver(options);
        return driver;
    }

    public void CloseBrowser()
    {
        driver.Quit();
    }
}
