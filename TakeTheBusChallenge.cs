using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using SeleniumExtras.WaitHelpers;

namespace HeroesVsVillain
{
    public class TakeTheBusChallenge : HVBaseClass
    {
        [Test]
        public void ChooseTheBusChallengeWithCorrectAnswers()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            try
            {
                
                if (_driver.FindElement(By.Id("bus")).Displayed)
                {
                    _driver.FindElement(By.Id("bus")).Click();
                    IWebElement btnBusTimeStart = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("bus_timer_start")));
                    btnBusTimeStart.Click();

                    IWebElement btnBusBar = _driver.FindElement(By.Id("bus_bar"));

                    IWebElement eleQuestion1 = _driver.FindElement(By.Id("bus_question_1"));

                    if(eleQuestion1.Displayed && btnBusBar.Displayed)
                    {
                        //choose first correct answer until the end
                        _driver.FindElement(By.Id("bus_answer_1")).Click();
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("close_correct_modal_btn")));
                        _driver.FindElement(By.Id("close_correct_modal_btn")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("restaurant_timer_start")));
                        _driver.FindElement(By.Id("restaurant_timer_start")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("restaurant_answer_1")));
                        _driver.FindElement(By.Id("restaurant_answer_1")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("close_correct_modal_btn")));
                        _driver.FindElement(By.Id("close_correct_modal_btn")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("start")));
                        _driver.FindElement(By.Id("start")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("office_answer_1")));
                        _driver.FindElement(By.Id("office_answer_1")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("close_modal_btn_1")));
                        _driver.FindElement(By.Id("close_modal_btn_1")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("bus_timer_start")));
                        _driver.FindElement(By.Id("bus_timer_start")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("bus_answer_2")));
                        _driver.FindElement(By.Id("bus_answer_2")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("close_correct_modal_btn")));
                        _driver.FindElement(By.Id("close_correct_modal_btn")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("restaurant_timer_start")));
                        _driver.FindElement(By.Id("restaurant_timer_start")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("restaurant_answer_2")));
                        _driver.FindElement(By.Id("restaurant_answer_2")).Click();


                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("close_correct_modal_btn")));
                        _driver.FindElement(By.Id("close_correct_modal_btn")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("start")));
                        _driver.FindElement(By.Id("start")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("office_answer_1")));
                        _driver.FindElement(By.Id("office_answer_1")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("close_modal_btn_1")));
                        _driver.FindElement(By.Id("close_modal_btn_1")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("bus_timer_start")));
                        _driver.FindElement(By.Id("bus_timer_start")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("bus_answer_1")));
                        _driver.FindElement(By.Id("bus_answer_1")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("close_correct_modal_btn")));
                        _driver.FindElement(By.Id("close_correct_modal_btn")).Click();


                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("restaurant_timer_start")));
                        _driver.FindElement(By.Id("restaurant_timer_start")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("restaurant_answer_2")));
                        _driver.FindElement(By.Id("restaurant_answer_2")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("close_correct_modal_btn")));
                        _driver.FindElement(By.Id("close_correct_modal_btn")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("start")));
                        _driver.FindElement(By.Id("start")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("office_answer_1")));
                        _driver.FindElement(By.Id("office_answer_1")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("close_modal_btn_1")));
                        _driver.FindElement(By.Id("close_modal_btn_1")).Click();
                            
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("bus_timer_start")));
                        _driver.FindElement(By.Id("bus_timer_start")).Click();

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("bus_answer_1")));
                        _driver.FindElement(By.Id("bus_answer_1")).Click();
                           
                    }


                }
                else
                {
                    //pick another challenge
                }

            }
            catch(Exception e)
            {
                throw e;
            }
        }
       
        [Test]
        public void ChooseTheChallengeToVisitLeadershipBoard()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            try
            {

                if (_driver.FindElement(By.Id("bus")).Displayed)
                {
                    _driver.FindElement(By.Id("bus")).Click();
                    IWebElement btnBusTimeStart = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("bus_timer_start")));
                    btnBusTimeStart.Click();

                    IWebElement btnBusBar = _driver.FindElement(By.Id("bus_bar"));

                    IWebElement eleQuestion1 = _driver.FindElement(By.Id("bus_question_1"));

                    if (eleQuestion1.Displayed && btnBusBar.Displayed)
                    {
                        //choose first correct answer until the end
                        _driver.FindElement(By.Id("bus_answer_1")).Click();
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("leaderboard_link")));
                        _driver.FindElement(By.Id("leaderboard_link")).Click();
                        

                        IWebElement baseTable = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("showData")));
                        _driver.FindElement(By.Id("showData")).Click();
                        //CoFighter
                        ICollection<IWebElement> rows = baseTable.FindElements(By.TagName("tr"));
                        // for every row
                        foreach (var row in rows)
                        {
                            IList<IWebElement> tds = row.FindElements(By.TagName("td"));
                            
                            if(tds.Count>1)
                            {
                                if(tds[1].Text == "CoFighter")
                                {
                                    Console.WriteLine("Your Score is : " + tds[2]);
                                    break;
                                }

                            }
                            
                        }
                        //Continue playing and/or exit the application

                        _driver.FindElement(By.Id("leaderboard_link")).Click();

                    }


                }
                else
                {
                    //pick another challenge
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
   
}
