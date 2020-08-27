using TechTalk.SpecFlow;
using MantisBruna_automacao.Pages;
using System.Configuration;

namespace MantisBruna_Automacao.StepsDefinitions
{

    [Binding]
    public class LoginStepsDefinitions
    {
       
        LoginPage _loginPage;


        [When(@"que eu preencho o campo login")]
        public void GivenQueEuPreenchoOCampoLogin()
        {
            _loginPage = new LoginPage();
            _loginPage.PreencherUsuario(ConfigurationManager.AppSettings["NOMELOGIN"]);

        }

        [Given(@"aciono a opcao para entrar")]
        public void GivenAcionoAOpcaoParaEntrar()
        {
            _loginPage = new LoginPage();
            _loginPage.ClicarEmLogin();
        }


        [When(@"preencho o campo senha errado")]
        public void WhenPeenchoOCampoSenhaErrado()
        {
            _loginPage = new LoginPage();
            _loginPage.PreencherSenha("teste123");
            _loginPage.ClicarEmLogin();
        }

        [Then(@"deve apresentar mensagem de erro")]
        public void ThenDeveApresentarMensagemDeErro()
        {
            _loginPage = new LoginPage();
            _loginPage.MensagemDeErro();
        }

        [Given(@"que eu acesso o campo login")]
        public void GivenQueEuAcessoOCampoLogin()
        {

            _loginPage = new LoginPage();
            _loginPage.ClicarErro();

        }

        [When(@"preencho o campo login errado")]
        public void WhenPeenchoOCampoLoginErrado()
        {
            _loginPage = new LoginPage();
            _loginPage.PreencherUsuario("TesteBruna");
        }

        [When(@"preencho o campo senha")]
        public void WhenPreenchoOCampoSenha()
        {
            _loginPage = new LoginPage();
            _loginPage.PreencherSenha(ConfigurationManager.AppSettings["SENHALOGIN"]);
        }

        [Given(@"preencho o campo senha")]
        public void GivenPreenchoOCampoSenha()
        {
            _loginPage = new LoginPage();
            _loginPage.PreencherSenha(ConfigurationManager.AppSettings["SENHALOGIN"]);
        }


        [When(@"aciono a opcao para entrar")]
        public void WhenAcionoAOpcaoParaEntrar()
        {
            _loginPage = new LoginPage();
            _loginPage.ClicarEmLogin();
        }

        [Then(@"deve apresentar a tela inicial do mantis")]
        public void ThenDeveApresentarATelaInicialDoMantis()
        {
            _loginPage = new LoginPage();
            _loginPage.TelaInicial();
        }

        [Given(@"preencho o campo senha errado")]
        public void GivenPreenchoOCampoSenhaErrado()
        {
            _loginPage = new LoginPage();
            _loginPage.PreencherSenha("TESTE123");
        }

    }
}
