using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryTestFrame.ReusableMethods
{
    public class DriverMethods
    {
        public void FindMyElement(IWebDriver driver ,string by, string locator,string value)
        {
            
            if(by == "name")
            {
                driver.FindElement(By.Name(locator)).SendKeys(value);
            }
            else if (by == "css")   
            {
               driver.FindElement(By.CssSelector(locator)).SendKeys(value);
            };
        }

        public IWebElement FindMyElementAndClick(IWebDriver driver,string locator)
        {
            return driver.FindElement(By.CssSelector(locator));
        }

        public IWebElement FindMyElementAndClick2(IWebDriver driver, string locator)
        {
            var element = driver.FindElement(By.CssSelector(locator));
                element.Click();
            return element; 
        }
        public IWebElement FindMyElements(IWebDriver driver ,string locator)
        {
          return driver.FindElements(By.Name(locator)).First(); 
        }
            
    }
}
