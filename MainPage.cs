using OpenQA.Selenium;
using System;

namespace TestingForTinex
{
    internal class MainPage : BaseClassPage
    {
        

        public MainPage(IWebDriver driver) : base(driver)
        {
        }
        public IWebElement osnovniProizvodi => driver.FindElement(By.LinkText("Основни производи"));

        public IWebElement zelatinCard => driver.FindElement(By.CssSelector("img[title='ЖЕЛАТИН во прав PODRAVKA 10гр.']"));

        public IWebElement dokazDekaEOtvorenZelatin => driver.FindElement(By.ClassName("naslov_produkt"));

        //Check akcii namaluvanje webelement
        public IWebElement akciiZaNamaluvanje => driver.FindElement(By.Id("akcii_btn1"));

        //Check cesto postavuvani prasanja
        public IWebElement cestoPostavuvani => driver.FindElement(By.CssSelector("a[class='cpp_btn'] div[class='naslov_kopc']"));

        //slag pena element
        public IWebElement slagpena => driver.FindElement(By.CssSelector("img[title='ШЛАГ пена HOCHWALD 250мл']"));

        // slag pena dodavanje u cart
        public IWebElement slagpenaPlus => driver.FindElement(By.CssSelector("div[class='kolichina_contt'] div[class='increment']"));

        //Slag pena element za dodavanje vo cart
        public IWebElement slagPenaAddToCart => driver.FindElement(By.CssSelector(".kopce_add_cart"));

        //Posle dodavanje na item vo karticka klikanje na karticka element
        public IWebElement cardIcon => driver.FindElement(By.XPath("//a[@class='koshnichka_btn']//div[@class='naslov_kopc']"));


        public void op()
        {

            osnovniProizvodi.Click();
        }
        public void openZelatinCard()
        {
            zelatinCard.Click();
        }
        // Funkcija za proverka dali raboti akcii za namaluvanje
        public void akciiZaNamaluvanjeClick()
        {
            akciiZaNamaluvanje.Click();
        }

        //Funkcija za cesto postavuvani prasanja
        public void cestoPostavuvaniFunckija()
        {
            cestoPostavuvani.Click();
        }

        //Funkcija za klik na slag pena
        public void addtoCart1()
        {
            slagpena.Click();


        }
        public void addtoCart2()
        {
            slagpenaPlus.Click();

        }
        public void addToCartClick()
        {
         slagPenaAddToCart.Click();
            }

        //funkcija za klikanje na kard ikona
        public void clickCardIcon()
        {
            cardIcon.Click();
        }
        
    }

}