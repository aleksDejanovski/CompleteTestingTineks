using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestingForTinex
{
    internal class MainPage
    {
        private IWebDriver driver;
        public IWebElement basso => driver.FindElement(By.CssSelector("img[title='МАСЛО маслиново Extra virgin BASSO 750мл']"));

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement osnovniProizvodi => driver.FindElement(By.LinkText("Основни производи"));

        public IWebElement ekstraVergin => driver.FindElement(By.CssSelector("img[title='МАСЛО маслиново Extra virgin BASSO 750мл']"));

        public IWebElement dokazDekaEOtvorenZelatin => driver.FindElement(By.ClassName("naslov_produkt"));

        //Check akcii namaluvanje webelement
        public IWebElement akciiZaNamaluvanje => driver.FindElement(By.Id("akcii_btn1"));

        //Check cesto postavuvani prasanja
        public IWebElement cestoPostavuvani => driver.FindElement(By.CssSelector("a[class='cpp_btn'] div[class='naslov_kopc']"));

        //slag pena element
        public List <IWebElement> slagpena => driver.FindElements(By.CssSelector("img[alt='Основни производи']")).ToList();

      
        // slag pena dodavanje u cart
        public IWebElement slagpenaPlus => driver.FindElement(By.CssSelector("div[class='kolichina_contt'] div[class='increment']"));

        //Slag pena element za dodavanje vo cart
        public IWebElement slagPenaAddToCart => driver.FindElement(By.CssSelector(".kopce_add_cart"));

        //Posle dodavanje na item vo karticka klikanje na karticka element
        public IWebElement cardIcon => driver.FindElement(By.XPath("//a[@class='koshnichka_btn']//div[@class='naslov_kopc']"));

        //element specijalno za test2
        public IWebElement naslovZaMonin => driver.FindElement(By.CssSelector(".naslov_produkt"));
       


        public void op()
        {

            osnovniProizvodi.Click();
        }
        public void openZelatinCard()
        {
            ekstraVergin.Click();
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
            basso.Click();


        }
        public void addtoCart2()
        {
            //slagpena.FirstOrDefault(el => el.Text.Contains("МАСЛО ")).Click();

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