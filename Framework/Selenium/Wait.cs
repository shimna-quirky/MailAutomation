using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Selenium
{
    public class Wait
    {
        private readonly WebDriverWait _wait;
        public Wait(int waitseconds)
        {
            _wait = new WebDriverWait(Driver.Current, TimeSpan.FromSeconds(waitseconds))
            {
                PollingInterval = TimeSpan.FromMilliseconds(500)
            };
            _wait.IgnoreExceptionTypes(
                typeof(NoSuchElementException), 
                typeof(InvalidElementStateException), 
                typeof(StaleElementReferenceException)
                );
        }
        public bool Until(Func<IWebDriver,bool> condition)
        {
            return _wait.Until(condition);
        }
    }
}
