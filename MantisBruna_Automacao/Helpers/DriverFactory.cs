using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MantisBruna_Automacao.Helpers
{
    public class DriverFactory
    {
        public static IWebDriver INSTANCE { get; set; }
        public static void Inicializar()
        {
            if (ConfigurationManager.AppSettings["BUILD_REMOTE"].Equals("true"))
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--start-maximized");

                INSTANCE = new RemoteWebDriver(new Uri(ConfigurationManager.AppSettings["REMOTE_URL"]), options.ToCapabilities());

            }
            else
            {
                if (ConfigurationManager.AppSettings["BROWSER"].Equals("chrome"))
                {
                    INSTANCE = new ChromeDriver();
                }
                else if (ConfigurationManager.AppSettings["BROWSER"].Equals("firefox"))
                {
                    INSTANCE = new FirefoxDriver();
                }


            }
        }

        public static void Quit()
        {
            INSTANCE.Quit();
            INSTANCE = null;

        }
    }
}
