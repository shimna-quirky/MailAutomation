using System;
using OpenQA.Selenium;
using Framework.Selenium;

namespace AutomationMail.Pages
{
    public static class PageFactory
    {
        [ThreadStatic]
        public static LogInPage LogIn;

        public static void Init()
        {
            LogIn = new LogInPage(Driver.Current);
        }
    }
}
