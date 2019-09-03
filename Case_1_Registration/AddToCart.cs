using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace Automate_Website
{
    [TestClass]
    public class AddToCart
    {
        public static IWebDriver driver;
        [TestMethod]
        [Obsolete]
        public void TestMethod1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
            Login();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("header_logo")).Click();

            driver.FindElement(By.XPath("//*[@id='homefeatured']/li[1]/div/div[2]/div[2]/a[1]/span")).Click();
            driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span/span")).Click();

            
            driver.FindElement(By.XPath("//*[@id='homefeatured']/li[3]/div/div[2]/div[2]/a[1]/span")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.LinkText("Proceed to checkout")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.LinkText("Proceed to checkout")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//*[@id='center_column']/form/p/button/span")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.Id("cgv")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//*[@id='form']/p/button/span")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//*[@id='HOOK_PAYMENT']/div[1]/div/p/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//*[@id='cart_navigation']/button/span")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Thread.Sleep(10000);
            driver.Quit();

        }

        public void Login()
        {
         driver.FindElement(By.LinkText("Sign in")).Click();

            driver.FindElement(By.Id("email")).SendKeys("abcdefghy123@gmail.com");
            driver.FindElement(By.Id("passwd")).SendKeys("Password@123");
            driver.FindElement(By.XPath("//*[@id='SubmitLogin']/span")).Click();
        }

    }
}
