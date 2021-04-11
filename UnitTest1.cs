using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Task0
{
    [TestFixture]
    public class Tests
    {
       
        IWebDriver driver;        
        public const string url1 = "http://the-internet.herokuapp.com/dynamic_content";
        public const string url2= "http://the-internet.herokuapp.com/upload";
        public const string filePath = "C:\\123.txt";
        public const string inp1 = "input[type=file]";
        public const string inp2 = "input[type=submit]";

        [SetUp]
        public void BeforeTest()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void AfterTest()
        {
            driver.Quit();
        }

        [Test]        
        public void Test1()
        {
            driver.Url=url1;
        }        

        [Test]
        public void Test2()
        {
            driver.Url = url2;
            By fileInput1 = By.CssSelector(inp1);
            driver.FindElement(fileInput1).SendKeys(filePath);
            By fileInput2 = By.CssSelector(inp2);
            driver.FindElement(fileInput2).Click();
        }
    }
}