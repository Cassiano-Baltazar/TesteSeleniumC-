using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Security.Policy;
using System;

namespace WinFormsApp1
{
  public partial class Form1: Form
  {
    public Form1() {
      InitializeComponent();
    }

    private void AddList_Click(object sender, EventArgs e) {
      if (!ListChaveNfe.Items.Contains(CHAVE_NFE.Text)) {
        ListChaveNfe.Items.Add(CHAVE_NFE.Text);
      }
      CHAVE_NFE.Clear();
      CHAVE_NFE.Focus();
    }

    private void CHAVE_NFE_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == System.Windows.Forms.Keys.Enter) {
        AddList_Click(this, new EventArgs());
      }
    }

    private void button1_Click(object sender, EventArgs e) {
      if (ListChaveNfe.Items.Count > 0) {


        var profile = new FirefoxProfile();
        var options = new FirefoxOptions {
          Profile = profile
        };

        Console.WriteLine("Abrindo navegador");
        var driver = new FirefoxDriver(options);
        try {
          driver.Manage().Window.Maximize();
          Console.WriteLine("Abrindo a stream");
          driver.Navigate().GoToUrl("https://portalunico.siscomex.gov.br/due/x/#/consulta/consulta-filtro?perfil=publico");
          Thread.Sleep(5000);
          var nfe = driver.FindElement(By.CssSelector("#opt3"));
          nfe.Click();

          var captcha = driver.FindElements(By.XPath("/html/body/plt-layout/div[1]/div[5]/div/div/duex-consulta-due-parametros/form/pucx-panel/p-panel/div/div[2]/div/div[2]/duex-captcha/div/div/div/iframe"));
          while (captcha.Any()) {
            captcha = driver.FindElements(By.XPath("/html/body/plt-layout/div[1]/div[5]/div/div/duex-consulta-due-parametros/form/pucx-panel/p-panel/div/div[2]/div/div[2]/duex-captcha/div/div/div/iframe"));
          }

          Thread.Sleep(5000);

          for (int i = 0; i < ListChaveNfe.Items.Count; i++) {
            var chave = driver.FindElement(By.XPath("//*[@id=\"nrNfe\"]"));
            chave.SendKeys(ListChaveNfe.Items[i].ToString());
            Thread.Sleep(1000);
            var Consulta = driver.FindElement(By.XPath("/html/body/plt-layout/div[1]/div[5]/div/div/duex-consulta-due-parametros/form/pucx-panel/p-panel/div/div[2]/div/div[2]/duex-numero-nfe/div/form/div[2]/div/p-button[1]/button"));
            Consulta.Click();
            Thread.Sleep(2000);
            var Mais = driver.FindElement(By.XPath("/html/body/plt-layout/div[1]/div[5]/div/div/duex-consulta-due-parametros/form/duex-grid-consulta/div/pucx-panel/p-panel/div/div[2]/div/div/div/pucx-grid/div/div[2]/div/p-table/div/div[1]/table/tbody/tr/td[1]/span/em"));
            Mais.Click();
            
          }
        } finally {
          //         driver.Close();
        }
      }
    }
  }
}