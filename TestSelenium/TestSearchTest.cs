// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class TestSearchTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Close();
  }
  [Test]
  public void testSearch() {
    driver.Navigate().GoToUrl("https://www.amazon.com.br/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.Id("twotabsearchtextbox")).Click();
    driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("Ventilador");
    driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys(Keys.Enter);
  }
}
