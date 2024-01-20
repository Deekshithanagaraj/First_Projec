﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Projec.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            //Maximize the browser
            driver.Manage().Window.Maximize();

            //Launch TurnUp Portal and navigate to website login page 
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //Identify username textbook and enter valid username
            IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
            usernameTextBox.SendKeys("hari");

            //Identify password textbook and enter valid password
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");


            //Identify the login button and click on the button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();

        }
    }
}
