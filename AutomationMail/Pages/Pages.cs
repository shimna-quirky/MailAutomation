using System;
using OpenQA.Selenium;
using Framework.Selenium;

namespace AutomationMail.Pages
{
    public class Pages
    {
        [ThreadStatic]
        public static LogInPage LogIn;

        public static void Init()
        {
            LogIn = new LogInPage(Driver.Current);
        }
    }
}
