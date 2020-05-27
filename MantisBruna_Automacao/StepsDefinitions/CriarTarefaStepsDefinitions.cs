using MantisBruna_automacao.Pages;
using MantisBruna_Automacao.Helpers;
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
    public class CriarTarefaStepsDefinitions
    {
        CriarTarefaPage _criarTarefaPage;

        [Given(@"que eu acesso login")]
        public void GivenQueEuAcessoLogin()
        {
            _criarTarefaPage = new CriarTarefaPage();
            _criarTarefaPage.PreencherErro();
            _criarTarefaPage.PreencherNomeLogin(ConfigurationManager.AppSettings["NOMELOGIN"]);
            _criarTarefaPage.PreencherSenhaLogin(ConfigurationManager.AppSettings["SENHALOGIN"]); 
        }

        [Given(@"que acesso a opcao no menu Criar Nova Tarefa")]
        public void GivenAcessoAOpcaoNoMenuCriarNovaTarefa()
        {
            _criarTarefaPage = new CriarTarefaPage();
           _criarTarefaPage.AcessarMenuCriarTarefa();
        }


        [When(@"informo dados da tarefa")]
        public void GivenQueInformoDadosDaTarefa(Table table)
        {
            var dictionary = GeneralHelpers.ToDictionary(table);

            _criarTarefaPage = new CriarTarefaPage();
            //  _criarTarefaPage.AcessarMenuCriarTarefa();
            _criarTarefaPage.PreencherCategoria(dictionary["categoria"]);
            _criarTarefaPage.PreencherFrequncia(dictionary["frequencia"]);
            _criarTarefaPage.PreencherGravidade(dictionary["gravidade"]);
            _criarTarefaPage.PreencherPrioridade(dictionary["prioridade"]);
            _criarTarefaPage.PreencherAtribuir(dictionary["atribuir"]);
            _criarTarefaPage.PreencherResumo(dictionary["resumo"]);
            _criarTarefaPage.PreencherDescricao(dictionary["descricao"]);
            _criarTarefaPage.PreencherPassosReproduzir(dictionary["passos"]);
            _criarTarefaPage.PreencherAdicionais(dictionary["adicionais"]);
       
        }

        [When(@"clico em criar nova tarefa")]
        public void WhenClicoEmCriarNovaTarefa()
        {
            _criarTarefaPage = new CriarTarefaPage();
            _criarTarefaPage.SalvarTarefa();
        }

        [Then(@"deve exibir a mensagem de sucesso Operação realizada com sucesso")]
        public void ThenDeveExibirAMensagemDeSucessoOperacaoRealizadaComSucesso()
        {
            _criarTarefaPage = new CriarTarefaPage();
            _criarTarefaPage.ValidarMensagem();
        }

        [When(@"informo somente campos obrigatorios")]
        public void WhenInformoSomenteCamposObrigatorios(Table table)
        {
            var dictionary = GeneralHelpers.ToDictionary(table);

            _criarTarefaPage = new CriarTarefaPage();
            _criarTarefaPage.PreencherCategoria(dictionary["categoria"]);
            _criarTarefaPage.PreencherResumo(dictionary["resumo"]);
            _criarTarefaPage.PreencherDescricao(dictionary["descricao"]);
      
            
        }

        [When(@"informo somente campos nao obrigatorios")]
        public void WhenInformoSomenteCamposNaoObrigatorios(Table table)
        {
            var dictionary = GeneralHelpers.ToDictionary(table);

            _criarTarefaPage = new CriarTarefaPage();
            _criarTarefaPage.PreencherFrequncia(dictionary["frequencia"]);
            _criarTarefaPage.PreencherGravidade(dictionary["gravidade"]);
            _criarTarefaPage.PreencherPrioridade(dictionary["prioridade"]);
            _criarTarefaPage.PreencherAtribuir(dictionary["atribuir"]);
            _criarTarefaPage.PreencherPassosReproduzir(dictionary["passos"]);
            //_criarTarefaPage.PreencherPassosReproduzir("Teste campos não obrigatórios");

        }


    }
}
