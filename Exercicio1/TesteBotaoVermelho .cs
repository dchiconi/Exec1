using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Exercicio1
{

    [TestClass]
    public class TesteBotaoVermelho
    {
        private TestContext testContextInstance;
        private IWebDriver driver;
        private string appURL;

        Comum cm = new Comum();
        ComumTestes ct = new ComumTestes();

        public TesteBotaoVermelho()
        {

        }

        [TestMethod]
        public void Testar()
        {
            if (ct.NavegarTelaPrincipal(driver))
            {
                Assert.IsTrue(cm.ClicarBotao(driver, By.XPath("//a[@class='button alert']")), "Clicou no botão vermelho.");
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