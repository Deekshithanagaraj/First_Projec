using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Projec.Utilities
{
    public class Wait
    {
        private static string locatorType;
        private static string locatorValue;

        public static void waitToBeClickable(IWebDriver driver, string locateValue, int seconds)
        {
     
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                if (locatorType == "XPath")
                {
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
                }
                if (locatorType == "Id")
                {
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
                }
                if (locatorType == "CssSelector")
                {
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
                }
                if (locatorType == "Name")
                {
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(locatorValue)));
                }
            }

            public static void WaitToBeVisible(IWebDriver driver, string locatorType, string locatorValue, int seconds)
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                if (locatorType == "XPath")
                {
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
                }
                if (locatorType == "Id")
                {
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
                }
                if (locatorType == "CssSelector")
                {
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));
                }
                if (locatorType == "Name")
                {
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(locatorValue)));
                }
            }

        internal static void WaitToBeClickable(IWebDriver driver, string v1, string v2, int v3)
        {
            throw new NotImplementedException();
        }
    }
    }
