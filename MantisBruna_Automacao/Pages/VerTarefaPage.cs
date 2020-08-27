using MantisBruna_Automacao.Bases;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantisBruna_Automacao.Pages
{
    public class VerTarefaPage : PageBase
    {

        #region Mapeamento Login
        By usernameField = By.Name("username");
        By passwordField = By.Name("password");

        By btnAvancado = By.Id("details-button");
        By linkAvancado = By.Id("proceed-link");
        #endregion


        #region Mapeamento dos elementos Ver Tarefas

        By menuVerTarefa = By.XPath("//*[@id='sidebar']/ul/li[2]/a/i");
        By btnEditar = By.XPath("//*[@id='buglist']/tbody/tr[1]/td[2]/a");
        By menuDetalhe = By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div[1]/div/div[1]/h4");
        
        By txtResumo = By.Id("summary");
        By btnAtualizar = By.XPath("//*[@id='update_bug_form']/div/div[3]/input");
        By txtDescricao = By.Id("description");
        
        By btnClone = By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div[1]/div/div[2]/div[2]/div/table/tfoot/tr/td/div/div[6]/form/fieldset/input[3]");
        By btnApagar = By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div[1]/div/div[2]/div[2]/div/table/tfoot/tr/td/div/div[10]/form/fieldset/input[4]");
        By btnApagarTarefas = By.XPath("//*[@id='action-group-div']/form/div/div[2]/div[2]/input");
        By msgApagar = By.XPath("//*[@id='action-group-div']/form/div/div[2]/div[1]/div/table/tbody/tr[1]/th");
        
        By cbxOpcao = By.Name("action");
        By btnOk = By.XPath("//*[@id='bug_action']/div/div[2]/div[2]/div[2]/div[1]/input");
        By txtAnotacao = By.Id("bugnote_text");
        By btnResolver = By.XPath("//*[@id='action-group-div']/form/div/div[2]/div[2]/input");
        By ccxVisualizar = By.XPath("//*[@id='buglist']/tbody/tr[1]/td[1]/div/label/span");
                
        By txtPesquisar = By.Id("filter-search-txt");
        By btnAplicar = By.Name("filter_submit");

        By btnExpandir = By.XPath("//*[@id='filter-toggle']/i");
        By btnExibir = By.Id("per_page_filter");
        
        By txtExibir = By.Id("per_page_filter_target");


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


        #region Actions Ver Tarefas

        public void AcessarMenuVerTarefa()
        {
           Click(menuVerTarefa);
        }

        public void AlterarTarefa()
        {
            Click(btnEditar);
        }

        public void PreencherResumo(string resumo)
        {
            Click(txtResumo);
            SendKeys(txtResumo, resumo);
        }

        public void PreencherDescricao(string descricao)
        {
            Click(txtDescricao);
            SendKeys(txtDescricao, descricao);
        }

        public void CriarCloneTarefa()
        {
            Click(btnClone);

        }
        public void AtualizarTarefa()
        {
            Click(btnAtualizar);
        }

        public void ApagarTarefa()
        {
            Click(btnApagar);
        }

        public void ConfirmarApagarTarefa()
        {
            //Assert.AreEqual(msgApagar, "Você tem certeza que deseja apagar estas tarefas?");
            Click(btnApagarTarefas);
        }
        
        public void DetalhesTarefa()
        {
            Click(menuDetalhe);
             //Assert.AreEqual("Ver Detalhes da Tarefa", menuDetalhe);
        }

        public void SelecionarOpcao(string v)
        {
            Click(cbxOpcao);
            ComboBoxSelectByVisibleText(cbxOpcao, v);

            //SelectElement opcaoSelecionado = new SelectElement(cbxOpcao);
            //opcaoSelecionado.SelectByIndex(6);
            Click(cbxOpcao);
        }

        public void OpcaoOk ()
        {
           Click(btnOk);
        }

        public void AdicionarAnotacao(string anotacao)
        {
               Click(txtAnotacao);
                SendKeys(txtAnotacao, anotacao);

        }

        public void ResolverTarefas()
        {
            Click(btnResolver);
        }


        public void SelecionarCheck()
        {
            Click(ccxVisualizar);
           
        }

        public void CampoPesquisar(string pesquisa)
        {
            Click(txtPesquisar);
        }

        public void AplicaFiltro()
        {
            Click(btnAplicar);
        }

        public void ExpandirFiltro()
        {
            Click(btnExpandir);
        }

        public void CampoExibir()
        {
            Click(btnExibir);
        }

        public void InformarQuantidade(string pesquisa)
        {
            Click(txtExibir);
        }



        #endregion

    }
}

