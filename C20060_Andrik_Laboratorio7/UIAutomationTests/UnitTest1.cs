using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace UIAutomationTests
{
    public class Selenium
    {
        IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new FirefoxDriver();
        }



        [Test]
        public void Add_Ireland_Country_Test()
        {
            // Arrange
            var URL = "http://localhost:8080/";
            _driver.Manage().Window.Maximize();

            // Act
            _driver.Navigate().GoToUrl(URL);


            var addButton = _driver.FindElement(By.LinkText("Agregar país"));
            addButton.Click();


            System.Threading.Thread.Sleep(1000);


            var nameInput = _driver.FindElement(By.Id("nombre"));
            nameInput.SendKeys("Irlanda");

            var continentSelect = _driver.FindElement(By.Id("continente")); 
            var selectElement = new OpenQA.Selenium.Support.UI.SelectElement(continentSelect);
            selectElement.SelectByText("Europa");


            var languageInput = _driver.FindElement(By.Id("idioma")); 
            languageInput.SendKeys("Inglés");

            var saveButton = _driver.FindElement(By.CssSelector("button[type='submit']"));
            saveButton.Click();

            System.Threading.Thread.Sleep(1000);

            // Assert
            var bodyText = _driver.PageSource;
            Assert.IsTrue(bodyText.Contains("Irlanda"));
        }

        [TearDown]
        public void Teardown()
        {
            _driver.Quit(); 
        }
    }
}
