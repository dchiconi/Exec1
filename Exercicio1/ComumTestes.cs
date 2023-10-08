using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
namespace Exercicio1
{
    public class ComumTestes
    {
         Comum cm = new Comum();
        public bool NavegarTelaPrincipal(IWebDriver driver)
        {
            if (cm.CarregarPagina(driver))
            {
                Assert.IsTrue(driver.Title.Contains("The Internet"), "Pagina abriu");
                return true;
            }
            else
            {
                Assert.Fail("Nao abriu corretamente a pagina");
                return false;
            }
            
        }
    }
}
