using TechTalk.SpecFlow;
using FluentAssertions;
using TestAutomationProject.Pages;
using OpenQA.Selenium;


namespace TestAutomationProject.StepDefinitions;

[Binding]
public class PortalDeInscricoesSteps
{
    private readonly PortalDeInscricoesPage _portalPage;

    public PortalDeInscricoesSteps(ScenarioContext scenarioContext)
    {
        var driver = (IWebDriver)scenarioContext["WebDriver"];
        _portalPage = new PortalDeInscricoesPage(driver);
    }

    [Given(@"que o usuário está na página de inscrições")]
    public void DadoQueOUsuarioEstaNaPaginaDeInscricoes()
    {
        _portalPage.NavegarParaPaginaDeInscricoes("https://exemplo.com/inscricoes");
    }

    [When(@"abrir o dropdown de níveis de ensino")]
    public void QuandoAbrirODropdownDeNiveisDeEnsino()
    {
        _portalPage.AbrirDropdown();
    }

    [When(@"selecionar a opção ""(.*)""")]
    public void QuandoSelecionarAOpcao(string nivel)
    {
        _portalPage.AlterarValorDropdown(nivel == "Graduação" ? "undergraduate" : "graduate");
    }

    [When(@"clicar no botão ""(.*)""")]
    public void QuandoClicarNoBotao(string botao)
    {
        _portalPage.ClicarBotaoAvancar();
    }

    [When(@"preencher os dados do formulário")]
    public void QuandoPreencherOsDadosDoFormulario()
    {
        _portalPage.PreencherFormulario();
    }

    [Then(@"o título ""(.*)"" deve estar visível")]
    public void EntaoOTituloDeveEstarVisivel(string tituloEsperado)
    {
        _portalPage.ValidarElementoVisivel(By.XPath($"//h3[text()='{tituloEsperado}']"));
    }
}
