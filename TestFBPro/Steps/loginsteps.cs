using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestFBPro.PagObject;
using TestFBPro.Utility;

namespace TestFBPro.Steps
{
    [Binding]
    public sealed class loginsteps
    {
        private IWebDriver _driver;
        Support supp;       
        loginRepo lrepo;

        public loginsteps(IWebDriver driver)
        {
            this._driver = driver;
            lrepo = new loginRepo(_driver);
            supp = new Support(_driver);
        }

        [Given(@"User should be on homepage")]
        public void GivenUserShouldBeOnHomepage()
        {
            _driver.Navigate().GoToUrl("https://www.farebuzz.com");
            _driver.Manage().Window.Maximize();
            lrepo.signinlink();
        }


        [When(@"Click on Travelagent tab")]
        public void WhenClickOnTravelagentTab()
        {
            lrepo.travelagenttab();
        }

        [When(@"Enter Username and Password")]
        public void WhenEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            lrepo.UserNameT((string)data.UserName);
            lrepo.PasswordT((string)data.Password);
        }

        [When(@"Click on btob SignIn button")]
        public void WhenClickOnBtobSignInButton()
        {
            lrepo.loginbutton();
        }

        [Then(@"User is sucessfully login for btob")]
        public void ThenUserIsSucessfullyLoginForBtob()
        {
            lrepo.loginmenu();
        }
    }
}
