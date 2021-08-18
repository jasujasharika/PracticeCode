using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;


namespace HeroesVsVillain
{
    public class UserSetup : HVBaseClass
    {
        [Test]
        public void CreateUserTest()
        {
            try
            {

                _driver.FindElement(By.Id("worrior_username")).Click();
                _driver.FindElement(By.Id("worrior_username")).SendKeys("CoFighter");
                _driver.FindElement(By.Id("warrior")).Click();
                _driver.FindElement(By.Id("start")).Click();
            }
            catch (Exception e)
            {

                throw e;
            }


        }
    }
}
