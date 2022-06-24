using OpenQA.Selenium;
using PageAutomation.SupportFns;
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
        private static String DATASHEET = "OrangeHRMTestData.xlsx";
        
        public Login(IWebDriver driver)
        {
            dr = driver;
        }

        public void orangelogin()
        {
            ExcelUtil.PopulateInCollection(DATASHEET);
            if (dr.FindElement(LOGINBUTTON).Displayed)
            {
                dr.FindElement(USERNAME).SendKeys(ExcelUtil.ReadData(1, "UserName"));
                dr.FindElement(PASSWORD).SendKeys(ExcelUtil.ReadData(1, "Initial"));
                dr.FindElement(LOGINBUTTON).Click();
            }
        }
    }
}
