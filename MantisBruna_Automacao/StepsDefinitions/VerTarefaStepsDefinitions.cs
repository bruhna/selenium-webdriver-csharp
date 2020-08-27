using MantisBruna_Automacao.Pages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MantisBruna_Automacao.StepsDefinitions
{
    [Binding]
    public class VerTarefaStepsDefinitions
    {
        VerTarefaPage _verTarefaPage;


        [Given(@"que eu acesso o login")]
        public void GivenQueEuAcessoOLogin()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.ClicarErro();
            _verTarefaPage.PreencherNomeLogin(ConfigurationManager.AppSettings["NOMELOGIN"]);
            _verTarefaPage.PreencherSenhaLogin(ConfigurationManager.AppSettings["SENHALOGIN"]);
        }


        [Given(@"que eu acesso a opcao no menu Ver Tarefas")]
        public void GivenQueEuAcessoAOpcaoNoMenuVerTarefas()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.AcessarMenuVerTarefa();
        }

        [Given(@"clico na opcao para alterar tarefa")]
        public void GivenClicoNaOpcaoParaAlterarTarefa()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.AlterarTarefa();
        }

        [When(@"altero a informacao do campo Resumo")]
        public void WhenAlteroAInformacaoDoCampoResumo()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.PreencherResumo("Teste Editar Tarefa");
        }

        [When(@"clico em atualizar informacao")]
        public void WhenClicoEmAtualizarInformacao()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.AtualizarTarefa();
        }

        [Given(@"clico em atualizar informacao")]
        public void GivenClicoEmAtualizarInformacao()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.AtualizarTarefa();
        }

        [Then(@"clico em Criar Clone da tarefa")]
        public void ThenClicoEmCriarCloneDaTarefa()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.CriarCloneTarefa();
        }

        [When(@"apresentar Ver detalhes da Tarefa")]
        public void WhenApresentarVerDetalhesDaTarefa()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.DetalhesTarefa();
        }

        [Then(@"clico em Apagar tarefa")]
        public void ThenClicoEmApagarTarefa()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.ApagarTarefa();
            _verTarefaPage.ConfirmarApagarTarefa();
        }

        [When(@"seleciono a opcao de Resolver")]
        public void WhenSelecionoAOpcaoDeResolver()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.SelecionarOpcao(" ");

        }

        [When(@"clico em OK")]
        public void WhenClicoEmOK()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.OpcaoOk();
            
        }

        [When(@"adiciono uma anotação")]
        public void WhenAdicionoUmaAnotacao()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.AdicionarAnotacao("Tarefas Resolvidas");
        }

        [Then(@"resolvo tarefa clicando em Resolver Tarefas")]
        public void ThenResolvoTarefaClicandoEmResolverTarefas()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.ResolverTarefas();
        }

        [Given(@"clico em uma opcao no grid")]
        public void GivenClicoEmMaisDeUmaOpcaoNoGrid()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.SelecionarCheck();
        }

      
        [When(@"informo a tarefa excluida")]
        public void WhenInformoATarefaExcluida()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.CampoPesquisar("tes");
        }

        [When(@"clico na opcao de Aplicar filtro")]
        public void WhenClicoNaOpcaoDeAplicarFiltro()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.AplicaFiltro();
        }

        [Given(@"clico na opcao para expandir menu")]
        public void GivenClicoNaOpcaoParaExpandirMenu()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.ExpandirFiltro();
        }

        [Given(@"clico na opcao exibir")]
        public void GivenClicoNaOpcaoExibir()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.CampoExibir();
        }

        [When(@"informo a quantidade de tarefas")]
        public void WhenInformoAQuantidadeDeTarefas()
        {
            _verTarefaPage = new VerTarefaPage();
            _verTarefaPage.InformarQuantidade("2");
        }


    }
}
