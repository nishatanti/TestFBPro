using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TestFBPro.Utility
{
    [Binding]
    public sealed class Hooks1
    {
        IWebDriver _driver;

        private readonly IObjectContainer container;

        public Hooks1(IObjectContainer container)
        {
            this.container = container;
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("LAUNCH URL");
            _driver = new FirefoxDriver();
            _driver.Manage().Window.Maximize();         
            container.RegisterInstanceAs(_driver);
        }

 
        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("TEST PASS");
            _driver = container.Resolve<IWebDriver>();
            _driver.Close();
            _driver.Quit();
        }
        public IWebDriver Driver => _driver;
    }
}
