using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class Tests
    {
        //Hooks in Nunit
        [SetUp]
        public void Setup()
        {
            // Browser Driver
            IWebDriver webDriver = new ChromeDriver();
            //Navigate to site
            webDriver.Navigate().GoToUrl("http://localhost:1149/");

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}