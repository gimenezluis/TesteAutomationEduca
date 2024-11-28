using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace TestAutomationProject.Hooks;

[Binding]
public class DriverSetup
{
    private readonly ScenarioContext _scenarioContext;

    public DriverSetup(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [BeforeScenario]
    public void InitializeWebDriver()
    {
        // Criação do WebDriver (use o driver que preferir, aqui é o Chrome)
        IWebDriver driver = new ChromeDriver();

        // Maximizar a janela do navegador
        driver.Manage().Window.Maximize();

        // Registrar o WebDriver no ScenarioContext
        _scenarioContext["WebDriver"] = driver;
    }

    [AfterScenario]
    public void TearDownWebDriver()
    {
        // Finalizar o WebDriver após o cenário
        if (_scenarioContext.ContainsKey("WebDriver"))
        {
            var driver = (IWebDriver)_scenarioContext["WebDriver"];
            driver.Quit();
        }
    }
}
