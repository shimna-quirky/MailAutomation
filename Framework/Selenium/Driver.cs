using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework.Selenium
{
    public static class Driver
    {
        [ThreadStatic]
        private static IWebDriver _driver;
             
        public static void Init()
        {
            var browser = FW.FConfig.Driver.Browser;
            switch(browser)
            {
                case Browsers.ChromeBrowser:
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("--start-maximized");
                    chromeOptions.AddArgument("--disable-translate");
                    chromeOptions.AddArgument("--disable-popup-blocking");
                    _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),chromeOptions);
                    var drpath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    break;
                default:
                    throw new Exception("");

            }
            
            
        }
        public static IWebDriver Current => _driver ?? throw new NullReferenceException("_driver is null");
    }
}
