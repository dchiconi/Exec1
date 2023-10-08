using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Exercicio1
{

    [TestClass]
    public class TesteBotaoVerde
    {
        private TestContext testContextInstance;
        private IWebDriver driver;
        private string appURL;

        Comum cm = new Comum();
        ComumTestes ct = new ComumTestes();

        public TesteBotaoVerde()
        {

        }

        [TestMethod]
        public void Testar()
        {
            if (ct.NavegarTelaPrincipal(driver))
            {
                Assert.IsTrue(cm.ClicarBotao(driver, By.XPath("//a[@class='button success']")), "Clicou no botão verde.");
            }
        }

        [TestInitialize()]

        public void SetupTest()
        {
            driver = cm.AbrirWebDriver();
        }

        [TestCleanup()]
        public void Cleanup()
        {
            cm.Encerrar(driver);
        }

    }
}