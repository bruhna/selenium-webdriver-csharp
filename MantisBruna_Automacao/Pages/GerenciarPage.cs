using MantisBruna_Automacao.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantisBruna_Automacao.Pages
{
    public class GerenciarPage : PageBase
    {
        #region Mapeamento Login
        By usernameField = By.Name("username");
        By passwordField = By.Name("password");

        By btnAvancado = By.Id("details-button");
        By linkAvancado = By.Id("proceed-link");
        #endregion

        #region Mapeamento Gerenciar Projetos
        By menuGerenciar = By.XPath("//*[@id='sidebar']/ul/li[7]/a/span");
        By subMenuProjetos = By.Id("//*[@id='main-container']/div[2]/div[2]/div/ul/li[3]");
        By btnCriarProjeto = By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div/div[2]/div[2]/div/div[1]/form/fieldset/button");
        By txtNomeProjeto = By.Id("project-name");
        By txtDescricao = By.Id("project-description");
        By btnAdicionar = By.XPath("//*[@id='manage-project-create-form']/div/div[3]/input");
        By LinkNomeProj = By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div/div[2]/div[2]/div/div[2]/table/tbody/tr[2]/td[1]/a");
        By btnAdicionarAlterar = By.XPath("//*[@id='manage-proj-update-form']/div/div[3]/input");
        By btnApagarProjeto = By.XPath("//*[@id='project-delete-form']/fieldset/input[3]");
        By btnCriarSubProj = By.XPath("//*[@id='manage-project-update-subprojects-div']/div/div[2]/form/fieldset/button");

        #endregion

        #region Mapeamento Gerenciar Usuário

        By subMenuUsuario = By.XPath("//*[@id='main-container']/div[2]/div[2]/div/ul/li[2]/a");
        By btnCriarConta = By.XPath("//*[@id='manage-user-div']/div[1]/form/fieldset/button");
        By txtNomeUsu = By.Id("user-username");
        By txtNomeVerd = By.Id("user-realname");
        By txtEmail = By.Id("email-field");
        By btnCriar = By.XPath("//*[@id='manage-user-create-form']/div/div[3]/input");
        By btnAtualizar = By.XPath("//*[@id='edit-user-form']/div/div[2]/div[2]/input");
        By linkNomeUsu = By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div/div[4]/div[2]/div[2]/div/table/tbody/tr[1]/td[1]/a");
        By btnApagarUsu = By.XPath("//*[@id='manage-user-delete-form']/fieldset/span/input");
        By btnApagaConfir = By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div/div[2]/form/input[4]");


        #endregion

        #region Mapeamento Gerenciar Marcadores

        By subMenuMarcadores = By.XPath("//*[@id='main-container']/div[2]/div[2]/div/ul/li[4]/a");
        By btnCriarMarcadores = By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div/div[4]/div[2]/div[1]/a");
        By txtNomeMarcadores = By.Id("tag-name");
        By txtDescricaoMarcadores = By.Id("tag-description");
        By btnMarcadores = By.Name("config_set");
        By linkNomeMarcadores = By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div/div[4]/div[2]/div[2]/div/table/tbody/tr[1]/td[1]/a");
        By btnAtualizarMarcadores = By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div/div[2]/div[2]/div/div[3]/form[1]/fieldset/input[2]");
        By btnApagarMarcadores = By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div/div[2]/div[2]/div/div[3]/form[2]/fieldset/input[3]");
        By btnAtualizarAlteracao = By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div/form/div/div[3]/input");



        #endregion

        #region Actions Login

        public void ClicarErro()
        {
            Click(btnAvancado);
            Click(linkAvancado);
        }

        public void PreencherNomeLogin(string nome)
        {
            Click(usernameField);
            SendKeys(usernameField, nome + Keys.Enter);
        }
        public void PreencherSenhaLogin(string senha)
        {
            Click(passwordField);
            SendKeys(passwordField, senha + Keys.Enter);

        }
        #endregion

        #region Actions Gerenciar Projetos
        public void AcessarMenuGerenciar()
        {
            Click(menuGerenciar);
        }

        public void AcessarMenuGerenciarProjeto()
        {
            Click(subMenuProjetos);
        }

        public void CriarProjeto()
        {
            Click(btnCriarProjeto);
        }

        public void PreencherNomeProjeto (string titulo)
        {
            Click(txtNomeProjeto);
            SendKeys(txtNomeProjeto, titulo);
        }

        public void PreencherDescricao(string descricao)
        {
            Click(txtDescricao);
            SendKeys(txtDescricao, descricao);
        }

        public void AdicionarProjeto()
        {
            Click(btnAdicionar);
        }

        public void SelecionarProjeto()
        {
            Click(LinkNomeProj);
        }

        public void ApagarProjeto()
        {
            Click(btnApagarProjeto);
        }

        public void AdicionarProjetoAlterado()
        {
            Click(btnAdicionarAlterar);
        }

        public void CriarSubProjeto()
        {
            Click(btnCriarSubProj);
        }


        #endregion

        #region Actions Gerenciar Usuário

        public void AcessarMenuGerenciarUsuario()
        {
            Click(subMenuUsuario);
        }

        public void CriarUsuario()
        {
            Click(btnCriarConta);
        }

        public void PreencherNomeUsuario(string nome)
        {
            Click(txtNomeUsu);
            SendKeys(txtNomeUsu, nome);
        }

        public void PreencherNomeVerdadeiro(string nome)
        {
            Click(txtNomeVerd);
            SendKeys(txtNomeVerd, nome);
        }
        public void PreencherEmail(string email)
        {
            Click(txtEmail);
            SendKeys(txtEmail, email);
        }

        public void AtualizarUsuario()
        {
            Click(btnAtualizar);
        }

        public void ApagarUsuario ()
        {
            Click(btnApagarUsu);
        }

        public void ConfirmarApagar()
        {
            Click(btnApagaConfir);
        }
        public void SelecionarUsuario ()
        {
            Click(linkNomeUsu);
        }

        #endregion

        #region Actions Gerenciar Marcadores

        public void AcessarMenuGerenciarMarcadores()
        {
            Click(subMenuMarcadores);
        }

        public void CriarMarcadores()
        {
            Click(btnCriarMarcadores);
        }

        public void PreencherNomeMarcador(string nome)
        {
            Click(txtNomeMarcadores);
            SendKeys(txtNomeMarcadores, nome);
        }

        public void PreencherDescricaoMarcadores(string descricao)
        {
            Click(txtDescricaoMarcadores);
            SendKeys(txtDescricaoMarcadores, descricao);
        }

        public void AtualizarMarcadores()
        {
            Click(btnAtualizarMarcadores);
        }

        public void ApagarMarcadores()
        {
            Click(btnApagarMarcadores);
        }

        public void SelecionarMarcadores()
        {
            Click(linkNomeMarcadores);
        }

        public void AtualizarAlteracaoMarcadores()
        {
            Click(btnAtualizarAlteracao);
        }


        #endregion
    }
}
