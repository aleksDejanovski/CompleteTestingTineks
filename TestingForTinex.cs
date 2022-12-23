using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingForTinex
{
    [TestFixture]
    public class TestingForTinex
    {
        IWebDriver driver;
        IWebDriver wait;

        [SetUp]
        public void setiranje()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


        }
        [TearDown]
        public void tearDownMethod()
        {
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        [Category("Check if user can be logged in after entering valid credentials")]
        public void testLogiranjeZaTinexPozitinoScenario()
        {


            LoginPage page = new LoginPage(driver);
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dejanovski_a@yahoo.com", "aceecar88");
            Assert.IsTrue(driver.FindElement(By.Id("ctl00_btnLogOut")).Text.Contains("Одјавете се"));


            MainPage main = new MainPage(driver);


        }
        [Test]
        [Category("Check if user can be logged in after entering invalid credentials")]
        public void testLogiranjeZaTinexNegativnoScenario()
        {
            LoginPage page = new LoginPage(driver);
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dd", "ssd");
            Assert.IsTrue(driver.FindElement(By.Id("ctl00_btnLogOut")).Text.Contains("Одјавете се"));

        }
        [Test]
        [Category("After Login Click osnovniproizvodi")]
        public void CheckIsOsnovniProizvodiClickable()
        {
            LoginPage page = new LoginPage(driver);
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dejanovski_a@yahoo.com", "aceecar88");
            MainPage page2 = new MainPage(driver);
            page2.op();
            Assert.IsTrue(driver.FindElement(By.XPath("//label[@for='checkbox205']")).Text.Contains("Брашно"));

        }
        [Test]
        [Category("After Login At osnovniproizvodi Check If Card Zelatin is OK")]
        public void CheckIfUserCanSelectCard()
        {
            LoginPage page = new LoginPage(driver);
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dejanovski_a@yahoo.com", "aceecar88");
            MainPage page2 = new MainPage(driver);
            page2.op();
            page2.openZelatinCard();
            Assert.IsTrue(page2.dokazDekaEOtvorenZelatin.Text.Contains("BASSO"));


        }
        [Test]
        public void CheckAkciiNamaluvanje()
        {
            LoginPage page = new LoginPage(driver);
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dejanovski_a@yahoo.com", "aceecar88");
            MainPage page2 = new MainPage(driver);
            page2.op();
            page2.akciiZaNamaluvanjeClick();
            Assert.IsTrue(driver.Url.Contains("a=1&f5=1"));


        }
        [Test]
        public void CestoPostavuvaniPrasanja()
        {
            LoginPage page = new LoginPage(driver);
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dejanovski_a@yahoo.com", "aceecar88");
            MainPage page2 = new MainPage(driver);
            page2.cestoPostavuvaniFunckija();
            Assert.IsTrue(driver.FindElement(By.CssSelector(".naslov_tekstualna.input_naslov")).Text.Contains("Често поставувани прашања"));

        }
        [Test]
        public void AddingToCartMaslo()
        {
            LoginPage page = new LoginPage(driver);
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dejanovski_a@yahoo.com", "aceecar88");
            MainPage page2 = new MainPage(driver);
            page2.op();
            page2.addtoCart1();
            //page2.addtoCart2();
            // page2.addToCartClick();
            //Assert.IsTrue(driver.FindElement(By.CssSelector(".kopce_add_cart.dodadeno_kosh_one")).Text.Contains("Додадено во кошничка"));
            page2.clickCardIcon();
            Assert.IsTrue(driver.FindElement(By.CssSelector(".info_txt_cart")).Text.Contains("Производи кои се во вашата кошнич"));

        }
        [Test]
        public void specificTest2()
        {
            LoginPage page = new LoginPage(driver);
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dejanovski_a@yahoo.com", "aceecar88");
            MainPage page2 = new MainPage(driver);
            page2.op();
            List<IWebElement>siteProizvodi = driver.FindElements(By.CssSelector(".grid_category1")).ToList();
            IWebElement moniniElement = siteProizvodi.FirstOrDefault(el => el.Text.Contains("MONINI"));
            moniniElement.Click();
            Assert.IsTrue(page2.naslovZaMonin.Text.Contains("MONINI"));


         


        }
    }

}
