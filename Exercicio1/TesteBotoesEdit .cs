using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Exercicio1
{

    [TestClass]
    public class TesteBotoesEdit
    {
        private TestContext testContextInstance;
        private IWebDriver driver;
        private string appURL;

        Comum cm = new Comum();
        ComumTestes ct = new ComumTestes();

        public TesteBotoesEdit()
        {

        }

        [TestMethod]
        public void Testar()
        {
            if (ct.NavegarTelaPrincipal(driver))
            {
                var listaElementos = cm.BuscaListaElementos(driver, By.XPath("//a[@href='#edit']"));
                if (listaElementos.Count > 0)
                {
                    var i = listaElementos.Count;
                    do 
                    {
                        i = i - 1;
                        Assert.IsTrue(cm.ClicarBotao(driver, By.XPath("//td[text()='Phaedrum" + i + "']/../td/a")), "Botão Edit " + i + " clicado com sucesso.");
                    } while (i > 0);
                }
                else
                {
                    Assert.Fail("Botões Edit Não encontrados na pagina");
                }
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