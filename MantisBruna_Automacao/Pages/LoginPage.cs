using MantisBruna_Automacao.Bases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantisBruna_automacao.Pages
{
    public class LoginPage : PageBase

    {
        #region Mapeamento dos campos
        IWebElement txtLogin => driver.FindElement(By.Name("username"));
        IWebElement btnEntrar => driver.FindElement(By.XPath("//input[@value='Entrar']"));

        IWebElement msgErroLogin => driver.FindElement(By.XPath("//div[@id='main-container']/div/div/div/div/div[4]"));
       

        IWebElement txtSenha => driver.FindElement(By.Name("password"));

        IWebElement campoTela => driver.FindElement(By.Id("breadcrumbs"));

        IWebElement btnAvancado => driver.FindElement(By.Id("details-button"));
        IWebElement linkAvancado => driver.FindElement(By.Id("proceed-link"));

        //IWebElement campoTela2 => driver.FindElement(By.CssSelector("href=' / my_view_page.php'"));
        #endregion

        #region Ações do Login

        public void PreencherErro()
        {
            btnAvancado.Click();
            linkAvancado.Click();
        }

        public void PreencherLogin(string login)
        {
            txtLogin.SendKeys(login);
        }
        public void PreencherSenha(string senha)
        {
            txtSenha.SendKeys(senha);
        }

        public void ClickEntrar()
        {
            btnEntrar.Click();
        }

        public void MensagemDeErro()
        {
            Assert.AreEqual(msgErroLogin,"Sua conta pode estar desativada ou bloqueada ou o nome de usuário e a senha que você digitou não estão corretos.");
        }

        public void TelaInicial()
        {
            campoTela.Click();
        }
        #endregion
    }
}
