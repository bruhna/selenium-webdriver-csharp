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
    public class Hooks
    {
        [BeforeScenario]
        public void Inicializar()
        {
            DriverFactory.Inicializar();
            DriverFactory.INSTANCE.Manage().Window.Maximize();
            DriverFactory.INSTANCE.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL_MANTIS"]);
            
        }

        [AfterScenario]
        public void Fechar()
        {
            DriverFactory.Quit();
        }


    }
}
