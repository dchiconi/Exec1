using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Configuration;
using System.Linq;
using System.Collections.Generic;

namespace Exercicio1
{
    internal class Comum
    {
        public IWebDriver AbrirWebDriver()
        {
            IWebDriver driver = null;

            driver = new ChromeDriver(@"" + ConfigurationManager.AppSettings["URLChromeDriver"]);

            return driver;

        }
        public bool CarregarPagina(IWebDriver dr)
        {
            TimeSpan tm = new TimeSpan();
            tm = TimeSpan.FromSeconds(10);
            try
            {
                var url = "https://the-internet.herokuapp.com/challenging_dom";
                dr.Manage().Timeouts().PageLoad = tm;
                dr.Navigate().GoToUrl(url);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public string BuscarTexto(IWebDriver dr, By by)
        {
            try
            {
                IWebElement webElement = dr.FindElement(by);
                return webElement.Text;
            }
            catch (Exception ex)
            {
                return "erro";
            }

        }
        public List<IWebElement> BuscaListaElementos(IWebDriver dr, By by)
        {
            List<IWebElement> webElement = new List<IWebElement>();
            try
            {
                webElement = dr.FindElements(by).ToList();
                return webElement;
            }
            catch (Exception ex)
            {
                return webElement;
            }

        }
        public bool DigitarTexto(IWebDriver dr, By by, string texto)
        {
            try
            {
                IWebElement webElement = dr.FindElement(by);
                webElement.SendKeys(texto);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ClicarBotao(IWebDriver dr, By by)
        {
            try
            {
                IWebElement webElement = dr.FindElement(by);
                webElement.Click();
                System.Threading.Thread.Sleep(1000);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Submit(IWebDriver dr, By by)
        {
            try
            {
                IWebElement webElement = dr.FindElement(by);
                webElement.SendKeys(Keys.Enter);
                return true;
            }
            catch (Exception ex)
            {
                return true;
            }

        }
        public void Encerrar(IWebDriver dr)
        {
            dr.Quit();
        }
    }
}
