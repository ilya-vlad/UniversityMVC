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
        public void EditGroup()
        {
            By pathName = By.XPath($"//tr[@id='{idGroup}']//td[@name='nameGroup']");
            By editGroup = By.XPath($"//tr[@id='{idGroup}']//a[text()='Edit']");
            By pathInputName = By.XPath($"//input[@name='Name']");
            By pathSubmit = By.XPath($"//input[@type='submit']");
            string testName = "TestName";
            bool passed = false;


            driver.Navigate().GoToUrl($"https://localhost:44376/courses/{idCourse}/groups");
            Thread.Sleep(500);
            var oldNameGroup = driver.FindElement(pathName).Text;
            var editorGroup = driver.FindElement(editGroup);
            editorGroup.Click();
            Thread.Sleep(100);
            var inputName = driver.FindElement(pathInputName);
            inputName.Clear();
            inputName.SendKeys(testName);
            var submit = driver.FindElement(pathSubmit);
            submit.Click();            
            driver.Navigate().GoToUrl($"https://localhost:44376/courses/{idCourse}/groups");
            Thread.Sleep(500);
            var newNameGroup = driver.FindElement(pathName).Text;

            if (newNameGroup == testName) passed = true;

            driver.FindElement(editGroup).Click();
            driver.FindElement(pathInputName).Clear();
            driver.FindElement(pathInputName).SendKeys(oldNameGroup);
            driver.FindElement(pathSubmit).Click();            
            Assert.IsTrue(passed);
        }

        [Test]
        public void EditStudent()
        {
            By pathFirstName = By.XPath($"//tr[@id='{idStudent}']//td[@name='FirstName']");
            By pathLastName = By.XPath($"//tr[@id='{idStudent}']//td[@name='LastName']");
            By editStudent = By.XPath($"//tr[@id='{idStudent}']//a[text()='Edit']");
            By pathInputFirstName = By.XPath($"//input[@name='FirstName']");
            By pathInputLastName = By.XPath($"//input[@name='LastName']");
            By pathSubmit = By.XPath($"//input[@type='submit']");

            string testFirstName = "Test FirstName";
            string testLastName = "Test LastName";
            bool passed = false;

            driver.Navigate().GoToUrl($"https://localhost:44376/courses/{idCourse}/groups/{idGroup}");
            Thread.Sleep(100);
            var oldFirstName = driver.FindElement(pathFirstName).Text;
            var oldLastName = driver.FindElement(pathLastName).Text;
            var editorStudent = driver.FindElement(editStudent);
            editorStudent.Click();
            Thread.Sleep(100);

            var inputFirstName = driver.FindElement(pathInputFirstName);
            inputFirstName.Clear();
            inputFirstName.SendKeys(testFirstName);

            var inputLastName = driver.FindElement(pathInputLastName);
            inputLastName.Clear();
            inputLastName.SendKeys(testLastName);

            var submit = driver.FindElement(pathSubmit);
            submit.Click();
            driver.Navigate().GoToUrl($"https://localhost:44376/courses/{idCourse}/groups/{idGroup}");
            Thread.Sleep(100);
            var newFirstName = driver.FindElement(pathFirstName).Text;
            var newLastName = driver.FindElement(pathLastName).Text;
            
            if (newFirstName == testFirstName && newLastName == testLastName) passed = true;

            driver.FindElement(editStudent).Click();

            driver.FindElement(pathInputFirstName).Clear();
            driver.FindElement(pathInputFirstName).SendKeys(oldFirstName);
            driver.FindElement(pathInputLastName).Clear();
            driver.FindElement(pathInputLastName).SendKeys(oldLastName);
            driver.FindElement(pathSubmit).Click();
            Assert.IsTrue(passed);           
        }

        [Test]
        public void RemoveGroup()
        {

        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}