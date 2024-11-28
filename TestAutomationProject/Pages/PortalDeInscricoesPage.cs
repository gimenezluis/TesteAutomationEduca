using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestAutomationProject.Pages;

public class PortalDeInscricoesPage
{
    private readonly IWebDriver _driver;

    public PortalDeInscricoesPage(IWebDriver driver)
    {
        _driver = driver;
    }

    // Navegar para a página de inscrições
    public void NavegarParaPaginaDeInscricoes(string url)
    {
        _driver.Navigate().GoToUrl(url);
    }

    // Elementos
    public IWebElement BotaoDropdown => _driver.FindElement(By.CssSelector("button[data-testid='education-level-select']"));
    public IWebElement SelectDropdown => _driver.FindElement(By.CssSelector("select[data-testid='education-level-select']"));
    public IWebElement BotaoAvancar => _driver.FindElement(By.CssSelector("[data-testid='next-button']"));
    public IWebElement TituloSucesso => _driver.FindElement(By.XPath("//h3[text()='Sua jornada começa aqui!']"));

    // Métodos
    public void AbrirDropdown()
    {
        BotaoDropdown.Click();
    }

    public void AlterarValorDropdown(string valor)
    {
        var selectElement = new SelectElement(SelectDropdown);
        selectElement.SelectByValue(valor);
    }

    public void ClicarBotaoAvancar()
    {
        BotaoAvancar.Click();
    }

    public void PreencherFormulario()
    {
        _driver.FindElement(By.CssSelector("[data-testid='cpf-input']")).SendKeys("967.458.890-64");
        _driver.FindElement(By.CssSelector("[data-testid='name-input']")).SendKeys("Teste");
        _driver.FindElement(By.CssSelector("[data-testid='surname-input']")).SendKeys("Teste");
        _driver.FindElement(By.CssSelector("[data-testid='email-input']")).SendKeys("Teste@gmail.com");
        _driver.FindElement(By.CssSelector("[data-testid='cellphone-input']")).SendKeys("11443256788");
        _driver.FindElement(By.CssSelector("[data-testid='cep-input']")).SendKeys("08620202");
        _driver.FindElement(By.CssSelector("[data-testid='address-input']")).SendKeys("Rua Teste");
        _driver.FindElement(By.CssSelector("[data-testid='neighborhood-input']")).SendKeys("Bairro Teste");
        _driver.FindElement(By.CssSelector("[data-testid='city-input']")).SendKeys("Cidade Teste");
        _driver.FindElement(By.CssSelector("[data-testid='state-input']")).SendKeys("Estado Teste");
        _driver.FindElement(By.CssSelector("[data-testid='country-input']")).SendKeys("Brasil");
    }

    public void ValidarElementoVisivel(By by, int timeoutInSeconds = 10)
    {
        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeoutInSeconds));
        wait.Until(ExpectedConditions.ElementIsVisible(by));
    }
}
