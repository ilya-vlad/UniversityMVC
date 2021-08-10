using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Threading;

namespace MVCTest
{  
    public class TestsCourse
    {
        private IWebDriver driver;
        private static readonly int idCourse = 2;
        private static readonly int idGroup = 3;
        private static readonly int idStudent = 92;
        private readonly By groupsButton = By.XPath($"//tr[@id='{idCourse}']//a[text()='Groups']");
        private readonly By studentsButton = By.XPath($"//tr[@id='{idGroup}']//a[text()='Students']");
         
        [SetUp]
        public void Setup()
        {
            //chromedriver для версии 92. Проверено на 92.0.4515.131.
            string dir_chromedriver = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\")) 
                + "chromedriver";
            driver = new OpenQA.Selenium.Chrome.ChromeDriver(dir_chromedriver);
            driver.Navigate().GoToUrl($"https://localhost:44376/");
            driver.Manage().Window.Maximize();            
        }

        [Test]
        public void OpenGroup()
        {
            string expectedUrl = $"https://localhost:44376/courses/{idCourse}/groups/{idGroup}";       
            
            var groups = driver.FindElement(groupsButton);
            groups.Click();
            Thread.Sleep(500);
            var students = driver.FindElement(studentsButton);
            students.Click();
            Thread.Sleep(500);
            string actualUrl = driver.Url;
            Assert.AreEqual(expectedUrl, actualUrl);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}