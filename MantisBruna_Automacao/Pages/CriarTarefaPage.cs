using System;
using MantisBruna_Automacao.Bases;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MantisBruna_automacao.Pages
{
    public class CriarTarefaPage : PageBase
    {

        #region Mapeamento dos elementos do Login
        IWebElement nomeLogin => driver.FindElement(By.Id("username"));
        IWebElement senhaLogin => driver.FindElement(By.Id("password"));

        IWebElement btnAvancado => driver.FindElement(By.Id("details-button"));
        IWebElement linkAvancado => driver.FindElement(By.Id("proceed-link"));
        #endregion

        #region Mapeamento dos elementos Tela Criar Tarefa
        IWebElement menuCriarTarefa => driver.FindElement(By.XPath("//div[@id='sidebar']/ul/li[3]/a/i"));
        // IWebElement menuCriarTarefa => driver.FindElement(By.CssSelector("href='/bug_report_page.php'"));
        IWebElement cbxCategoria => driver.FindElement(By.Id("category_id"));
        IWebElement cbxFrequncia => driver.FindElement(By.Id("reproducibility"));
        IWebElement cbxGravidade => driver.FindElement(By.Id("severity"));
        IWebElement cbxPrioridade => driver.FindElement(By.Id("priority"));
        IWebElement cbxAtribuir => driver.FindElement(By.Id("handler_id"));
        IWebElement txtResumo => driver.FindElement(By.Id("summary"));
        IWebElement txtDescricao => driver.FindElement(By.Id("description"));
        IWebElement txtReproduzir => driver.FindElement(By.Id("steps_to_reproduce"));
        IWebElement txtAdicionais => driver.FindElement(By.Id("additional_info"));

        IWebElement btnCriarNovaTarefa => driver.FindElement(By.XPath("//*[@id='report_bug_form']/div/div[2]/div[2]/input"));
        IWebElement msgOperacao => driver.FindElement(By.XPath("//div[@id='main-container']/div[2]/div[2]/div/div/div/div[2]/p"));

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

        #region Ações Criar nova tarefa
        public void AcessarMenuCriarTarefa()
        {
            menuCriarTarefa.Click();
        }
        public void PreencherCategoria(string v)
        {
            cbxCategoria.Click();
            SelectElement categoriaSelecionado = new SelectElement(cbxCategoria);
            //categoriaSelecionado.SelectByIndex(1);
            cbxCategoria.Click();
        }

        internal void PreencherCategoria()
        {
            throw new NotImplementedException();
        }

        public void PreencherFrequncia(string v)
        {
            cbxFrequncia.Click();
            SelectElement frequenciaSelecionado = new SelectElement(cbxFrequncia);
            frequenciaSelecionado.SelectByIndex(1);
            cbxFrequncia.Click();
        }
        public void PreencherGravidade(string v)
        {
            cbxGravidade.Click();
            SelectElement gravidadeSelecionado = new SelectElement(cbxGravidade);
            gravidadeSelecionado.SelectByIndex(6);
            cbxGravidade.Click();
        }
        public void PreencherPrioridade(string v)
        {
            cbxPrioridade.Click();
            SelectElement prioridadeSelecionado = new SelectElement(cbxPrioridade);
            prioridadeSelecionado.SelectByIndex(3);
            cbxPrioridade.Click();
        }
        public void PreencherAtribuir(string v)
        {
            cbxAtribuir.Click();
            SelectElement atribuirSelecionado = new SelectElement(cbxAtribuir);
            atribuirSelecionado.SelectByIndex(2);
            cbxAtribuir.Click();
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
        public void PreencherPassosReproduzir(string reproduzir)
        {
            txtReproduzir.Click();
            txtReproduzir.SendKeys(reproduzir);
        }
        public void PreencherAdicionais(string adicionais)
        {
            txtAdicionais.Click();
            txtAdicionais.SendKeys(adicionais);
        }
        public void SalvarTarefa()
        {
            btnCriarNovaTarefa.Click();
        }
       
        public void ValidarMensagem()
        {
            Assert.AreEqual(msgOperacao, "Operação realizada com sucesso.");
        }
        #endregion
    }
}
