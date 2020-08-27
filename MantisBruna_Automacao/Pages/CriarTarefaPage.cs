using System;
using MantisBruna_Automacao.Bases;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MantisBruna_automacao.Pages
{
    public class CriarTarefaPage : PageBase
    {

        #region Mapeamento Login
        By usernameField = By.Name("username");
        By passwordField = By.Name("password");

        By btnAvancado = By.Id("details-button");
        By linkAvancado = By.Id("proceed-link");
        #endregion

        #region Mapeamento Criar Tarefa
        By menuCriarTarefa = By.XPath("//div[@id='sidebar']/ul/li[3]/a/i");
        By cbxCategoria = By.Id("category_id");
        By cbxFrequncia = By.Id("reproducibility");
        By cbxGravidade = By.Id("severity");
        By cbxPrioridade = By.Id("priority");
        By cbxAtribuir = By.Id("handler_id");
        By txtResumo = By.Id("summary");
        By txtDescricao = By.Id("description");
        By txtReproduzir = By.Id("steps_to_reproduce");
        By txtAdicionais = By.Id("additional_info");
        By btnCriarNovaTarefa = By.XPath("//*[@id='report_bug_form']/div/div[2]/div[2]/input");
        By msgOperacao = By.XPath("//div[@id='main-container']/div[2]/div[2]/div/div/div/div[2]/p");

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

        #region Actions Criar Tarefa
        public void AcessarMenuCriarTarefa()
        {
            Click(menuCriarTarefa);
        }
        public void PreencherCategoria(string v)
        {
            Click(cbxCategoria);
           ComboBoxSelectByVisibleText (cbxCategoria, v);
            //categoriaSelecionado.SelectByIndex(1);
            Click(cbxCategoria);
        }

        public void PreencherFrequncia(string v)
        {
            Click(cbxFrequncia);
            ComboBoxSelectByVisibleText(cbxFrequncia, v);
            //SelectElement frequenciaSelecionado = new SelectElement(cbxFrequncia);
            //frequenciaSelecionado.SelectByIndex(1);
            Click(cbxFrequncia);
        }
        public void PreencherGravidade(string v)
        {
            Click(cbxGravidade);
            ComboBoxSelectByVisibleText(cbxGravidade, v);
            //SelectElement gravidadeSelecionado = new SelectElement(cbxGravidade);
            //gravidadeSelecionado.SelectByIndex(6);
            Click(cbxGravidade);
        }
        public void PreencherPrioridade(string v)
        {
            Click(cbxPrioridade);
            ComboBoxSelectByVisibleText(cbxPrioridade, v);
            // SelectElement prioridadeSelecionado = new SelectElement(cbxPrioridade);
            Click(cbxPrioridade);
        }
        public void PreencherAtribuir(string v)
        {
            Click(cbxAtribuir);
            ComboBoxSelectByVisibleText(cbxAtribuir, v);
            //SelectElement atribuirSelecionado = new SelectElement(cbxAtribuir);
            Click(cbxAtribuir);
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
        public void PreencherPassosReproduzir(string reproduzir)
        {
            Click(txtReproduzir);
           SendKeys(txtReproduzir,reproduzir);
        }
        public void PreencherAdicionais(string adicionais)
        {
            Click(txtAdicionais);
            SendKeys(txtAdicionais, adicionais);
        }
        public void SalvarTarefa()
        {
            Click(btnCriarNovaTarefa);
        }
       
        public void ValidarMensagem()
        {
            Assert.AreEqual(msgOperacao, "Operação realizada com sucesso.");
        }
        #endregion
    }
}
