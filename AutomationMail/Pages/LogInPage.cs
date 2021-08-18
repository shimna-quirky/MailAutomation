using System;
using OpenQA.Selenium;

using System.Collections.Generic;
using System.Linq;
using Framework.Selenium;

namespace AutomationMail.Pages
{
    public class LogInPage
    {
        IWebDriver _driver;
        public static Wait Wait;
        public LogInPage(IWebDriver driver)
        {
            _driver = driver;
            Wait = new Wait(30);
        }

        public IWebElement UserName => _driver.FindElement(By.CssSelector("#login-username"));
        public IWebElement PassWord => _driver.FindElement(By.CssSelector("#login-passwd"));
        public IWebElement SignIn => _driver.FindElement(By.CssSelector("#login-signin"));
        IList<IWebElement> AnchorTag => _driver.FindElements(By.CssSelector("a"));
        public IWebElement AccName => _driver.FindElement(By.CssSelector("#ybarAccountMenuOpener"));
        IList<IWebElement> SpanElements => _driver.FindElements(By.CssSelector("span"));
        IList<IWebElement> InboxElements => _driver.FindElements(By.CssSelector("div[data-test-id='virtual-list'] ul li "));
        public IWebElement DeleteButton => _driver.FindElement(By.CssSelector("button[data-test-id='toolbar-delete']"));
        public IWebElement ComposeButton => _driver.FindElement(By.CssSelector("a[data-test-id='compose-button']"));
        public IWebElement DestinationMail => _driver.FindElement(By.CssSelector("#message-to-field"));
        public IWebElement Subject => _driver.FindElement(By.CssSelector("input[data-test-id='compose-subject']"));
        public IWebElement SendButton => _driver.FindElement(By.CssSelector("button[data-test-id='compose-send-button']"));

        //click on the button login

        public void ClickSignInLink()
        {
            IList<IWebElement> elements = _driver.FindElements(By.CssSelector("a"));
            var element = elements.FirstOrDefault(x => x.Text.Contains("Sign in"));
            element.Click();
        }

        //enter username

        public void EnterUserName(string username)
        {
            UserName.SendKeys(username);

        }

        //enter password
        public void EnterPassword(string password)
        {
            Wait.Until(drv => PassWord.Displayed);
            PassWord.SendKeys(password);

        }

        //click signin

        public void ClickSignin()
        {
            SignIn.Click();
        }

        //CHECK whether login is successful

        public string GetUser()
        {
            return AccName.Text;
        }

        //go to inbox
        public void GoToInbox()
        {
            var elem = SpanElements.FirstOrDefault(x => x.Text.Contains("Mail"));
            elem.Click();
        }
        public int InboxCount()
        {
            return InboxElements.Count;
        }
        //delete first mail
        public void DeleteInbox()
        {



            var ListToDelete = InboxElements[2];
            ListToDelete.FindElement(By.CssSelector("button")).Click();
        }
        //click on the button delete
        public void DeleteSelectedMail()
        {
            DeleteButton.Click();
        }
        public void ComposeMail()
        {
            ComposeButton.Click();
        }
        public void EnterDestinationMail(string destinationmail)
        {
            DestinationMail.SendKeys(destinationmail);
        }
        public void EnterSubject(string subject)
        {
            Subject.SendKeys(subject);
        }
        public void ClickSend()
        {
            SendButton.Click();
        }
    }



}
