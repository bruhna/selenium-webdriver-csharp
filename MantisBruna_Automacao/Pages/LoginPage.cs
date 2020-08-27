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
        #region Mapeamento 

        By usernameField = By.Name("username");
        By passwordField = By.Name("password");

        By btnEntrar = By.XPath("//input[@value='Entrar']");
        By msgErroLogin = By.XPath("//div[@id='main-container']/div/div/div/div/div[4]");
        By campoTela = By.Id("breadcrumbs");

        By btnAvancado = By.Id("details-button");
        By linkAvancado = By.Id("proceed-link");

        #endregion

        #region Actions

        public void ClicarErro()
        {
            Click(btnAvancado);
            Click(linkAvancado);
        }

        public void PreencherUsuario(string usuario)
        {
            SendKeys(usernameField, usuario);
        }
        
        public void PreencherSenha(string senha)
        {
            SendKeys(passwordField, senha);
        }

        public void ClicarEmLogin()
        {
            Click(btnEntrar);
        }

        public void MensagemDeErro()
        {
            string msg = "Sua conta pode estar desativada ou bloqueada ou o nome de usuário e a senha que você digitou não estão corretos.";
            Assert.AreEqual(msgErroLogin,msg);
        }

        public void TelaInicial()
        {
            Click(campoTela);
        }
        #endregion
    }
}
