using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//import libraries for using IWebDriver and ChromeDriver
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of IWebDriver interface
            IWebDriver driver1 = new ChromeDriver();

            //go to website 
            driver1.Navigate().GoToUrl("http://www.google.com");

            //find search bar
            IWebElement element = driver1.FindElement(By.Name("q"));

            //Type in search string
            element.SendKeys("Selenium");

            //Submit the value
            element.Submit();

            Thread.Sleep(500);
           
            //since first result is always going to be first h3 tag -- this solution is going to work
            var result = driver1.FindElement(By.TagName("h3"));
            result.Click();

            driver1.Quit();
        }
    }
}
