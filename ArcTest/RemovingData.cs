using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WorkflowScript
{
    [TestFixture]
    public class RemovingData
    {
        [Test]
        public void TestMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost/Arc.Lite.STANDARD");

            //Login
            driver.FindElement(By.Name("UserName")).SendKeys("admin");
            driver.FindElement(By.Name("Password")).SendKeys("admin");
            driver.FindElement(By.Id("btnlogin")).Click();
            Thread.Sleep(2000);


            //Workflow builder            
            driver.FindElement(By.Id("arc-workflow-builder")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(0);
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("label > input")).Click();
            driver.FindElement(By.CssSelector("label > input")).SendKeys("Selenium Automation Test");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".arc-btn-outline:nth-child(1)")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".fa-check")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);

            driver.FindElement(By.CssSelector(".fa-cog")).Click();
            Thread.Sleep(2000);
           
            //Removeing Item
            driver.FindElement(By.Id("inventory")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(0);
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("label > input")).Click();
            driver.FindElement(By.CssSelector("label > input")).SendKeys("test item type");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".arc-btn-outline")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#IITConfirmationDeleteModal .fa")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);            
          

            //Removing Customer       
            driver.FindElement(By.Id("customer")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(0);
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("label > input")).Click();
            driver.FindElement(By.CssSelector("label > input")).SendKeys("test customer");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".odd .fas")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".fa-check")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);

            //Removing Supplier
            driver.FindElement(By.Id("supplier")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(0);
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("label > input")).Click();
            driver.FindElement(By.CssSelector("label > input")).SendKeys("test supplier");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".arc-btn-outline")).Click();
            driver.FindElement(By.CssSelector(".fa-check")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("settings")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(0);
            Thread.Sleep(2000);

            //Removing Asset Type
            driver.FindElement(By.CssSelector(".arc-grid-menu:nth-child(8) .arc-grid-menu-column-text")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("label > input")).Click();
            driver.FindElement(By.CssSelector("label > input")).SendKeys("test asset type");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".arc-btn-outline")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".fa-check")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("settings")).Click();
            Thread.Sleep(2000);

            //Removing Qualification
            driver.SwitchTo().Frame(0);
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".arc-grid-menu:nth-child(6) > .arc-grid-menu-column:nth-child(1) > .arc-grid-menu-column-text")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("label > input")).Click();
            driver.FindElement(By.CssSelector("label > input")).SendKeys("Automation Engineer");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".arc-btn-outline")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".fa-check")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("settings")).Click();
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
