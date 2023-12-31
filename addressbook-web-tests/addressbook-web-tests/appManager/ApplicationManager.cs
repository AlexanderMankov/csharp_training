﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;

namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;

        public ApplicationManager() 
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook";

            loginHelper = new LoginHelper(driver);
            groupHelper = new GroupHelper(driver);
            contactHelper = new ContactHelper(driver);
            navigationHelper = new NavigationHelper(driver, baseURL);
        }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public LoginHelper Auth
        { 
            get 
            { 
                return loginHelper; 
            }
        }
        public NavigationHelper Navigator
        { 
            get 
            { 
                return navigationHelper; 
            } 
        }
        public GroupHelper Groups
        { 
            get 
            { 
                return groupHelper; 
            } 
        }
        public ContactHelper Contacts
        {
            get 
            { 
                return contactHelper;
            }
        }
    }
}
