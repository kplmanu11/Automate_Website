using System;
using System.Collections.Generic;
using System.Linq;
using Amazon.DynamoDBv2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Automate_Website
{
    [TestClass]
    public class Registration
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            // navigate to URL
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
          
            driver.FindElement(By.XPath("//*[@id=\'header\']/div[2]/div/div/nav/div[1]/a")).Click();
            driver.FindElement(By.XPath("//*[@id=\'email_create\']")).SendKeys("trafford123@gmail.com");
            driver.FindElement(By.XPath("//*[@id=\'SubmitCreate\']")).Click();
            // Select Radio Button
            IList<IWebElement> RadioButtonList = driver.FindElements(By.Name("id_gender"));
            bool bValue = false;
            bValue = RadioButtonList.ElementAt(0).Selected;
            if (bValue == true)
            {
                RadioButtonList.ElementAt(1).Click();
            }
            else
            {
                RadioButtonList.ElementAt(0).Click();
            }


            // Enter customer details
            driver.FindElement(By.XPath("//*[@id='customer_firstname']")).SendKeys("Jason");
            driver.FindElement(By.XPath("//*[@id=\'customer_lastname\']")).SendKeys("Adam");
            driver.FindElement(By.XPath("//*[@id=\'passwd\']")).SendKeys("Password@123");
            // Select date of Birth
            SelectElement sDate = new SelectElement(driver.FindElement(By.XPath("//*[@id=\'days\']")));
            sDate.SelectByValue("2");
            SelectElement sMonth = new SelectElement(driver.FindElement(By.XPath("//*[@id=\'months\']")));
            sMonth.SelectByIndex(4);
            SelectElement sYear = new SelectElement(driver.FindElement(By.XPath("//*[@id=\'years\']")));
            sYear.SelectByValue("2015");
   
            driver.FindElement(By.XPath(".//*[@id=\'newsletter\']")).Click();

            driver.FindElement(By.XPath("//*[@id=\'company\']")).SendKeys("Seva Dev");
            driver.FindElement(By.XPath("//*[@id=\'address1\']")).SendKeys("Sundarbazar");
            driver.FindElement(By.XPath("//*[@id=\'address2\']")).SendKeys("Pokhara");
            driver.FindElement(By.XPath("//*[@id=\'city\']")).SendKeys("Lamjung");
            SelectElement sState = new SelectElement(driver.FindElement(By.XPath("//*[@id=\'id_state\']")));
            sState.SelectByText("Alabama");
            driver.FindElement(By.XPath("//*[@id=\'postcode\']")).SendKeys("12345");
            SelectElement sCountry = new SelectElement(driver.FindElement(By.XPath("//*[@id=\'id_country\']")));
            sCountry.SelectByText("United States");
            driver.FindElement(By.XPath("//*[@id=\'other\']")).SendKeys("Software Company");
            driver.FindElement(By.XPath("//*[@id=\'phone\']")).SendKeys("123457876");
            driver.FindElement(By.XPath("//*[@id=\'phone_mobile\']")).SendKeys("9841567611");
            driver.FindElement(By.XPath("//*[@id=\'alias\']")).SendKeys("Kathmandu");
            driver.FindElement(By.XPath("//*[@id='submitAccount']/span")).Click();
            }

        }
    }
    

