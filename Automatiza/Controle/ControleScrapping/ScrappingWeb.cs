//using Automatiza.Controle.VariaveisPublicas;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.UI;

//namespace Automatiza.ControleScrapping
//{

//    public class ScrappingWeb
//    {

//        public static void Scrapping()
//        {

//            Frm_inicio frm = new Frm_inicio();

//            var chromeDriverService = ChromeDriverService.CreateDefaultService();
//            chromeDriverService.HideCommandPromptWindow = true;
//            ChromeOptions options = new ChromeOptions();
//            options.AddArguments("--headless", "--no-sandbox", "--disable-web-security", "--disable-gpu", "--incognito", "--proxy-bypass-list=*", "--proxy-server='direct://'", "--log-level=3", "--hide-scrollbars");
//            IWebDriver driver = new ChromeDriver(chromeDriverService, options);



//            // Navigate to the website
//            driver.Navigate().GoToUrl("https://atendimento.sisbr.coop.br/tas/public/login/form");

//            IWebElement loginInput = driver.FindElement(By.XPath("//*[@id=\"loginname\"]"));
//            loginInput.SendKeys("cocredbot3214_00");


//            IWebElement PassInput = driver.FindElement(By.XPath("//*[@id=\"password\"]"));

//            IWebElement Entrar = driver.FindElement(By.XPath("//*[@id=\"login\"]"));
//            Entrar.Click();


//            driver.Navigate().GoToUrl("https://atendimento.sisbr.coop.br/tas/public/ssp/content/serviceflow?unid=b9fb4e57db6a43cb84231eafdce5fac3&from=e94476e2-8c74-4c5b-a6ee-cf7af65e291f&openedFromService=true");



//            //**********************************Daqui para baixo altera o frame**********************************

//            // localiza frame
//            IWebElement iframe = driver.FindElement(By.XPath("//*[@id=\"ssp-form-parent\"]/iframe"));

//            // Muda para o contexto do iframe
//            driver.SwitchTo().Frame(iframe);

//            //Anexa Assunto
//            IWebElement Assunto = driver.FindElement(By.XPath("//*[@id=\"ssdform6c78fd3238a44b4088f9ac61f5f58ff8_openquestion16_openquestion_openquestion\"]"));
//            Assunto.SendKeys(PublicVar.Status);

//            // localiza a lista
//            IWebElement selectElement = driver.FindElement(By.Name("ssdform6c78fd3238a44b4088f9ac61f5f58ff8_searchlist1_searchlist_searchlist"));


//            // Cria um objeto Select para interagir com o elemento select
//            SelectElement select = new SelectElement(selectElement);


//            // Seleciona a opção 2 pelo texto
//            select.SelectByText("Inclusão/Remoção de Grupo para Usuário");

//            //Coloca texto no text Area
//            IWebElement TextArea = driver.FindElement(By.XPath("//*[@id=\"ssdform6c78fd3238a44b4088f9ac61f5f58ff8_openquestion31_openquestion_openquestion\"]"));
//            TextArea.SendKeys(PublicVar.Status);


//            string meuCaminho = PublicVar.CaminhoArquivo;

//            driver.FindElement(By.Id("ssdform6c78fd3238a44b4088f9ac61f5f58ff8_uploadfield2_uploadfield_uploadfield_temporary")).SendKeys(meuCaminho);
//            IWebElement enviar = driver.FindElement(By.XPath("//*[@id=\"button_submit\"]"));
//            enviar.Click();



//            /*IWebElement Anexar = driver.FindElement(By.XPath("//*[@id=\"ssdform6c78fd3238a44b4088f9ac61f5f58ff8_uploadfield2_uploadfield\"]/div/div[1]/div/span/div[1]"));
//            Anexar.Click();
//            controle.t(3000);


//            SendKeys.SendWait(meuCaminho);
//            // Simula a pressão de uma tecla específica
//            SendKeys.SendWait("{ENTER}");
//            controle.t(2000);

//            ;*/


//            // Volta para o contexto padrão (fora do iframe)
//            driver.SwitchTo().DefaultContent();

//            IWebElement iframe2 = driver.FindElement(By.XPath("//*[@id=\"ssp-form-parent\"]/iframe"));

//            // Muda para o contexto do iframe
//            driver.SwitchTo().Frame(iframe2);

//            IWebElement mensagem = driver.FindElement(By.XPath("//*[@id=\"thankYouDiv\"]/div[3]/span[3]/a"));
//            PublicVar.texto = mensagem.Text;


//            driver.Quit();



//            Clipboard.SetText(PublicVar.texto);

//            // Simula a tecla pressionada
//        }
//    }
//}
