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

    public IWebElement btnGraduacao => _driver.FindElement(By.CssSelector("[data-testid='education-level-select']"));
    public IWebElement OpcaoGraduacao => _driver.FindElement(By.XPath("//div[@role='option' and span[text()=' Graduação ']"));
    public IWebElement btnAvancar => _driver.FindElement(By.CssSelector("[data-testid='next-button']"));
    public IWebElement OpcaoMestrado => _driver.FindElement(By.XPath("//div[@role='option' and text()='Mestrado em Ciência da Computação']"));
    public IWebElement inputCPF => _driver.FindElement(By.CssSelector("[data-testid='cpf-input']"));
    public IWebElement inputNome => _driver.FindElement(By.CssSelector("[data-testid='name-input']"));
    public IWebElement inputSobrenome => _driver.FindElement(By.CssSelector("[data-testid='surname-input']"));
    public IWebElement inputEmail => _driver.FindElement(By.CssSelector("[data-testid='email-input']"));
    public IWebElement inputCelular => _driver.FindElement(By.CssSelector("[data-testid='cellphone-input']"));
    public IWebElement inputCep => _driver.FindElement(By.CssSelector("[data-testid='cep-input']"));
    public IWebElement inputEndereco => _driver.FindElement(By.CssSelector("[data-testid='address-input']"));
    public IWebElement inputBairro => _driver.FindElement(By.CssSelector("[data-testid='neighborhood-input']"));
    public IWebElement inputCidade => _driver.FindElement(By.CssSelector("[data-testid='city-input']"));
    public IWebElement inputEstado => _driver.FindElement(By.CssSelector("[data-testid='state-input']"));
    public IWebElement inputPais => _driver.FindElement(By.CssSelector("[data-testid='country-input']"));
    public IWebElement TituloJornada => _driver.FindElement(By.XPath("//h3[text()='Sua jornada começa aqui!']"));

    public void AbrirDropdown()
    {
        btnGraduacao.Click();
    }

    public void AlterarValorDropdown(string valor)
    {
        var selectElement = new SelectElement(SelectDropdown);
        selectElement.SelectByValue(valor);
    }

    public void ClicarBotaoAvancar()
    {
        btnAvancar.Click();
    }

    public void PreencherFormulario()
    {
        inputCPF.SendKeys("967.458.890-64");
        inputNome.SendKeys("Teste");
        inputSobrenome.SendKeys("Teste");
        inputEmail.SendKeys("Teste@gmail.com");
        inputCelular.SendKeys("11443256788");
        inputCep.SendKeys("08620202");
        inputEndereco.SendKeys("Teste");
        inputBairro.SendKeys("Teste");
        inputCidade.SendKeys("Teste");
        inputEstado.SendKeys("Teste");
        inputPais.SendKeys("Teste");
    }

    public void ValidarElementoVisivel(By by, int timeoutInSeconds = 10)
    {
        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeoutInSeconds));
        wait.Until(ExpectedConditions.ElementIsVisible(by));
    }
}
