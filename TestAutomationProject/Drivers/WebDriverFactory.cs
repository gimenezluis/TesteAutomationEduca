using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestAutomationProject.Drivers;

public static class WebDriverFactory
{
    public static IWebDriver CreateWebDriver()
    {
        var options = new ChromeOptions();
        options.AddArgument("--headless");
        options.AddArgument("--disable-gpu");
        return new ChromeDriver(options);
    }
}
