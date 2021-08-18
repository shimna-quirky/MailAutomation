using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using Framework.Selenium;
using AutomationMail;
using Framework;
using OpenQA.Selenium.Support.UI;
using AutomationMail.Pages;

namespace AutomationMail.tests
{
    [TestFixture]
    public class Tests
    {

        [SetUp]
        public void BeforeEach()
        {
            FW.SetConfig();
            Driver.Init();
            Pages.PageFactory.Init();
            Driver.Current.Url = FW.FConfig.Test.Url;

        }

        [TearDown]
        public void AfterEach()
        {
            Driver.Current.Quit();
            
        }
        
        [Test]
        public void LogInTest()
        {
           // var wait = new WebDriverWait(Driver.Current, TimeSpan.FromSeconds(10));
            //wait.Until(drvr => Pages.Pages.LogIn.AccName.Displayed);
            //go to login page
           

           // LogInPage logInPage = new LogInPage(Driver.Current);
            PageFactory.LogIn.ClickSignInLink();
            PageFactory.LogIn.EnterUserName("shimna_anand");
            PageFactory.LogIn.ClickSignin();
            //Thread.Sleep(2000);
            PageFactory.LogIn.EnterPassword("ILUAnoop1983");
            PageFactory.LogIn.ClickSignin();
            Assert.AreEqual("shimna", PageFactory.LogIn.GetUser(), "Invalid User");
            PageFactory.LogIn.GoToInbox();
            var inboxcount = PageFactory.LogIn.InboxCount();

            if (inboxcount == 0)
            {
                Assert.Fail("No mails in inbox");
            }
            PageFactory.LogIn.DeleteInbox();
            PageFactory.LogIn.DeleteSelectedMail();
            var inboxcountafterdel = PageFactory.LogIn.InboxCount();
            Assert.AreEqual((inboxcount - 1), inboxcountafterdel);



        }
        [Test]
        public void ComposeMail()
        {
            Pages.PageFactory.LogIn.ClickSignInLink();
            //Pages.Pages.LogIn.EnterUserName("shimna_anand");
            //Pages.Pages.LogIn.ClickSignin();
            //Thread.Sleep(2000);
            //Pages.Pages.LogIn.EnterPassword("ILUAnoop1983");
            //Pages.Pages.LogIn.ClickSignin();
            //Assert.AreEqual("shimna", Pages.Pages.LogIn.GetUser(), "Invalid User");
            //Pages.Pages.LogIn.GoToInbox();
            //Pages.Pages.LogIn.ComposeMail();
            
            //Pages.Pages.LogIn.EnterDestinationMail("chimmu.p@gmail.com");
            //Pages.Pages.LogIn.EnterSubject("hello");
            //Pages.Pages.LogIn.ClickSend();
        }
    }
}