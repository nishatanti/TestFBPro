using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using TestFBPro.Utility;

namespace TestFBPro.PagObject
{
    class loginRepo
    {
        private IWebDriver _driver;
        Support supp = new Support();

        public loginRepo(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this._driver = driver;
        }

        [FindsBy(How = How.XPath, Using = "(//a[@href='#SignIn'])[2]")]

        public IWebElement SignInLinkElement { get; set; }
        public void signinlink()
        {
            SignInLinkElement.Click();
        }

        [FindsBy(How = How.Id, Using = "ctl17_LoginTopMenu1_UserLogin_txtUsername")]

        public IWebElement UserIDElement { get; set; }
        public void userId()
        {
            supp.ExplicitWaitElement(10, _driver, UserIDElement);
            UserIDElement.Click();
            UserIDElement.SendKeys("FBUZZ25");
            UserIDElement.SendKeys(Keys.Tab);
        }

        [FindsBy(How = How.Id, Using = "ctl17_LoginTopMenu1_UserLogin_txtPassword")]

        public IWebElement PasswordElement { get; set; }
        public void password()
        {
            PasswordElement.Click();
            PasswordElement.SendKeys("FBUZZ25");
            PasswordElement.SendKeys(Keys.Tab);
            PasswordElement.SendKeys(Keys.Tab);
            PasswordElement.SendKeys(Keys.Tab);
        }

        [FindsBy(How = How.Id, Using = "ctl17_LoginTopMenu1_UserLogin_cmdLogin")]

        public IWebElement SignInBtnElement { get; set; }
        public void signinbtn()
        {
            SignInBtnElement.Click();
        }

        [FindsBy(How = How.Id, Using = "ctl17_LoginTopMenu1_btnwelcome1")]

        public IWebElement LoginMenuElement { get; set; }
        public void loginmenu()
        {
            supp.ExplicitWaitElement(10, _driver, LoginMenuElement);
            Assert.IsTrue(LoginMenuElement.Displayed);

        }

        [FindsBy(How = How.XPath, Using = "(//a[@href='#TASignIn'])[1]")]
        public IWebElement TravelAgentelement { get; set; }

        public void travelagenttab()
        {
            TravelAgentelement.Click();
        }

        [FindsBy(How = How.Id, Using = "ctl17_LoginTopMenu1_UserLogin_txtUsername")]
        public IWebElement txtUserName { get; set; }

        public void UserNameT(string userName)
        {
            txtUserName.SendKeys(userName);
        }

        [FindsBy(How = How.Id, Using = "ctl17_LoginTopMenu1_UserLogin_txtPassword")]
        public IWebElement txtPassword { get; set; }

        public void PasswordT(string password)
        {
            txtPassword.SendKeys(password);
        }

        [FindsBy(How = How.Id, Using = "ctl17_LoginTopMenu1_UserLogin_cmdLogin")]
        public IWebElement enterbutton { get; set; }

        public void loginbutton()
        {
            enterbutton.Click();

        }
    }
}