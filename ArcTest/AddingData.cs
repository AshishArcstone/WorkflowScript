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
    public class AddingData
    {
        [Test]
        public void TestMethod()
        {
            IWebDriver driver = new ChromeDriver();
            Thread.Sleep(3500);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3500);
            driver.Navigate().GoToUrl("http://localhost/Arc.Lite.STANDARD");
            Thread.Sleep(3500);

            //Login
            driver.FindElement(By.Name("UserName")).SendKeys("admin");
            driver.FindElement(By.Name("Password")).SendKeys("admin");
            driver.FindElement(By.Id("btnlogin")).Click();
            Thread.Sleep(3500);

            //Navigate to settings
            driver.FindElement(By.CssSelector(".fa-cog")).Click();
            Thread.Sleep(3500);

            //Adding Item
            //driver.FindElement(By.Id("inventory")).Click();
            //Thread.Sleep(3500);
            driver.SwitchTo().Frame(0);
            Thread.Sleep(2500);
            driver.FindElement(By.CssSelector(".fa-plus")).Click();
            Thread.Sleep(2500);
            driver.FindElement(By.CssSelector(".form-group:nth-child(1) .fa")).Click();
            Thread.Sleep(2500);
            driver.FindElement(By.Id("txtItemTypeName")).Click();
            driver.FindElement(By.Id("txtItemTypeName")).SendKeys("Test Item Type");
            driver.FindElement(By.CssSelector("#formPopUpAddItemType #btnSave > .fa")).Click();
            Thread.Sleep(3500);
            driver.FindElement(By.CssSelector("#partialDdlItemType .fs-label")).Click();
            Thread.Sleep(2500);
            driver.FindElement(By.CssSelector(".fs-open input")).Click();
            Thread.Sleep(2500);
            driver.FindElement(By.CssSelector(".fs-open input")).SendKeys("test item type");
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector(".fs-open input")).SendKeys(Keys.Down);
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector(".fs-open input")).SendKeys(Keys.Enter);
            Thread.Sleep(500);
            driver.FindElement(By.Id("txtSpecificItemName")).Click();
            driver.FindElement(By.Id("txtSpecificItemName")).SendKeys("Test invent item");
            Thread.Sleep(2500);
            driver.FindElement(By.Id("txtQuantity")).Click();
            driver.FindElement(By.Id("txtQuantity")).SendKeys("100");
            driver.FindElement(By.Id("txtUnitCost")).SendKeys("100");
            Thread.Sleep(2500);
            driver.FindElement(By.CssSelector(".form-group:nth-child(6) .fa")).Click();
            Thread.Sleep(2500);

            //AddingSupplier           
            driver.FindElement(By.Id("txtNameSupplier")).Click();
            driver.FindElement(By.Id("txtNameSupplier")).SendKeys("Test supplier");
            driver.FindElement(By.CssSelector("#formAddEditSupplier .fa")).Click();
            Thread.Sleep(3500);
            driver.FindElement(By.CssSelector("#partialDdlSupplier .fs-label")).Click();
            Thread.Sleep(2500);
            driver.FindElement(By.CssSelector(".fs-open input")).Click();
            Thread.Sleep(2500);
            driver.FindElement(By.CssSelector(".fs-open input")).SendKeys("Test supplier");
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector(".fs-open input")).SendKeys(Keys.Down);
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector(".fs-open input")).SendKeys(Keys.Enter);
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector("#formPopUpAddItem #btnSave > .fa")).Click();
            Thread.Sleep(3500);

            //AddingPersonnel
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2500);
            driver.FindElement(By.Id("personnel")).Click();
            Thread.Sleep(2500);
            driver.SwitchTo().Frame(0);
            Thread.Sleep(2500);
            driver.FindElement(By.CssSelector(".fa-plus")).Click();
            Thread.Sleep(3500);
            driver.FindElement(By.Id("txtusername")).Click();
            driver.FindElement(By.Id("txtusername")).SendKeys(RandomString(7));
            driver.FindElement(By.Id("txtfirstname")).SendKeys("Test");
            driver.FindElement(By.Id("txtlastname")).SendKeys("Personnel");
            Thread.Sleep(2500);
            driver.FindElement(By.Id("txtPrimaryPassword")).SendKeys("Arc@123");
            driver.FindElement(By.Id("txtConfirmPrimaryPassword")).SendKeys("Arc@123");
            Thread.Sleep(2500);
            driver.FindElement(By.CssSelector(".fs-wrap:nth-child(2) .fs-label")).Click();
            driver.FindElement(By.CssSelector(".fs-open .fs-option:nth-child(1) i")).Click();
            driver.FindElement(By.CssSelector(".fs-open .fs-option:nth-child(2) > .fs-checkbox")).Click();
            driver.FindElement(By.CssSelector(".fa-save")).Click();
            Thread.Sleep(3500);           

            //AddingAssets
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2500);
            driver.FindElement(By.Id("assets")).Click();
            Thread.Sleep(2500);
            driver.SwitchTo().Frame(0);
            Thread.Sleep(2500);
            driver.FindElement(By.CssSelector(".fa-plus")).Click();
            Thread.Sleep(2500);
            driver.FindElement(By.Id("txtNameAsset")).Click();
            driver.FindElement(By.Id("txtNameAsset")).SendKeys("Test Asset");
            driver.FindElement(By.CssSelector(".row:nth-child(1) .form-group .btn")).Click();
            Thread.Sleep(2500);
            driver.FindElement(By.Id("AssetTypeName")).Click();
            driver.FindElement(By.Id("AssetTypeName")).SendKeys("Test asset type");
            driver.FindElement(By.CssSelector("#addUpdateAssetType #btnSave")).Click();
            Thread.Sleep(3500);
            driver.FindElement(By.Id("btnSave")).Click();
            Thread.Sleep(3500);

            //AddingCustomer
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2500);
            driver.FindElement(By.Id("customer")).Click();
            driver.SwitchTo().Frame(0);
            Thread.Sleep(2500);
            driver.FindElement(By.CssSelector(".fa-plus")).Click();
            Thread.Sleep(2500);
            driver.FindElement(By.Id("txtNameCustomer")).Click();
            driver.FindElement(By.Id("txtNameCustomer")).SendKeys("Test Customer");
            driver.FindElement(By.CssSelector("#btnSave > .fa")).Click();
            Thread.Sleep(3500);

            //Adding Qualification
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2500);
            driver.FindElement(By.Id("settings")).Click();
            Thread.Sleep(2500);
            driver.SwitchTo().Frame(0);
            Thread.Sleep(2500);
            driver.FindElement(By.CssSelector(".arc-grid-menu:nth-child(6) > .arc-grid-menu-column:nth-child(1) > .arc-grid-menu-column-text")).Click();
            Thread.Sleep(2500);
            driver.FindElement(By.CssSelector(".fa-plus")).Click();
            Thread.Sleep(2500);
            driver.FindElement(By.Id("txtNameQ")).Click();
            driver.FindElement(By.Id("txtNameQ")).SendKeys("Automation Engineer");
            Thread.Sleep(2500);
            driver.FindElement(By.CssSelector(".fs-label")).Click();
            Thread.Sleep(2500);
            driver.FindElement(By.CssSelector(".fs-option:nth-child(1) i")).Click();
            driver.FindElement(By.CssSelector(".fs-option:nth-child(2) i")).Click();
            driver.FindElement(By.CssSelector(".fa-save")).Click();
            Thread.Sleep(3500);

            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2500);
            driver.Quit();
        }

        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
