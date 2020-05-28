using MantisBruna_Automacao.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantisBruna_Automacao.Bases
{
    public class PageBase
    {
        protected IWebDriver driver { get; private set; }
        protected WebDriverWait wait { get; private set; }
        protected IJavaScriptExecutor javaScript { get; private set; }

        public PageBase()
        {
            driver = DriverFactory.INSTANCE;
            wait = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(Convert.ToDouble(ConfigurationManager.AppSettings["DEFAULT_TIMEOUT"])));
            javaScript = (IJavaScriptExecutor)driver;
        }
        public void NavegateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        protected void Click(IWebElement element)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }
        public string getAlert()
        {
            string alertText = DriverFactory.INSTANCE.SwitchTo().Alert().Text;
            DriverFactory.INSTANCE.SwitchTo().Alert().Accept();
            return alertText;
        }

        
    }
}
