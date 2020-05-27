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

        #region Mapeamento dos elementos do Login
        IWebElement nomeLogin => driver.FindElement(By.Id("username"));
        IWebElement senhaLogin => driver.FindElement(By.Id("password"));

        IWebElement btnAvancado => driver.FindElement(By.Id("details-button"));
        IWebElement linkAvancado => driver.FindElement(By.Id("proceed-link"));
        #endregion


        #region Mapeamento dos elementos Ver Tarefas

        IWebElement menuVerTarefa => driver.FindElement(By.XPath("//*[@id='sidebar']/ul/li[2]/a/i"));
        IWebElement btnEditar => driver.FindElement(By.XPath("//*[@id='buglist']/tbody/tr[1]/td[2]/a"));
        IWebElement menuDetalhe => driver.FindElement(By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div[1]/div/div[1]/h4"));

        IWebElement txtResumo => driver.FindElement(By.Id("summary"));
        IWebElement btnAtualizar => driver.FindElement(By.XPath("//*[@id='update_bug_form']/div/div[3]/input"));
        IWebElement txtDescricao => driver.FindElement(By.Id("description"));
     
        IWebElement btnClone => driver.FindElement(By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div[1]/div/div[2]/div[2]/div/table/tfoot/tr/td/div/div[6]/form/fieldset/input[3]"));
        IWebElement btnApagar => driver.FindElement(By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div[1]/div/div[2]/div[2]/div/table/tfoot/tr/td/div/div[10]/form/fieldset/input[4]"));
        IWebElement btnApagarTarefas => driver.FindElement(By.XPath("//*[@id='action-group-div']/form/div/div[2]/div[2]/input"));
        IWebElement msgApagar => driver.FindElement(By.XPath("//*[@id='action-group-div']/form/div/div[2]/div[1]/div/table/tbody/tr[1]/th"));

        IWebElement cbxOpcao => driver.FindElement(By.Name("action"));
        IWebElement btnOk => driver.FindElement(By.XPath("//*[@id='bug_action']/div/div[2]/div[2]/div[2]/div[1]/input"));
        IWebElement txtAnotacao => driver.FindElement(By.Id("bugnote_text"));
        IWebElement btnResolver => driver.FindElement(By.XPath("//*[@id='action-group-div']/form/div/div[2]/div[2]/input"));
        IWebElement ccxVisualizar => driver.FindElement(By.XPath("//*[@id='buglist']/tbody/tr[1]/td[1]/div/label/span"));
        //IWebElement ccxVisualizar2 => driver.FindElement(By.XPath("//*[@id='buglist']/tbody/tr[2]/td[1]/div/label/span"));
        
        IWebElement txtPesquisar => driver.FindElement(By.Id("filter-search-txt"));
        IWebElement btnAplicar => driver.FindElement(By.Name("filter_submit"));

        IWebElement btnExpandir => driver.FindElement(By.XPath("//*[@id='filter-toggle']/i"));
        IWebElement btnExibir => driver.FindElement(By.Id("per_page_filter"));
        IWebElement txtExibir => driver.FindElement(By.Id("per_page_filter_target"));


        #endregion


        #region Ações Login

        public void PreencherErro()
        {
            btnAvancado.Click();
            linkAvancado.Click();
        }

        public void PreencherNomeLogin(string nome)
        {
            nomeLogin.Click();
            nomeLogin.SendKeys(nome + Keys.Enter);
        }
        public void PreencherSenhaLogin(string senha)
        {
            senhaLogin.Click();
            senhaLogin.SendKeys(senha + Keys.Enter);

        }
        #endregion


        #region Ações Ver Tarefas

        public void AcessarMenuVerTarefa()
        {
            menuVerTarefa.Click();
        }

        public void AlterarTarefa()
        {
            btnEditar.Click();
        }

        public void PreencherResumo(string resumo)
        {
            txtResumo.Click();
            txtResumo.SendKeys(resumo);
        }

        public void PreencherDescricao(string descricao)
        {
            txtDescricao.Click();
            txtDescricao.SendKeys(descricao);
        }

        public void CriarCloneTarefa()
        {
            btnClone.Click();

        }
        public void AtualizarTarefa()
        {
            btnAtualizar.Click();
        }

        public void ApagarTarefa()
        {
            btnApagar.Click();
        }

        public void ConfirmarApagarTarefa()
        {
            //Assert.AreEqual(msgApagar, "Você tem certeza que deseja apagar estas tarefas?");
            btnApagarTarefas.Click();
        }
        
        public void DetalhesTarefa()
        {
            menuDetalhe.Click();
             //Assert.AreEqual("Ver Detalhes da Tarefa", menuDetalhe);
        }

        public void SelecionarOpcao()
        {
            cbxOpcao.Click();
            SelectElement opcaoSelecionado = new SelectElement(cbxOpcao);
            opcaoSelecionado.SelectByIndex(6);
            cbxOpcao.Click();
        }

        public void OpcaoOk ()
        {
            btnOk.Click();
        }

        public void AdicionarAnotacao(string anotacao)
        {
               txtAnotacao.Click();
                txtAnotacao.SendKeys(anotacao);

        }

        public void ResolverTarefas()
        {
            btnResolver.Click();
        }


        public void SelecionarCheck()
        {
            ccxVisualizar.Click();
            //ccxVisualizar2.Click();
        }

        public void CampoPesquisar(string pesquisa)
        {
            txtPesquisar.Click();
        }

        public void AplicaFiltro()
        {
            btnAplicar.Click();
        }

        public void ExpandirFiltro()
        {
            btnExpandir.Click();
        }

        public void CampoExibir()
        {
            btnExibir.Click();
        }

        public void InformarQuantidade(string pesquisa)
        {
            txtExibir.Click();
        }



        #endregion

    }
}

