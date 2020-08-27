using MantisBruna_Automacao.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MantisBruna_Automacao.StepsDefinitions
{
    [Binding]
    public class GerenciarStepsDefinitions
    {
        GerenciarPage _gerenciarPage;

        #region Gerenciar Projeto

        [When(@"acesso a opcao no menu Gerenciar")]
        public void WhenAcessoAOpcaoNoMenuGerenciar()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.AcessarMenuGerenciar();
        }

        [Given(@"que eu acesso a opcao no menu Gerenciar Projetos")]
        public void GivenQueEuAcessoAOpcaoNoMenuGerenciarProjetos()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.AcessarMenuGerenciar();
        }

        [Given(@"clico na opcao Criar Novo Projeto")]
        public void GivenClicoNaOpcaoCriarNovoProjeto()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.CriarProjeto();
        }

        [When(@"informo os dados do projeto")]
        public void WhenInformoOsDadosDoProjeto()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.PreencherNomeProjeto("Novo Projeto Teste");
            _gerenciarPage.PreencherDescricao("Projeto novo de teste");
        }

        [When(@"clico em Adionar Projeto")]
        public void WhenClicoEmAdionarProjeto()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.AdicionarProjeto();

        }

        [Given(@"seleciono um projeto")]
        public void GivenSelecionoUmProjeto()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.SelecionarProjeto();
        }
       
        [When(@"altero os dados do projeto")]
        public void WhenAlteroOsDadosDoProjeto()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.PreencherNomeProjeto("Novo Projeto Teste Alterado");
            _gerenciarPage.PreencherDescricao("Projeto novo de teste Alterado");
        }

        [Then(@"clico em Atualizar Projeto")]
        public void ThenClicoEmAtualizarProjeto()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.AdicionarProjetoAlterado();

        }
             
        [Given(@"clico em criar subprojetos")]
        public void GivenClicoEmCriarSubprojetos()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.CriarSubProjeto();
        }

        [Given(@"clico em Apagar Projeto")]
        public void GivenClicoEmApagarProjeto()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.ApagarProjeto();
        }

        #endregion

        #region Gerenciar Usuarios

        [Given(@"que eu acesso a opcao no menu Gerenciar Usuarios")]
        public void GivenQueEuAcessoAOpcaoNoMenuGerenciarUsuarios()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.AcessarMenuGerenciarUsuario();
        }

        [Given(@"clico na opcao Criar nova conta")]
        public void GivenClicoNaOpcaoCriarNovaConta()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.CriarUsuario();
        }

        [When(@"informo os dados do usuário")]
        public void WhenInformoOsDadosDoUsuario()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.PreencherNomeUsuario("Usuario Teste");
            _gerenciarPage.PreencherNomeVerdadeiro("Teste");
            _gerenciarPage.PreencherEmail("teste@teste.com.br");
        }
        [When(@"clico em Criar Usuário")]
        public void WhenClicoEmCriarUsuario()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.AtualizarUsuario();
        }

        [Given(@"seleciono um usuario")]
        public void GivenSelecionoUmUsuario()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.SelecionarUsuario();
        }

        [Given(@"clico em Apagar Usuario")]
        public void GivenClicoEmApagarUsuario()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.ApagarUsuario();
        }

        [Given(@"confirmo a solicitacao")]
        public void GivenConfirmoASolicitacao()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.ConfirmarApagar();
        }

        [When(@"altero os dados do usuário")]
        public void WhenAlteroOsDadosDoUsuario()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.PreencherNomeUsuario("Usuario Teste alterado");
            _gerenciarPage.PreencherNomeVerdadeiro("Teste alt");
            _gerenciarPage.PreencherEmail("testealt@teste.com.br");
        }

        [When(@"clico em Atualizar usuario")]
        public void WhenClicoEmAtualizarUsuario()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.AtualizarUsuario();
        }


        #endregion

        #region Gerenciar Marcadores

        [Given(@"que eu acesso a opcao no menu Gerenciar Marcadores")]
        public void GivenQueEuAcessoAOpcaoNoMenuGerenciarMarcadores()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.AcessarMenuGerenciarMarcadores();
        }

        [When(@"informo os dados dos marcadores")]
        public void WhenInformoOsDadosDosMarcadores()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.PreencherNomeMarcador("Marcador Teste");
            _gerenciarPage.PreencherDescricaoMarcadores("Teste marcador");
            
        }

        [Then(@"clico em Criar Marcadores")]
        public void ThenClicoEmCriarMarcadores()
        {
            _gerenciarPage = new GerenciarPage();
            _gerenciarPage.CriarMarcadores();
        }



        #endregion





    }
}
