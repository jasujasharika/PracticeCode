using HVHelper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesVsVillain
{
    [TestFixture]
    public abstract class  HVBaseClass
    {
        public IWebDriver _driver;
        protected string base_url;
        private StringBuilder verificationErrors = new StringBuilder();
        IConfig _config = new ConfigReader();
        public HVBaseClass()
        {
            
        }
        [OneTimeSetUp]
        public void TestSetup()
        {
            
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            
            _driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(2);
            base_url = _config.GetEnvironmentLink();
            _driver.Navigate().GoToUrl(base_url);

        }

        //called before executing every test case
        [SetUp]
        public void BeforeTest()
        {
            try
            {
                _driver.FindElement(By.Id("worrior_username")).Click();
                _driver.FindElement(By.Id("worrior_username")).SendKeys(_config.GetUserName());
                _driver.FindElement(By.Id("warrior")).Click();
                _driver.FindElement(By.Id("start")).Click();
            }
            catch (NoSuchWindowException)
            {
            }
        }
        [OneTimeTearDown]
        public void TearDownTestFixture()
        {
            IConfig _config = new ConfigReader();
            
            try
            {

                _driver.Quit();
            }
            catch (Exception e)
            {
                _driver.Quit();
                verificationErrors.Append(e.StackTrace);
                throw e.InnerException;
            }
           
            /// Ignore cleanup errors 
            Assert.IsEmpty(verificationErrors.ToString());
        }

        [TearDown]
        public void AfterTest()
        {
           

        }
    }
}
