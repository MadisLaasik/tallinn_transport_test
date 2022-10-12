using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MyTest2
{
    class FirstTestCase
    {
        static void Main(string[] args)
        {
            

            // locators
            By SoiduplaanidTroll = By.Id("tallinna-linn_trol");
            By TrollNr5Link = By.XPath("//a[@href='#trol/5/a-b']");
            By MustBalta = By.Id("spanDir1");
            By MarjaPeatus = By.XPath("//a[@href='#trol/5/b-a/08302-1']");
            By Lemmikud = By.XPath("//a[@href='#favourites']");

            // definitions
            ChromeOptions options = new ChromeOptions();
            options.SetLoggingPreference(LogType.Browser, LogLevel.All);
        
            IWebDriver webDriver = new ChromeDriver(options);
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));

            // navigation
            webDriver.Navigate().GoToUrl("https://transport.tallinn.ee/");
            wait.Until(e => findElementOrNull(webDriver, SoiduplaanidTroll)).Click();

            wait.Until(e => findElementOrNull(webDriver, TrollNr5Link)).Click();

            wait.Until(e => findElementOrNull(webDriver, MustBalta)).Click();

            wait.Until(e => findElementOrNull(webDriver, MarjaPeatus)).Click();

            wait.Until(e => findElementOrNull(webDriver, Lemmikud)).Click();



        }

        static IWebElement findElementOrNull(IWebDriver webDriver, By locator) {
            try
            {
                var element = webDriver.FindElement(locator);
                return element;
            }
            catch (StaleElementReferenceException)
            {
                return null;
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }
        
       
    }
}
