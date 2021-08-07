using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using Framework.Selenium;
using AutomationMail.Pages;

namespace AutomationMail.tests
{
    [TestFixture]
    public class Tests
    {

        [SetUp]
        public void BeforeEach()
        {
            Driver.Init();
            Pages.Pages.Init();
            Driver.Current.Url = "https://au.yahoo.com";
        }

        [TearDown]
        public void AfterEach()
        {
            Driver.Current.Quit();
            
        }
        
        [Test]
        [Parallelizable(ParallelScope.Children)]
        public void LogInTest()
        {
            //go to login page
           

           // LogInPage logInPage = new LogInPage(Driver.Current);
            Pages.Pages.LogIn.ClickSignInLink();
            //Pages.Pages.LogIn.EnterUserName("shimna_anand");
            //Pages.Pages.LogIn.ClickSignin();
            //Thread.Sleep(2000);
            //Pages.Pages.LogIn.EnterPassword("ILUAnoop1983");
            //Pages.Pages.LogIn.ClickSignin();
            //Assert.AreEqual("shimna", Pages.Pages.LogIn.GetUser(), "Invalid User");
            //Pages.Pages.LogIn.GoToInbox();
            //var inboxcount = Pages.Pages.LogIn.InboxCount();

            //if (inboxcount == 0)
            //{
            //    Assert.Fail("No mails in inbox");
            //}
            //    Pages.Pages.LogIn.DeleteInbox();
            //    Pages.Pages.LogIn.DeleteSelectedMail();
            //    var inboxcountafterdel = Pages.Pages.LogIn.InboxCount();
            //    Assert.AreEqual((inboxcount - 1), inboxcountafterdel);
            
           

        }
        [Test]
        [Parallelizable(ParallelScope.Children)]
        public void ComposeMail()
        {
            Pages.Pages.LogIn.ClickSignInLink();
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