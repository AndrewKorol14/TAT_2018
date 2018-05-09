using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace TaskDEV10
{
    /// <summary>
    /// Turn to the av.by and call methods for getting models
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                ChromeDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://av.by");
                driver.Manage().Window.Maximize();
                HomePage homePage = new HomePage(driver);
                homePage.ChooseBrand(args[0]);
                homePage.SetModelList();
                List<Car> cars = homePage.GetModelList();
                foreach(Car car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            catch(NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}