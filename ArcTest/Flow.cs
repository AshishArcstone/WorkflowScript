// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WorkflowScript
{
    [TestFixture]
    public class Flow
    {
        [Test]
        public void TestMethod()
        {
            IWebDriver driver = new ChromeDriver();
            Thread.Sleep(3000);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://localhost/Arc.Lite.STANDARD");
            Thread.Sleep(3000);

            //Login
            driver.FindElement(By.Name("UserName")).SendKeys("admin");
            driver.FindElement(By.Name("Password")).SendKeys("admin");
            driver.FindElement(By.Id("btnlogin")).Click();
            Thread.Sleep(2000);


            //Admin Qualification
            driver.FindElement(By.CssSelector(".fa-cog")).Click();
            Thread.Sleep(3500);
            driver.FindElement(By.Id("personnel")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(0);
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("label > input")).Click();
            driver.FindElement(By.CssSelector("label > input")).SendKeys("admin");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".wo_rows > .text-left:nth-child(1)")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".fs-default .fs-label")).Click();
            driver.FindElement(By.CssSelector(".fs-default input")).SendKeys("automation engineer");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".fs-open input")).SendKeys(Keys.Down);
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector(".fs-open input")).SendKeys(Keys.Enter);
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector(".fa-save")).Click();
            Thread.Sleep(2500);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2500);
            


            //Workflow builder            
            driver.FindElement(By.Id("arc-workflow-builder")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(0);
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".fa-plus")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtWorkflowName")).Click();
            driver.FindElement(By.Id("txtWorkflowName")).SendKeys("Selenium Automation Test");
            driver.FindElement(By.Id("txtDescription")).Click();
            driver.FindElement(By.Id("txtDescription")).SendKeys("Selenium Automation Test");
            driver.FindElement(By.CssSelector(".modal-lg .arc-btn-icon")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".arc-btn-group-sub > .fa-plus")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSearchValue")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSearchValue")).SendKeys("Step");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".input-group:nth-child(1) .input-group-text")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.Id("txtStepName")).Click();
            driver.FindElement(By.Id("txtStepName")).SendKeys("Test Step");
            driver.FindElement(By.Id("txtRuntime")).Click();
            driver.FindElement(By.Id("txtRuntime")).SendKeys("00:00:10");
            driver.FindElement(By.CssSelector(".row:nth-child(6) .custom-control:nth-child(1) > .arc-checkbox-label")).Click();
            driver.FindElement(By.CssSelector(".custom-control:nth-child(2) > .arc-checkbox-label")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".arc-tab-pill:nth-child(2)")).Click();
            Thread.Sleep(2000);



            /*driver.FindElement(By.Id("txtInstructionName")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtInstructionName")).SendKeys("Test instructions");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("arc-file")).Click();
            Thread.Sleep(2000);
            IWebElement Fileupload = driver.FindElement(By.Id("arc-file")).Click();
            Fileupload.SendKeys(@"C:\Users\Gaurav\Desktop\DemoArc\DemoArc\bin\Debug\Arctest.jpg");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".form-group:nth-child(9) .fa")).Click();*/


            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".arc-tab-pill > .fa-users")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#Personnel .btn:nth-child(1)")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#tbQualification_filter input")).Click();
            driver.FindElement(By.CssSelector("#tbQualification_filter input")).SendKeys("Automation Engineer");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#tbQualification .odd > .sorting_1")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#Personnel .col-md-12 > .btn:nth-child(2)")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#tbPersonnelSpecifics_filter input")).Click();
            driver.FindElement(By.CssSelector("#tbPersonnelSpecifics_filter input")).SendKeys("Test Personnel");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#tbPersonnelSpecifics .odd > td:nth-child(2)")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".arc-tab-pill:nth-child(4)")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#Equipment .btn:nth-child(1)")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#tbQualification_filter input")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#tbQualification_filter input")).SendKeys("Automation Engineer");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".arc-overflow")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#Equipment .col-md-12 > .btn:nth-child(2)")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#tbEquipnentSpecifics_filter input")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#tbEquipnentSpecifics_filter input")).SendKeys("Test Asset");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#tbEquipnentSpecifics .sorting_1 > .arc-overflow")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".fa-shopping-basket")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#Resource .btn:nth-child(1)")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#tbResources_filter input")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#tbResources_filter input")).SendKeys("Test Item Type");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#tbResources td:nth-child(2)")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#Resource .col-md-12 > .btn:nth-child(2)")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#tbResources_filter input")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#tbResources_filter input")).SendKeys("Test Item Type");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#tbResources td:nth-child(2)")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".btn:nth-child(6)")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtChecklistName")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtChecklistName")).SendKeys("Test Checklist");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtNotes")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtNotes")).SendKeys("Test Notes");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtExpectedValues")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtExpectedValues")).SendKeys("111");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#btnUpdateChecklist > .fa")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".close")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".fa-save")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".fa-arrow-left")).Click();
            Thread.Sleep(3000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(3000);

           
            //Sales order 
            driver.FindElement(By.CssSelector(".arc-sales-icon-header")).Click();
            Thread.Sleep(3000);
            driver.SwitchTo().Frame(0);
            Thread.Sleep(3000);
            driver.FindElement(By.Id("add_sales_order")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("select2-customer-container")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".select2-search__field")).SendKeys("Test Customer");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".select2-search__field")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".fa-calendar-alt")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".fa-clock")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("td:nth-child(1) .fa-chevron-up")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("td:nth-child(1) .fa-chevron-up")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".no-block > .btn:nth-child(2) > .fa")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("select2-workflows-container")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".select2-search__field")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".select2-search__field")).SendKeys("Selenium Automation Test");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".select2-search__field")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("add-wo")).Click();
            Thread.Sleep(3000);

            /*driver.FindElement(By.CssSelector(".no-block > .btn:nth-child(1) > .fa")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("#tblChecklists_filter input")).Click();
            driver.FindElement(By.CssSelector("#tblChecklists_filter input")).SendKeys("Test invent item");
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".w-25 > .custom-control")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("#btnAddChecklists > .fa")).Click();
            Thread.Sleep(3000);*/

            driver.FindElement(By.Id("complete-so")).Click();

            Thread.Sleep(3000);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);

            driver.FindElement(By.Id("arc-scheduler-jobs")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("jobs-to-schedule")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(0);
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".ml-4:nth-child(2)")).Click();
            driver.FindElement(By.CssSelector(".ml-4:nth-child(2)")).SendKeys("Test Customer");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#tblJobsGrid_length .fa")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".arc-checkbox-label")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#tblJobsGrid_filter > #btnSchedule")).Click();
            Thread.Sleep(2000);

            driver.SwitchTo().DefaultContent();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".fa-laptop")).Click();
            Thread.Sleep(3000);

            driver.SwitchTo().Frame(0);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("textSrchCustName")).Click();
            driver.FindElement(By.Id("textSrchCustName")).SendKeys("Test Customer");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".fa-search")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".sorting_1")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".arc-status-ready-bg > td:nth-child(4)")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".fa-play")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".fa-book")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".fa-users")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".fa-wrench")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("Output")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".fa-list")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".btn > .fa-paperclip")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("timerPause")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("timerStop")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".pull-left")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".fa-file-alt")).Click();
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
