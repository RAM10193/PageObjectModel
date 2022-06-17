using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageAutomation.PageFns
{
    class Login
    {
        static IWebDriver dr;
        private static By USERNAME    = By.XPath("//input[@name='txtUsername']");
        private static By PASSWORD    = By.XPath("//input[@name='txtPassword']");
        private static By LOGINBUTTON = By.XPath("//input[@value='LOGIN']");
        
        public Login(IWebDriver driver)
        {
            dr = driver;
        }

        public void orangelogin()
        {
            if (dr.FindElement(LOGINBUTTON).Displayed)
            {
                dr.FindElement(USERNAME).SendKeys("Admin");
                dr.FindElement(PASSWORD).SendKeys("admin123");
                dr.FindElement(LOGINBUTTON).Click();
            }
        }
    }
}
