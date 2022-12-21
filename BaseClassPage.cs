using OpenQA.Selenium;

namespace TestingForTinex
{
    internal class BaseClassPage
    {
        protected IWebDriver driver { get; }

        public BaseClassPage (IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}