using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDEV10
{
    public class HomePage
    {
        IWebDriver driver;
        IWebElement brand;
        IWebElement model;
        IList<IWebElement> modelList;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private bool CheckBrandInList(string brandName)
        {
            IList<IWebElement> brandList;
            bool isContain = false;
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            brandList = waiter.Until(driver => driver.FindElements(By.XPath("//select[@name=\"brand_id[]\"]/option[@value]")));
            foreach (IWebElement brand in brandList)
            {
                if (brand.Text == brandName)
                {
                    isContain = true;
                    break;
                }
            }
            return isContain;
        }

        public void ChooseBrand(string brandName)
        {
            if(!CheckBrandInList(brandName))
            {
                throw new NoSuchElementException("No such brand in list of brands");
            }
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            brand = waiter.Until(driver => driver.FindElement(By.XPath("//select[@name=\"brand_id[]\"]")));
            brand = waiter.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(brand));
            brand.Click();
            brand = waiter.Until(driver => driver.FindElement(By.XPath("//option[contains(text(), \"" + brandName + "\")]")));
            brand = waiter.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(brand));
            brand.Click();
        }

        public void SetModelList()
        {
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            modelList = waiter.Until(driver => driver.FindElements(By.XPath("//select[@name=\"model_id[]\"]/option[@value]")));
        }

        public List<Car> GetModelList()
        {
            List<Car> carModels = new List<Car>();
            ModelSorter sorter = new ModelSorter();
            foreach (IWebElement element in modelList)
            {
                WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                ChooseModel(element.Text);
                string quantityModel = waiter.Until(driver => driver.FindElement(By.XPath("//span[@class=\"moto-filter-form-counter-bike js-counter-all\"]"))).Text;
                carModels.Add(new Car(element.Text, GetModelNumber(quantityModel)));
            }
            return sorter.SortModels(carModels);
        }

        private void ChooseModel(string modelName)
        {
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            model = waiter.Until(driver => driver.FindElement(By.XPath("//select[@name=\"model_id[]\"]")));
            model = waiter.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(model));
            model.Click();
            model = waiter.Until(driver => driver.FindElement(By.XPath("//option[contains(text(), \"" + modelName + "\")]")));
            model = waiter.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(model));
            model.Click();
        }

        private int GetModelNumber(string quantityModel)
        {
            char[] separator = new char[1] {' '};
            string[] modelNumber = quantityModel.Split(separator);
            return Int32.Parse(modelNumber[0]);
        }
    }
}